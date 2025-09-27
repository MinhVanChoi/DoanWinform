namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int id { get; set; }

        [StringLength(20)]
        public string code { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? price { get; set; }

        public int? gender { get; set; }

        public int? amount { get; set; }

        public DateTime? create_date { get; set; }

        public int? status { get; set; }

        [StringLength(255)]
        public string id_type { get; set; }

        [StringLength(255)]
        public string id_discount { get; set; }

        [StringLength(300)]
        public string link { get; set; }
    }
}
