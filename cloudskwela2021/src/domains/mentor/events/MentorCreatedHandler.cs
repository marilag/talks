using MediatR;
using mentor.commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mentor.events
{
    public class MentorCreatedHandler : INotificationHandler<MentorCreated>
    {
        private readonly IMediator _mediator;
        public MentorCreatedHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task Handle(MentorCreated notification, CancellationToken cancellationToken)
        {
            var command = new AssignMentorSkills()
            {
                MentorCode = notification.MessageData.MentorCode,                
                Skills = notification.MessageData.Skills

            };

            await _mediator.Send(command);
            
        }
    }
}
