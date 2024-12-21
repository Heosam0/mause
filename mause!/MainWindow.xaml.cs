using System;
using System.Media;
using System.Windows;
using System.Windows.Input;

namespace mause_
{
 
    public partial class MainWindow : Window
    {
        public double screenWidth = SystemParameters.PrimaryScreenWidth; 
        public double screenHeight = SystemParameters.PrimaryScreenHeight; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PlayRandomSoundButton_Click();
            MainWindow window = new MainWindow();
            Random random = new Random();
            window.Height = random.Next(200, 1200);
            window.Width = random.Next(100, 1000);
            window.Left = screenWidth  * random.NextDouble();
            window.Top = screenHeight  * random.NextDouble();
            window.Show();
        }

        private void PlayRandomSoundButton_Click()
        {
            Action[] systemSounds = new Action[]
            {
                () => SystemSounds.Asterisk.Play(),
                () => SystemSounds.Beep.Play(),
                () => SystemSounds.Exclamation.Play(),
                () => SystemSounds.Hand.Play(),
                () => SystemSounds.Question.Play()
            };

            var random = new Random();
            int randomIndex = random.Next(systemSounds.Length);

            systemSounds[randomIndex]();
        }
    }
}
