using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AuvoChallenge.Models.Enums;

namespace AuvoChallenge.Models
{
    public class Transfer
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Valor (R$)")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Value { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Observação")]
        public string Observation { get; set; }

        [Display(Name = "Tipo")]
        public TransferType Type { get; set; }

        public Transfer()
        {
        }

        public Transfer(int id, string name, double value, DateTime date, string observation, TransferType type)
        {
            Id = id;
            Name = name;
            Value = value;
            Date = date;
            Observation = observation;
            Type = type;

        }

        public double TotalValue()
        {
            return Value += Value;
        }
    }
}
