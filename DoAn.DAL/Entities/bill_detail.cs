namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bill_detail
    {
        public int id { get; set; }

        public int? amount { get; set; }

        public int? sum_price { get; set; }

        public int? id_product { get; set; }

        public int? id_bill { get; set; }
    }
}
