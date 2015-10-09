using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Delopgave2
{
    /// <summary>
    /// Interaction logic for EditAgentWindow.xaml
    /// </summary>
    public partial class EditAgentWindow : Window
    {
        
        public EditAgentWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_Onclick(object sender, RoutedEventArgs e)
        {
            
            DialogResult = true;

        }

        
    }
}
