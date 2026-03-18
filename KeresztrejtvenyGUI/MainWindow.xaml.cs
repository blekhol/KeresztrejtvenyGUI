using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeresztrejtvenyGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 6; i < 16; i++)
            {
                sorcb.Items.Add(i);
                oszlopcb.Items.Add(i);
			}
            sorcb.SelectedItem = 15;
			oszlopcb.SelectedItem = 15;
            
            for (int i = 1; i < 11; i++)
            {
                indexcb.Items.Add(i);
			}
            indexcb.SelectedItem = 3;
		}
    }
}