using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VendingMachine.Model;

namespace VendingMachine.View
{
    /// <summary>
    /// Interaction logic for ucOrderView.xaml
    /// </summary>
    public partial class ucOrderView : UserControl
    {
        List<BeverageItems> colItems;
        BackgroundWorker worker;

        public ucOrderView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Beverage beverage = (Beverage)DataContext;
            colItems = beverage.Items;
            lstItems.ItemsSource = colItems;
            StartWorker();
        }

        private void StartWorker()
        {

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 0; i <= colItems.Count - 1; ++i)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                BeverageItems beverageItems = colItems.ElementAt(i);
                beverageItems.ImagePath = "Refresh";
                worker.ReportProgress(i);
                Thread.Sleep(700);
            }

            for (int i = 0; i <= colItems.Count - 1; ++i)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                BeverageItems beverageItems = colItems.ElementAt(i);
                beverageItems.ImagePath = "Check";
                worker.ReportProgress(i);
                Thread.Sleep(500);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lstItems.ItemsSource = null;
            lstItems.Items.Clear();
            lstItems.ItemsSource = colItems;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                btnAction.Style = (Style)Resources["btnCancel"];
                btnBack.IsEnabled = true;
            }
            else
            {
                btnAction.Style = (Style)Resources["btnComplete"];
                btnBack.IsEnabled = true;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ucBeverageList ucList = new ucBeverageList();
            DockPanel docParent = (DockPanel)this.Parent;
            docParent.Children.Clear();
            docParent.Children.Add(ucList);
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btnAction.Content.ToString() == "Cancel Order")
            {
                worker.CancelAsync();
            }
        }
    }
}
