using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
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

		private void letrehozas_Click(object sender, RoutedEventArgs e)
		{
			mezok.Children.Clear();

			int sorokSzama = (int)sorcb.SelectedItem;
			int oszlopokSzama = (int)oszlopcb.SelectedItem;
			for (int r = 0; r < sorokSzama; r++)
			{
				for (int c = 0; c < oszlopokSzama; c++)
				{
					TextBox a = new TextBox();
					a.Text = "-";
					a.Width = 20;
					a.Height = 20;
					a.TextAlignment = TextAlignment.Center;
					a.Margin = new Thickness(c * 22, r * 22, 0, 0);

					mezok.Children.Add(a);
				}
			}
		}
	}
}