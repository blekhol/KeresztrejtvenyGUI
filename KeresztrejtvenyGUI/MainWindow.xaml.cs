using System;
using System.IO;
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
					a.MaxLength = 1;
					a.MouseDoubleClick += (s, ev) =>
					{
						if (a.Text == "-")
						{
							a.Text = "#";
						}
						else
						{
							a.Text = "-";
						}
					};

					mezok.Children.Add(a);
				}
			}
		}

		private void mentes_Click(object sender, RoutedEventArgs e)
		{
			List<string> ki = [];

			int ind = (int)indexcb.SelectedItem;
			int oszlopokSzama = (int)oszlopcb.SelectedItem;

			string sor = "";
			int sz = 0;

			foreach (var item in mezok.Children)
			{
				TextBox a = (TextBox)item;
				sor += a.Text;
				sz++;
				if (sz == oszlopokSzama)
				{
					ki.Add(sor);
					sz = 0;
					sor = "";
				}
			}
			try
			{
				File.WriteAllLines($"kr{ind}.txt", ki);
				MessageBox.Show("A keresztrejtvény mentése sikeres");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}