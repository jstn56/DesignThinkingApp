using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignThinking.Base;
using DesignThinking.Models;

namespace DesignThinking.Interfaces
{
    public interface IProtocolMethodRepository : IRepository<int, ProtocolMethod>
    {
        /// <summary>
        /// Loads an image based on the protocol method
        /// </summary>
        /// <param name="protocolMethod"></param>
        void LoadImage(ProtocolMethod protocolMethod);

        void SaveImage(ProtocolMethod protocolMethod, byte[] array);

        Task<IEnumerable<Filestructure>> GetAllAsync();
    }
}
