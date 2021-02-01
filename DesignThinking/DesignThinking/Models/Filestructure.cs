using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Models
{
    [Table("filestructure")]
    public class Filestructure
    {
        [Key]
        public int ident { get; set; }
        public int ProtocolIdent { get; set; }
        public int TaskIdent { get; set; }
        public byte[] Image { get; set; }
    }
}
