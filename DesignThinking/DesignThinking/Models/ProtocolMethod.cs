using System;
using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;
using Xamarin.Forms;

namespace DesignThinking.Models
{
    [Table("protocolmethods")]
    public class ProtocolMethod : IEntity<int>
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int ident { get; set; }
        public int ProtocolIdent { get; set; }
        [Write(false)]
        public Method Method { get; set; }
        public int MethodIdent { get; set; }
        public string RoomType { get; set; }
        public string ThinkingType { get; set; }
        public bool IsCompleted { get; set; }
        public int Rating { get; set; }
        [Write(false)]
        public byte[] Image { get; set; }
    }
}