using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ResourceDictionaryUWP.Resources
{
    public partial class MyDataTemplate
    {
        public MyDataTemplate()
        {
            this.InitializeComponent();
            //this.InitializeComponent();
        }

        private void SubQytyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var textbox = (btn.Parent as Grid).Children[1] as TextBox;
            textbox.Text = "6";
        }

        private void AddQytyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
