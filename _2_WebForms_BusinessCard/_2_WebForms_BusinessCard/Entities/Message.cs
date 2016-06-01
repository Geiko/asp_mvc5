using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2_WebForms_BusinessCard.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}