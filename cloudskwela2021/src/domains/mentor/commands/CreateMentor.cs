using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.commands
{
    public class CreateMentor : IRequest<CreateMentor>
    {
        public string MentorCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string[] Skills { get; set; }
    }
}
