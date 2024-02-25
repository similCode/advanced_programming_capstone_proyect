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
    public enum EngineType
    {
        /// <summary>
        /// Gasolina como fuente de energía.
        /// </summary>
        Electric,

        /// <summary>
        /// Petróleo como fuente de energía.
        /// </summary>
        oil,

        gasoline
    }
}