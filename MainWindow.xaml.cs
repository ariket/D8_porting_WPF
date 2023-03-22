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
using static System.Net.Mime.MediaTypeNames;

namespace D8_porting_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Gör all initiering nedanför den här texten!
            string Ititle = Scenery.HelpTitle();
            string Itext = Scenery.HelpText();
            
            Title.Text = Ititle;
            Text.Text = "Välkommen till sceneriet!\n\n\n" + Itext + "Skriv 'h' för hjälp, 'x' för att sluta!";
            
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            string output = "Key pressed: ";
            output += e.Key.ToString();
            KeyPressDisplay.Text = output;
            if(e.Key == Key.Escape || e.Key == Key.X || e.Key == Key.Q)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if(e.Key == Key.S)
            {
                Scenery.DoCommand("s");
                Title.Text = Scenery.CurrentTitle("s"); ;
                Text.Text = Scenery.CurrentText("s");
            }
            else if (e.Key == Key.F)
            {
                Scenery.DoCommand("f");
                Title.Text = Scenery.CurrentTitle("f"); ;
                Text.Text = Scenery.CurrentText("f");
            }
            else if (e.Key == Key.N)
            {
                Scenery.DoCommand("n");
                Title.Text = Scenery.CurrentTitle("n"); ;
                Text.Text = Scenery.CurrentText("n");
            }
            else if (e.Key == Key.H)
            {
                Title.Text = "HELP";
                Text.Text = Scenery.HelpText();
            }
           

        }
    }
}
