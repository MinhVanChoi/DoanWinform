namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class discount_product
    {
        [Key]
        [StringLength(255)]
        public string idInfo { get; set; }

        public int? discount { get; set; }

        public DateTime? create_date { get; set; }
    }
}
