using MediatR;
using mentor.events;
using mentor.models;
using shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mentor.commands
{
    public class AssignMentorSkillsHandler : IRequestHandler<AssignMentorSkills>
    {
        private readonly ICosmosDBSQLService _cosmos;
        private readonly IMediator _mediator;

        public AssignMentorSkillsHandler(IMediator mediator,ICosmosDBSQLService cosmos)
        {
            _cosmos = cosmos;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(AssignMentorSkills request, CancellationToken cancellationToken)
        {
            var container = await _cosmos.GetOrCreateContainerAsync("Mentors", "/MentorCode");

            var taskList = new List<Task>();
            request.Skills.ToList().ForEach(s => {
                var mentorSkill = new MentorSkill()
                {
                    MentorCode = request.MentorCode,
                    Skill = s
                };
               taskList.Add(container.CreateItemAsync(mentorSkill, new Microsoft.Azure.Cosmos.PartitionKey(mentorSkill.MentorCode)));
            });

            await Task.WhenAll(taskList);

            await _mediator.Publish<MentorSkillsAssigned>(new MentorSkillsAssigned()
            {
                MentorCode = request.MentorCode,
                Skills = request.Skills
            });

            return new Unit();

        }
    }
}
