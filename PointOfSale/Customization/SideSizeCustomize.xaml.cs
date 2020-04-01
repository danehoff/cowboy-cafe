using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using Size = CowboyCafe.Data.Enums.Size;

namespace PointOfSale.Customization
{
    /// <summary>
    /// Interaction logic for SideSizeCustomize.xaml
    /// </summary>
    public partial class SideSizeCustomize : Window
    {

        private Order connection;

        public SideSizeCustomize(object dataContent)
        {
            connection = (Order)dataContent;
            InitializeComponent();
        }

        /// <summary>
        /// Filters which control was pressed and changes the holding state of the respective item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Side s;
            Size size;
            if (DataContext is ChiliCheeseFries)
                s = (ChiliCheeseFries)DataContext;
            else if (DataContext is CornDodgers)
                s = (CornDodgers)DataContext;
            else if (DataContext is PanDeCampo)
                s = (PanDeCampo)DataContext;
            else
                s = (BakedBeans)DataContext;


            switch (((Button)sender).Name)
            {
                //Size Cases
                case "SmallButton":
                    size = Size.Small;
                    break;
                case "MediumButton":
                    size = Size.Medium;
                    break;
                case "LargeButton":
                    size = Size.Large; 
                    break;
                default:
                    throw new NotImplementedException("Unknown Size Button Pressed");
            }
           /// connection.subtotalHelperFunction(s, size);
           /// connection.InvokePropertyChanged();
        }

    }
}
