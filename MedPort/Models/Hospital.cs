using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedPort.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}