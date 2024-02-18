using System;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicle
{
    public class Cycle : Vehicle
    {
        public CycleType Type { get; }
    }
}