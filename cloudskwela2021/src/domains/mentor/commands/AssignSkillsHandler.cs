using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mentor.commands
{
    public class AssignSkillsHandler : IRequestHandler<AssignSkills>
    {
        public Task<Unit> Handle(AssignSkills request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
