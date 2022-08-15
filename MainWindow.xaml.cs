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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Basketball_Score
{
        /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;

        public MainWindow()
        {
            InitializeComponent();

            
        }             

        private void button1TeamA_Click(object sender, RoutedEventArgs e)
        {            
            int number=Int32.Parse(scoreTeamA.Text);
            number++;
            scoreTeamA.Text=number.ToString();
        }

        private void button2TeamA_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamA.Text);
            number+=2;
            scoreTeamA.Text = number.ToString();
        }

        private void button3TeamA_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamA.Text);
            number+=3;
            scoreTeamA.Text = number.ToString();
        }
        private void buttonMinusScoreTeamA_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamA.Text);
            number--;
            scoreTeamA.Text = number.ToString();
        }

        private void buttonMinusScoreTeamB_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamB.Text);
            number--;
            scoreTeamB.Text = number.ToString();
        }

        private void button1TeamB_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamB.Text);
            number ++;
            scoreTeamB.Text = number.ToString();
        }

        private void button2TeamB_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(scoreTeamB.Text);
            number += 2;
            scoreTeamB.Text = number.ToString();
        }

        private void button3TeamB_Click(object sender, RoutedEventArgs e)
        { 
            int number = Int32.Parse(scoreTeamB.Text);
            number += 3;
            scoreTeamB.Text = number.ToString();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromMinutes(10);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tTimer.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            },
            Application.Current.Dispatcher);

            _timer.Start();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void buttonRestart_Click(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tTimer.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            },
            Application.Current.Dispatcher);

            _timer.Start();
        }
    }
}
