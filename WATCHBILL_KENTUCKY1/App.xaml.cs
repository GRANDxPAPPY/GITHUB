namespace KENTUCKY_WATCHBILL1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "KENTUCKY_WATCHBILL1" };
        }
    }
}
