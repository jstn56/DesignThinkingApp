using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Business.Service
{
    public class ProtocolService : IProtocolService
    {
        private IProtocolRepository protocolRepository;
        public ProtocolService()
        {
            protocolRepository = new ProtocolRepository();
        }
        public bool Delete(Protocol model) => protocolRepository.Delete(model);

        public Protocol Get(int key) => protocolRepository.Get(key);

        public IEnumerable<Protocol> GetAll() => protocolRepository.GetAll();

        public bool Save(Protocol model) => protocolRepository.Save(model);

        public bool Update(Protocol model, int key) => protocolRepository.Update(model, key);
    }
}
