using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.DAL.Interfaces
{
    public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        IRepository<TEntity> Rep { get; }
        int ExecuteCommand(string cmd);
        bool Save();

    }
}
