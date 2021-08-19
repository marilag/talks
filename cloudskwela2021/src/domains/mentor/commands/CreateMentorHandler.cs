using MediatR;
using mentor.events;
using mentor.models;
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

        public CreateMentorHandler(IMediator mediator)
        {
            _mediator = mediator;

        }
        public async Task<CreateMentor> Handle(CreateMentor request, CancellationToken cancellationToken)
        {
            var mentor = new Mentor()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                City = request.City,
                Gender = request.Gender
            };


            await _mediator.Publish<MentorCreated>(new MentorCreated()
            {
                Id = mentor.Id,
                MessageData = request
              
            });

            return request;
        }
    }
}
