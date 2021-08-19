using MediatR;
using mentor.commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.events
{
    public class MentorCreated :  INotification
    {
        public string Id { get; set; }
        public CreateMentor MessageData { get; set; }
    }
}
