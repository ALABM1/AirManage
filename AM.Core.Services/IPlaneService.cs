﻿using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IPlaneService : IService<Plane>
    {
        IList<Passenger> GetPassengers(Plane p);
        IList<Flight> GetFlights(int nbPlane);



    }
}
