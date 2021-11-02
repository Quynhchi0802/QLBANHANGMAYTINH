namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHASANXUAT")]
    public partial class NHASANXUAT
    {
        [Key]
        public int MaNSX { get; set; }

        [StringLength(150)]
        public string TenNSX { get; set; }

        public string ThongTin { get; set; }
    }
}
