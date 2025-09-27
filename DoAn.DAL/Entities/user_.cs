namespace DoAn.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_
    {
        public int id { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string fullname { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int? role { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? status { get; set; }
    }
}
