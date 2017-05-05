﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Web.Models.ViewModels
{
    public class MessageViewModel
    {
        public string Content { get; set; }
        public string Timestamp { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Avatar { get; set; }

        public MessageViewModel(Message message, string avatar)
        {
            this.Content = message.Content;
            this.Timestamp = new DateTime(long.Parse(message.Timestamp)).ToLongTimeString();
            this.From = message.FromUser.DisplayName;
            this.To = message.ToRoom.Name;
            this.Avatar = avatar;
        }

        public MessageViewModel()
        {

        }
    }
}