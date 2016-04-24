using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Techgemechtel.MVVMExample.View.Models
{
    public class NoteModel : ObservableObject
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
