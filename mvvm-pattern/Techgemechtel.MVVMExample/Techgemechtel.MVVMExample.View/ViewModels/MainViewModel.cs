using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Techgemechtel.MVVMExample.View.Models;
using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.View.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;

            _addNoteCommand = new RelayCommand(AddNote, () => CanAddNote);
            _deleteNoteCommand = new RelayCommand<NoteModel>(DeleteNote);

            if (IsInDesignMode)
            {
                Notes = new ObservableCollection<NoteModel>()
                {
                    new NoteModel()
                    {
                        Note = "Hello World",
                        IsFinished = false
                    },
                    new NoteModel()
                    {
                        Note = "Hello moon",
                        IsFinished = false
                    },
                    new NoteModel()
                    {
                        Note = "Bye",
                        IsFinished = true
                    }
                };
            }
            else
            {
                Initialize();
            }
        }

        private async void Initialize()
        {
            Notes = await _dataService.GetTasks();
        }

        private ObservableCollection<NoteModel> _notes;
        public ObservableCollection<NoteModel> Notes
        {
            get { return _notes; }
            set { Set(ref _notes, value); }
        }

        private string _newNote;
        public string NewNote
        {
            get { return _newNote; }
            set
            {
                if (Set(ref _newNote, value))
                    _addNoteCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly RelayCommand _addNoteCommand;
        public ICommand AddNoteCommand => _addNoteCommand;

        public bool CanAddNote => !string.IsNullOrEmpty(NewNote);

        public void AddNote()
        {
            Notes.Add(new NoteModel()
            {
                Note = NewNote
            });
            NewNote = "";
        }

        private readonly RelayCommand<NoteModel> _deleteNoteCommand;
        public ICommand DeleteNoteCommand => _deleteNoteCommand;

        public void DeleteNote(NoteModel model)
        {
            Notes.Remove(model);
        }
    }
}
