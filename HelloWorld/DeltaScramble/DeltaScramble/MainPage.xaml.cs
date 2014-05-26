using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace DeltaScramble
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        public string ScrambleWord(string s)
        {
            char[] c = new char[11];
            int index = 0;
            Random rand = new Random();
            while (s.Length > 0)
            {
                int nxt = rand.Next(0, s.Length - 1);
                c[index] = s[nxt];
                s = s.Substring(0, nxt) + s.Substring(nxt + 1);
                ++index;
            }

            return new String(c);
        }


        private void btnScramble_Click(object sender, RoutedEventArgs e)
        {
            lblHello.Text = ScrambleWord(lblHello.Text);
        }
    }
}