using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techgemechtel.MVVMExample.View.Models;
using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.View.Services
{
    public class DataService : IDataService
    {
        public async Task<ObservableCollection<NoteModel>> GetTasks()
        {
            return new ObservableCollection<NoteModel>()
            {
                new NoteModel()
                {
                    IsFinished = false,
                    Note = "Write tutorial"
                },

                new NoteModel()
                {
                    IsFinished = false,
                    Note = "Do mvvm graphic"
                },

                new NoteModel()
                {
                    IsFinished = true,
                    Note = "Follow Rule 1"
                }
            };
        }
    }
}
