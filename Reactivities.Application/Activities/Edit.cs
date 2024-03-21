using AutoMapper;
using MediatR;
using Reactivities.Persistence;

namespace Reactivities.Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Domain.Activity Activity { get; set; } = null!;
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivitiesContext _context;
            private readonly IMapper _mapper;

            public Handler(ReactivitiesContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Activity.Id);
                //activity.Title = request.Activity.Title ?? activity.Title;

                _mapper.Map(request.Activity, activity);


                await _context.SaveChangesAsync();
            }
        }
    }
}
