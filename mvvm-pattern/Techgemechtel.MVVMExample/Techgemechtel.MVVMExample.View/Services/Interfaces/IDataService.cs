using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techgemechtel.MVVMExample.View.Models;

namespace Techgemechtel.MVVMExample.View.Services.Interfaces
{
    public interface IDataService
    {
        Task<ObservableCollection<NoteModel>> GetTasks();
    }
}
