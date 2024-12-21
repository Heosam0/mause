using System;
using System.Media;
using System.Windows;
using System.Windows.Input;

namespace mause_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double screenWidth = SystemParameters.PrimaryScreenWidth; // Ширина экрана
        public double screenHeight = SystemParameters.PrimaryScreenHeight; // Высота экрана

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
            // Массив доступных системных звуков
            Action[] systemSounds = new Action[]
            {
                () => SystemSounds.Asterisk.Play(),
                () => SystemSounds.Beep.Play(),
                () => SystemSounds.Exclamation.Play(),
                () => SystemSounds.Hand.Play(),
                () => SystemSounds.Question.Play()
            };

            // Генерация случайного индекса
            var random = new Random();
            int randomIndex = random.Next(systemSounds.Length);

            // Воспроизведение случайного звука
            systemSounds[randomIndex]();
        }
    }
}
