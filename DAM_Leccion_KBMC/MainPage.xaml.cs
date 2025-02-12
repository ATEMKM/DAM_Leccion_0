using DAM_Leccion_KBMC.Model;
using DAM_Leccion_KBMC.ViewModel;

namespace DAM_Leccion_KBMC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public PersonaModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("Asistente del sistema","Se a guardado el reistro de la BD","Aceptar");

            //personaModel.Nombre = "Alondra";
            //personaModel.Apellido = "Montalvo";
            //personaModel.Edad = "98";

        }
    }

}
