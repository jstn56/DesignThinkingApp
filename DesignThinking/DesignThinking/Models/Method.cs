using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DesignThinking.Models
{
    [Table("methods")]
    public class Method : IEntity<int>
    {
        [Key]
        public int ident { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Weblink { get; set; }
        public string RoomType { get; set; }
        public string ThinkingType { get; set; }
    }
}

