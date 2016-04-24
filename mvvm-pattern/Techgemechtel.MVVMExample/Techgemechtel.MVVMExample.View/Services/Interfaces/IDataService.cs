using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Techgemechtel.MVVMExample.View.Models;

namespace Techgemechtel.MVVMExample.View.Services.Interfaces
{
    public interface IDataService
    {
        Task<ObservableCollection<NoteModel>> GetTasks();
    }
}
