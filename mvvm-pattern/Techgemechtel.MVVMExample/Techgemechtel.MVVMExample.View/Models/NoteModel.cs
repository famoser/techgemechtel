using Techgemechtel.MVVMExample.View.Models.Base;

namespace Techgemechtel.MVVMExample.View.Models
{
    public class NoteModel : ModelBase
    {
        private string _note;
        public string Note
        {
            get { return _note; }
            set { Set(ref _note, value); }
        }

        private bool _isFinished;
        public bool IsFinished
        {
            get { return _isFinished; }
            set { Set(ref _isFinished, value); }
        }
    }
}
