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
using BMI;

namespace wpf_BMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttonszamol_Click(object sender, RoutedEventArgs e)
        {
            //int magassag = int.Parse(tbx_magassag.Text);
            //int.TryParse(tbx_magassag.Text, out int magassag);
            //int suly=int.Parse(tbx_suly.Text);
            if (double.TryParse(tbx_magassag.Text, out double magassag) && double.TryParse(tbx_suly.Text, out double suly) && magassag>0 && suly>0)
            {
                var egyember=new Ember("",2004,"",magassag,suly);
                double tti = egyember.TestTomegIndex();
                tbl_tti.Text = Convert.ToString(Math.Round(tti,2));
                tbl_eredmeny.Text = egyember.BMITablaGUI();
            }
            else
            {
                MessageBox.Show("Hibás számadat");
                tbx_magassag.Clear();
                tbx_suly.Clear();
            }
            
        }

        private void Buttonujszamol_Click(object sender, RoutedEventArgs e)
        {
            tbx_magassag.Clear();
            tbx_suly.Clear();
            tbl_tti.Text="";
            tbl_eredmeny.Text = "";
        }
    }
}
