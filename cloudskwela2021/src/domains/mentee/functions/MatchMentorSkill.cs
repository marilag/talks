using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace mentee.functions
{
    public class MatchMentorSkill
    {
        [FunctionName("MatchMentorSkill")]
        public void Run([QueueTrigger("matchskillsqueue", Connection = "MatchMentorSkillQueue")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Yay nakuha ko na ang message: {myQueueItem}");
        }
    }
}
