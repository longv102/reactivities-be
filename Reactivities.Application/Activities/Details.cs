﻿using MediatR;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }

            public class Handler : IRequestHandler<Query, Activity>
            {
                private readonly ReactivitiesContext _context;

                public Handler(ReactivitiesContext context)
                {
                    _context = context;
                }

                public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
                {
                    return await _context.Activities.FindAsync(request.Id);
                }
            }
        }
    }
}
