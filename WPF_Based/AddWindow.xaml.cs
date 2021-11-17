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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            Type_CB.ItemsSource = Enum.GetValues(typeof(WeaponType));
        }

        public Weapon weapon { get; private set; }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            var type = (WeaponType)Type_CB.SelectedItem;
            weapon = new Weapon(Name_TB.Text, type, AmmoSize_TB.Text, int.Parse(AmmoCount_TB.Text));
            Close();
        }
    }
}
