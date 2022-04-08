using Library.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Library.Utils
{
    public class BusinessUtil
    {
        public static bool PhoneMatches(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
            {
                if (phone.Length != 13) return false;
                if (phone.StartsWith("+994") == false) return false;
                List<string> phoneIndexes = new List<string>() { "50", "55", "77", "70", "51", "10", "99", "60" };
                string operatorIndex = phone.Substring(4, 2);
                if (!phoneIndexes.Contains(operatorIndex)) return false;

                for (int i = 6; i < phone.Length; i++)
                {
                    if (char.IsDigit(phone[i]) == false) return false;
                }

                return true;
            }

            return true;
        }


        public static void DoAnimation(MessageDialog dialog)
        {
            DoubleAnimation da = new DoubleAnimation();
            CircleEase ease = new CircleEase() { EasingMode = EasingMode.EaseOut };

            da.From = 0;
            da.To = 50;
            da.Duration = TimeSpan.FromMilliseconds(2500);
            da.EasingFunction = ease;
            dialog.BeginAnimation(FrameworkElement.HeightProperty, da);

            DispatcherTimer timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 2, 500) };
            timer.Tick += (sender, args) =>
            {
                da.From = 50;
                da.To = 0;
                da.Duration = TimeSpan.FromMilliseconds(1250);
                da.EasingFunction = ease;
                dialog.BeginAnimation(FrameworkElement.HeightProperty, da);
                timer.Stop();
            };
            timer.Start();
        }

    }
}
