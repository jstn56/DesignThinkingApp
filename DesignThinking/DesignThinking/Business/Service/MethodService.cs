using System;
using System.Collections.Generic;
using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Service
{
    public class MethodService : IMethodService
    {
        private IMethodRepository methodRepository;
        public MethodService()
        {
            methodRepository = new MethodRepository();
        }

        public bool Delete(Method model) => methodRepository.Delete(model);

        public Method Get(int key) => methodRepository.Get(key);

        public IEnumerable<Method> GetAll() => methodRepository.GetAll();

        public bool Save(Method model) => methodRepository.Save(model);

        public bool Update(Method model, int key) => methodRepository.Update(model, key);
    }
}
