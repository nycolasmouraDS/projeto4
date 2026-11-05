using Microsoft.Extensions.DependencyInjection;

namespace projeto4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
<<<<<<< HEAD

            MainPage = new NavigationPage(new NewPage1());

=======
>>>>>>> 3397ed4fdde034bd7318cc6cb2b4d4e44e9dfbc8
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
<<<<<<< HEAD
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;

=======
            return new Window(new AppShell());
>>>>>>> 3397ed4fdde034bd7318cc6cb2b4d4e44e9dfbc8
        }
    }
}