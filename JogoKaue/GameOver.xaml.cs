using Microsoft.Maui.Controls;

namespace JogoKaue;

public partial class GameOverPage : ContentPage
{
        public GameOverPage()
        {
            InitializeComponent();
        }
        private void CliclarVolta (object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage();
        }
}