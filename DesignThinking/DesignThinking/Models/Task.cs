using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;
using Xamarin.Forms;

namespace DesignThinking.Models
{
    [Table("tasks")]
    public class Task : IEntity<int>
    {
        [Key]
        public int ident { get; set; }
        public int TeamIdent { get; set; }
        public int UserIdent { get; set; }
        public string ShortDescription { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        
        [Write(false)]
        public byte[] Image { get; set; }
        [Write(false)]
        public User User { get; set; }
        public string Priority { get; set; }
    }
}
