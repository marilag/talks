using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentor.models
{
    public class MentorSkill
    {
        [JsonProperty("id")]
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public string MentorCode { get; set; }
        public string Skill { get; set; }
    }
}
