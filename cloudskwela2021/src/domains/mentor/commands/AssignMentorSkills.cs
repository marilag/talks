using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.commands
{
    public class AssignMentorSkills : IRequest
    {
        public string MentorCode { get; set; }
        public string[] Skills { get; set; }
    }
}
