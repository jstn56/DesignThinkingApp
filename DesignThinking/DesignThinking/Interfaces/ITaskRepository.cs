using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignThinking.Base;
using DesignThinking.Models;

namespace DesignThinking.Interfaces
{
    public interface ITaskRepository : IRepository<int, Models.Task>
    {
        void LoadImage(Models.Task task);

        void SaveImage(Models.Task task, byte[] array);

        Task<IEnumerable<Filestructure>> GetAllAsync();
    }
}