using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace XamarinExample.WPF
{
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new XamarinExample.App());
        }
    }
}
