using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.models
{
    public class Mentor
    {
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }        
    }
}
