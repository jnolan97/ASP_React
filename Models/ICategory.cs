using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_React.Models
{
    public interface ICategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
