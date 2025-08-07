using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimoniaiByIdQuery : IRequest<List<GetTestimonialQueryResult>>
    {
        public int Id { get; set; }
        public GetTestimoniaiByIdQuery(int id)
        {
            Id = id;
        }
    }
}
