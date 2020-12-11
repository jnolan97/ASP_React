using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_React.Models
{
    public interface ITaskRepository
    {
        
            IEnumerable<Task> AllTasks { get; }
            //IEnumerable<Task> TaskCategory { get; }
            Task GetTaskById(int taskId);
        
    }
}
