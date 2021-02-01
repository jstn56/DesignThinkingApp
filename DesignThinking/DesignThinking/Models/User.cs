using System;
using System.ComponentModel;
using Dapper.Contrib.Extensions;
using DesignThinking.Interfaces;

namespace DesignThinking.Models
{
    [Table("users")]
    public class User : IEntity<int>
    {
        [Key]
        public int ident { get; set; }
        public int TeamIdent { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return Surname;
        }
    }
}
