using System;
using Windows.UI.Xaml.Controls;
using CloneMasterDetail.Services;
using CloneMasterDetail.UWP.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImpl))]
namespace CloneMasterDetail.UWP.Services
{
    public class TextToSpeechImpl : ITextToSpeech
    {
        public async void Speak(string text)
        {
            var mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(text);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
