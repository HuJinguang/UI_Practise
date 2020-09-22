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

namespace MusicPlayer.Views
{
    /// <summary>
    /// MenuView.xaml 的交互逻辑
    /// </summary>
    public partial class MenuView : UserControl
    {
        public string SelectedTitle
        {
            get { return (string)GetValue(SelectedTitleProperty); }
            set { SetValue(SelectedTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedTitleProperty =
            DependencyProperty.Register("SelectedTitle", typeof(string), typeof(MenuView), new PropertyMetadata(""));





        public MenuView()
        {
            InitializeComponent();
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyListBox.SelectedIndex == -1) return;
            if (OnLineListBox?.SelectedIndex >= 0)
            {
                OnLineListBox.SelectedIndex = -1;
            }
            SelectedTitle = ((((sender as ListBox).SelectedItem as ListBoxItem).Content as StackPanel).Children[1] as TextBlock).Text;
        }

        private void OnLineListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OnLineListBox.SelectedIndex == -1) return;
            if (MyListBox?.SelectedIndex >=0)
            {
                MyListBox.SelectedIndex = -1;
            }
            SelectedTitle = ((((sender as ListBox).SelectedItem as ListBoxItem).Content as StackPanel).Children[1] as TextBlock).Text;
        }
    }
}
