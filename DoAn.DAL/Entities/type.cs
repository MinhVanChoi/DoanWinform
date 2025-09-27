namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("type")]
    public partial class type
    {
        [Key]
        [StringLength(255)]
        public string idName { get; set; }

        public int? size_from { get; set; }

        public int? size_to { get; set; }
    }
}
