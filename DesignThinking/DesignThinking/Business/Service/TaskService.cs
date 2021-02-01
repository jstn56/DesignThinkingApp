using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Service
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository;
        public TaskService()
        {
            taskRepository = new TaskRepository();
        }
        public bool Delete(Models.Task model) => taskRepository.Delete(model);

        public Models.Task Get(int key) => taskRepository.Get(key);

        public IEnumerable<Models.Task> GetAll() => taskRepository.GetAll();

        public Task<IEnumerable<Filestructure>> GetAllAsync() => taskRepository.GetAllAsync();

        public void LoadImage(Models.Task task) => taskRepository.LoadImage(task);

        public bool Save(Models.Task model) => taskRepository.Save(model);

        public void SaveImage(Models.Task task, byte[] array) => taskRepository.SaveImage(task, array);

        public bool Update(Models.Task model, int key) => taskRepository.Update(model, key);
    }
}
