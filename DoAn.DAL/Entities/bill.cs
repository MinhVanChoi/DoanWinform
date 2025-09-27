namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bill")]
    public partial class bill
    {
        public int id { get; set; }

        public int? total_price { get; set; }

        public int? status { get; set; }

        public DateTime? create_date { get; set; }

        public int? id_user { get; set; }
    }
}
