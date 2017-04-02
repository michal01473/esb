using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace esb.Models
{
    public class Documents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_dokument { get; set; }
        public string data_zawarcia { get; set; }
        public string data_zakonczenia { get; set; }
        public string uwagi { get; set; }
        public string zalacznik { get; set; }
    }
}