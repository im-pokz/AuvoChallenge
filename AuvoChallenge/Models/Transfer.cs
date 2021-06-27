using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuvoChallenge.Models
{
    public class Transfer
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Value { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Observação")]
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
