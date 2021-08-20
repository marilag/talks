using MediatR;
using mentor.events;
using mentor.models;
using shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mentor.commands
{
    public class CreateMentorHandler : IRequestHandler<CreateMentor, CreateMentor>
    {
        private readonly IMediator _mediator;
        private readonly ICosmosDBSQLService _cosmos;

        public CreateMentorHandler(IMediator mediator, ICosmosDBSQLService cosmos)
        {
            _mediator = mediator;
            _cosmos = cosmos;

        }
        public async Task<CreateMentor> Handle(CreateMentor request, CancellationToken cancellationToken)
        {
            var mentor = new Mentor()
            {
                MentorCode = request.MentorCode,
                FirstName = request.FirstName,
                LastName = request.LastName,
                City = request.City,
                Gender = request.Gender
            };

            var container = await _cosmos.GetOrCreateContainerAsync("Mentors", "/MentorCode");
            var response = await container.CreateItemAsync(mentor, new Microsoft.Azure.Cosmos.PartitionKey(mentor.MentorCode));


            await _mediator.Publish<MentorCreated>(new MentorCreated()
            {
                Id = mentor.Id,
                MessageData = request              
            });

            return request;
        }
    }
}
