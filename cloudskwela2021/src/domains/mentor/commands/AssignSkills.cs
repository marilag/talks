using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.commands
{
    public class AssignSkills : IRequest
    {
        public string Id { get; set; }
        public string[] Skills { get; set; }
    }
}
