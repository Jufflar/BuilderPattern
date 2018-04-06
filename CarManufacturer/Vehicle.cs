using System.Collections.Generic;

namespace CarManufacturer
{
    public class Vehicle
    {
        private readonly Dictionary<string, string> _parts =
            new Dictionary<string, string>();

        // Constructor

        public Vehicle(string vehicleType)
        {
            Type = vehicleType;
        }

        // Indexer

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public string Type { get; }
    }
}