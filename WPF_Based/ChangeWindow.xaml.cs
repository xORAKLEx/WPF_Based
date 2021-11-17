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
using System.Windows.Shapes;

namespace WPF_Based
{
    /// <summary>
    /// Логика взаимодействия для ChangeWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        public ChangeWindow(Weapon w)
        {
            InitializeComponent();
            weapon = w;
            Name_TB.Text = weapon.Name;
            Type_TB.Text = weapon.Type.ToString();
            AmmoSize_TB.Text = weapon.AmmoSize;
            AmmoCount_TB.Text = weapon.AmmoCount.ToString();
        }

        public Weapon weapon { get; }

        private void Change_Button_Click(object sender, RoutedEventArgs e)
        {
            weapon.AmmoCount = int.Parse(AmmoCount_TB.Text);
            Close();
        }
    }
}
