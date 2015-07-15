using WPFMediaKit.DirectShow.Controls;

namespace SampleApplication
{
    public partial class WebCamPlayerWindow
    {
        public WebCamPlayerWindow()
        {
            InitializeComponent();

            videoElement.VideoCaptureDevice = MultimediaUtil.VideoInputDevices[0];
            videoElement2.VideoCaptureDevice = MultimediaUtil.VideoInputDevices[1];
        }
    }
}
