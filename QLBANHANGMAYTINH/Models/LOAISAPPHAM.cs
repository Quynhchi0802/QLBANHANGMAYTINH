namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISAPPHAM")]
    public partial class LOAISAPPHAM
    {
        [Key]
        public int MaLoaiSP { get; set; }

        [StringLength(100)]
        public string TenLoaiSP { get; set; }
    }
}
