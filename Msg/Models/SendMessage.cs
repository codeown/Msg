﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Msg.Models
{
    public class SendMessage
    {
        public int Id { get; set; } //Id сообщения
        public DateTime DateTime { get; set; }
        public int FromUser { get; set; }
        public int ToUser { get; set; }
    }
}