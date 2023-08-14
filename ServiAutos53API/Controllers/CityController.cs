using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Task;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Aplication.Countries
{

    public class Consultas
    {
        public class ListCountry : IRequest<List<Country>>{}

        public class Manipulative : IRequestHandler<ListCountry, List<Country>>
        {
            private readonly ServiAutosContext context;
            public Manipulative(ServiAutosContext _contex){
                context = _contex;
            }

            public async Task<List<Country>> Handle(ListCountry request, CancellationToken cancellationToken)
            {
                var countries = await context.Countries.ToListAsync();
                return countries;
            }
        }

    }

}