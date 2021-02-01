using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Service
{
    public class ProtocolMethodService : IProtocolMethodService
    {
        private IProtocolMethodRepository protocolMethodRepository;
        public ProtocolMethodService()
        {
            protocolMethodRepository = new ProtocolMethodRepository();
        }

        public bool Delete(ProtocolMethod model) => protocolMethodRepository.Delete(model);


        public ProtocolMethod Get(int key) => protocolMethodRepository.Get(key);


        public IEnumerable<ProtocolMethod> GetAll() => protocolMethodRepository.GetAll();

        public Task<IEnumerable<Filestructure>> GetAllAsync() => protocolMethodRepository.GetAllAsync();

        public void LoadImage(ProtocolMethod protocolMethod) => protocolMethodRepository.LoadImage(protocolMethod);

        public bool Save(ProtocolMethod model) => protocolMethodRepository.Save(model);

        public void SaveImage(ProtocolMethod protocolMethod, byte[] array) => protocolMethodRepository.SaveImage(protocolMethod, array);

        public bool Update(ProtocolMethod model, int key) => protocolMethodRepository.Update(model, key);
    }
}
