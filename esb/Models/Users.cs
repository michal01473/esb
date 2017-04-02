using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace esb.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_uzytkownika { get; set; }
        public string typ_konta { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string stanowisko { get; set; }
        public string mail { get; set; }
        public bool status { get; set; }
        public string uwagi { get; set; }

    }
}