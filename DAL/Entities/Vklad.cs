namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vklad")]
    public partial class Vklad
    {
        public int Id { get; set; }

        public DateTime DateOpen { get; set; }

        public int Balance { get; set; }

        public int Prog_code { get; set; }

        public int Client_code { get; set; }

        public virtual Client Client { get; set; }

        public virtual Prog Prog { get; set; }

    }
}
