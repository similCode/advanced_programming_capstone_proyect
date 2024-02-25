using System;
namespace CarRental.Domain.Entities.Insurance
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Insurance
    {
        public enum Status
        {
            Enable,

            Disable,
        }

        public string PolicyNumber { get; }

        public Date ExpirationDate { get; set; }

        public Date ExpeditionDate { get; set; }
    }
}

