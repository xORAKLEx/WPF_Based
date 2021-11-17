using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_Based
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Weapon> weapons;

        public MainWindow()
        {
            InitializeComponent();
            weapons = new ObservableCollection<Weapon>();
            Weapon_DG.ItemsSource = weapons;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddWindow();
            window.ShowDialog();
            weapons.Add(window.weapon);
        }

        private void Change_Button_Click(object sender, RoutedEventArgs e)
        {
            var item = (Weapon)Weapon_DG.SelectedItem;
            var index = weapons.IndexOf(item);
            var window = new ChangeWindow(item);
            window.ShowDialog();
            weapons.RemoveAt(index);
            weapons.Insert(index, window.weapon);
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            var item = (Weapon)Weapon_DG.SelectedItem;
            weapons.Remove(item);
        }
    }
}
