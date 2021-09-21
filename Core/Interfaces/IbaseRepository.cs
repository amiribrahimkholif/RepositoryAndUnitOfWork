using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IbaseRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
