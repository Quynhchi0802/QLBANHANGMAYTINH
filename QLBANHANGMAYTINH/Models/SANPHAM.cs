namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [Key]
        public int MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        public decimal DonGia { get; set; }

        public string CauHinh { get; set; }

        public string HinhAnh { get; set; }

        public int MaNCC { get; set; }

        public int MaNSX { get; set; }

        public int MaLoaiSP { get; set; }
    }
}
