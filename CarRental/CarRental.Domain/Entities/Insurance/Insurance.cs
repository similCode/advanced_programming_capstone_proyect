﻿using System;

namespace CarRental.Domain.Entities.Insurances
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

        public DateTime ExpirationDate { get; set; }

        public DateTime ExpeditionDate { get; set; }
    }
}