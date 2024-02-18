using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Types
{
    /// <summary>
    /// Fuentes de energía utilizada por los vehículos.
    /// </summary>
    public enum EnergyType
    {
        /// <summary>
        /// Gasolina como fuente de energía.
        /// </summary>
        Electrical,

        /// <summary>
        /// Petróleo como fuente de energía.
        /// </summary>
        InternalCombustion,
    }
}