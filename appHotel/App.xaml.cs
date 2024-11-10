
using appHotel.Models;

namespace appHotel
{
    public partial class App : Application
    {
        public List<quarto> lista_quartos = new List<quarto>
        {
            new quarto()
            {
                descricao="Suíte Super Luxo",
                ValorDiariaAdulto=210.00,
                ValorDiariaCrianca=95.00
            },
            new quarto()
            {
             descricao="Suíte Luxo",
                ValorDiariaAdulto=110.00,
                ValorDiariaCrianca=65.00
            },
             new quarto()
            {
             descricao="Suíte Single",
                ValorDiariaAdulto=99.00,
                ValorDiariaCrianca=35.00
                  },
             new quarto()
            {
             descricao="Suíte Crise",
                ValorDiariaAdulto=75.00,
                ValorDiariaCrianca=25.00

             }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaodaHospedagem());
            MainPage = new NavigationPage(new Views.Sobre());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window =base.CreateWindow(activationState);
            window.Width = 400;
            window.Height= 600;
            return window;
        }
    }
}
