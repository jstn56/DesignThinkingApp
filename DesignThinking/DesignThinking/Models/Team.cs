using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;

namespace DesignThinking.Models
{
    [Table("teams")]
    public class Team : IEntity<int>
    {
        [Key]
        public int ident { get; set; }
        public string Name { get; set; }

        [Write(false)]
        public IEnumerable<User> UserList { get; set; } = new List<User>();
        [Write(false)]
        public IEnumerable<Models.Task> Tasks { get; set; } = new List<Models.Task>();
    }
}
