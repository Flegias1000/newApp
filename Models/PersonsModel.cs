using NewApp.Entities;
using System;
using System.Collections.Generic;

namespace NewApp.Models
{
    public class PersonsModel
    {
        public Persons person { get; set; } = new Persons();
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}
