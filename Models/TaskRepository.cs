using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP_React.Models
{
    public class TaskRepository: ITaskRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public TaskRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Task> AllTasks
        {
            get
            {
                return _appDbContext.Task.Include(c => c.Category);
            }
        }


        public Task GetTaskById(int taskId)
        {
            return _appDbContext.Task.FirstOrDefault(t => t.Id == taskId);
        }
    }
}
