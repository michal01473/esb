using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace esb.Models
{
    public class Resources
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_zasob { get; set; }
        public string nazwa_zasobu { get; set; }
        public string typ_zasobu { get; set; }
        public bool status { get; set; }
        public string uwagi { get; set; }
    }
}