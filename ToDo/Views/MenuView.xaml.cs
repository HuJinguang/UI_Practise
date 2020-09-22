using System;
using System.Collections.Generic;
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

namespace ToDo.Views
{
    /// <summary>
    /// MenuView.xaml 的交互逻辑
    /// </summary>
    public partial class MenuView : UserControl
    {
        private int _menuListOldSelected = -1;

        public MenuView()
        {
            InitializeComponent();
        }

        private void SearchCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _menuListOldSelected = menuListBox.SelectedIndex;
            menuListBox.SelectedIndex = -1;
        }

        private void SearchCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (_menuListOldSelected != -1)
            {
                menuListBox.SelectedIndex = _menuListOldSelected;
            }
        }

        private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (menuListBox.SelectedIndex != -1)
            {
                _menuListOldSelected = menuListBox.SelectedIndex;
                if ((bool)searchCheckBox.IsChecked)
                {
                    searchCheckBox.IsChecked = false;
                }
            }
        }
    }
}
