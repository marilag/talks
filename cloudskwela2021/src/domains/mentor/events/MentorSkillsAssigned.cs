using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.events
{
    public class MentorSkillsAssigned : INotification
    {
        public string MentorCode { get; set; }
        public string[] Skills { get; set; }
    }
}
