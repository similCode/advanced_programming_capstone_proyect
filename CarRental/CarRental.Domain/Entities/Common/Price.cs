using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Common;

/// <summary>
/// Precio de una entidad del concesionario.
/// </summary>
public class Price : Entity
{
    #region Properties

    /// <summary>
    /// Divisa a en la que se expresa el valor del automóvil.
    /// </summary>
    public MoneyType Currency { get; set; }

    /// <summary>
    /// Valor del precio.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Constructor requerido por EntityFrameworkCore para migraciones
    /// </summary>
    protected Price()
    { }

    /// <summary>
    /// Inicializa los precios
    /// </summary>
    /// <param name="currency">Divisa a en la que se expresa el valor del automóvil.</param>
    /// <param name="value">Valor del precio.</param>
    public Price(MoneyType currency, double value)
    {
        Currency = currency;
        Value = value;
    }

    #endregion Properties
}