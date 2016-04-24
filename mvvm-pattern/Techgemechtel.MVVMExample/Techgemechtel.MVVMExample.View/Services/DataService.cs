using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Techgemechtel.MVVMExample.View.Models;
using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.View.Services
{
    public class DataService : IDataService
    {
        /// <summary>
        /// download notes from sever, read out from storage...
        /// this is just a dummy implementation
        /// </summary>
        /// <returns></returns>
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
