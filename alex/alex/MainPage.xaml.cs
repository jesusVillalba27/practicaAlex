namespace alex
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      

        // Métodos para redirigir a las diferentes páginas
        private async void OnPage1ButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Page1());
        }

        private async void OnPage2ButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Page2());
        }

        private async void OnPage3ButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Page3());
        }

        private async void OnPage4ButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Page4());
        }

        private async void OnPage5ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new jesusv());
        }
    }
}
