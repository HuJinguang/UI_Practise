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
    /// PlayingMusicCardView.xaml 的交互逻辑
    /// </summary>
    public partial class PlayingMusicCardView : UserControl
    {
        public bool IsLove
        {
            get { return (bool)GetValue(IsLoveProperty); }
            set { SetValue(IsLoveProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsLove.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLoveProperty =
            DependencyProperty.Register("IsLove", typeof(bool), typeof(PlayingMusicCardView), new PropertyMetadata(false));



        public PlayingMusicCardView()
        {
            InitializeComponent();
        }

        private void LoveButton_Click(object sender, RoutedEventArgs e)
        {
            IsLove = !IsLove;
            loveImage.Source = FindResource(IsLove ? "Love" : "LoveOutLine") as ImageSource;
        }
    }
}
