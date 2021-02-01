using DesignThinking.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Base
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
    }
}
