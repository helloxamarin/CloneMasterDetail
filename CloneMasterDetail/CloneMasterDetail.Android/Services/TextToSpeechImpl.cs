using Android.Speech.Tts;
using CloneMasterDetail.Droid.Services;
using CloneMasterDetail.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImpl))]
namespace CloneMasterDetail.Droid.Services
{
    public class TextToSpeechImpl : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        private TextToSpeech _speaker;
        private string _toSpeak;

        public void Speak(string text)
        {
            _toSpeak = text;
            if (_speaker == null)
            {
                _speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                _speaker.Speak(_toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                _speaker.Speak(_toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
