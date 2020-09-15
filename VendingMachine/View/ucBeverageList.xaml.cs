using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using VendingMachine.ViewModel;

namespace VendingMachine.View
{
    /// <summary>
    /// Interaction logic for ucBeverageList.xaml
    /// </summary>
    public partial class ucBeverageList : UserControl
    {
        public ucBeverageList()
        {
            InitializeComponent();
            this.DataContext = new BeveragesViewModel();
        }

        private void lstBeverages_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.ListView lst = (System.Windows.Controls.ListView)sender;
            if (lst.SelectedItem != null)
            {
                Beverage selectedItem = (Beverage)lst.SelectedItem;

                ucOrderView ucOrder = new ucOrderView();
                ucOrder.DataContext = selectedItem;
                DockPanel docParent = (DockPanel)this.Parent;
                docParent.Children.Clear();
                docParent.Children.Add(ucOrder);
            }
        }
    }
}
