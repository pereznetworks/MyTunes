using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace MyTunes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /* BindingContext = new StateContainerViewModel(); // or resolve from DI/Resource*/
        }

        void OnPlayPauseButtonClicked(object sender, EventArgs args)
        {
            if (MyTunes.CurrentState == MediaElementState.Stopped ||
                MyTunes.CurrentState == MediaElementState.Paused)
            {
                MyTunes.Play();
            }
            else if (MyTunes.CurrentState == MediaElementState.Playing)
            {
                MyTunes.Pause();
            }
        }

        void OnStopButtonClicked(object sender, EventArgs args)
        {
            MyTunes.Stop();
        }
    }
}
