using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinExample
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new ViewModel();
        }
    }

    class ViewModel
    {
        readonly Thing[] _things;

        public ViewModel()
        {
            _things = new Thing[]
            {
                new Thing("A thing"),
                new Thing("B thing"),
                new Thing("C thing")
            };
        }

        public IEnumerable<Thing> Things => _things;
    }

    class Thing
    {
        public Thing(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
