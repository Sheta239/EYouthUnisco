﻿using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Queries.GetSessionsList
{
    public class GetSessionsListQuery : IRequest<List<EYouthUnisco.Domain.Session>>
    {

    }
}
