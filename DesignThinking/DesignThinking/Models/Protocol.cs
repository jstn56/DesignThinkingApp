using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Models
{
    [Table("protocols")]
    public class Protocol : IEntity<int>
    {
        [Key]
        public int ident { get; set; }
        public int TeamIdent { get; set; }
        [Write(false)]
        public IEnumerable<ProtocolMethod> ProtocolMethods { get; set; } = new List<ProtocolMethod>();
        public DateTime Created { get; set; }
    }
}