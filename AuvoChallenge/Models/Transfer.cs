using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuvoChallenge.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }

        public Transfer()
        {
        }

        public Transfer(int id, string name, double value, DateTime date, string observation)
        {
            Id = id;
            Name = name;
            Value = value;
            Date = date;
            Observation = observation;
        }

        public double TotalValue()
        {
            return Value += Value;
        }
    }
}
