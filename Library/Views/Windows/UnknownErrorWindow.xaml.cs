using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Library.Views.Windows
{
    /// <summary>
    /// Interaction logic for UnknownErrorWindow.xaml
    /// </summary>
    public partial class UnknownErrorWindow : Window
    {
        Timer timer;
        public UnknownErrorWindow(double Width, double Height, string errorMessage)
        {
            this.Width = Width * 0.2;
            this.Height = Height * 0.2;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
            txtErrorMessage.Text = errorMessage;
            Close();
            timer = new Timer { Interval = 1000 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        int count = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
                this.Close();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= WindowClosing;
            e.Cancel = true;
            var anim = new DoubleAnimation(0, TimeSpan.FromSeconds(3));
            anim.Completed += (s, _) => this.Close();
            BeginAnimation(OpacityProperty, anim);
        }
    }
}
