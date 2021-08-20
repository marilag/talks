using MediatR;
using shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mentor.events
{
    public class MentorSkillsAssignedEventGridHandler : INotificationHandler<MentorSkillsAssigned>
    {
        private readonly IEventGridService _eventgrid;

        public MentorSkillsAssignedEventGridHandler(IEventGridService eventgrid)
        {
            _eventgrid = eventgrid;
        }
        public async Task Handle(MentorSkillsAssigned notification, CancellationToken cancellationToken)
        {
            await _eventgrid.PublishEventsAsync(new List<EventGridPublishMessage>() { new EventGridPublishMessage() {
                       Id = Guid.NewGuid().ToString(),
                        DataVersion = "1.0",
                        Data = new EventObject() { EventType = "MentorSkillsAssigned", EventData = notification },
                        Subject = "MentorSkillsAssigned"
                }});
        }
    }
}
