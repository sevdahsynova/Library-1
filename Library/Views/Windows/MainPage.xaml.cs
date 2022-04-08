using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMenuItemClick(object sender, RoutedEventArgs e)
        {
            CircleEase ease = new CircleEase() { EasingMode = EasingMode.EaseOut };
            DoubleAnimation da = new DoubleAnimation();
            Button button = (Button)sender;
            Grid grid;
            switch (button.Name)
            {
                case nameof(btnCatalogs): grid = grdCatalogs; break;
                case nameof(btnReports): grid = grdReports; break;
                case nameof(btnOperations): grid = grdOperations; break;
                default: return;
            }

            int childCount = ((StackPanel)grid.Children[0]).Children.Count;

            if (grid.Height != 0)
            {
                da.To = 0;
            }
            else
            {
                da.To = childCount * 30;
            }

            da.Duration = TimeSpan.FromMilliseconds(childCount * 150);
            da.EasingFunction = ease;
            grid.BeginAnimation(HeightProperty, da);
        }
   
    }
}
