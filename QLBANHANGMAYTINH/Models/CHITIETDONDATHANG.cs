namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONDATHANG")]
    public partial class CHITIETDONDATHANG
    {
        [Key]
        public int MaChiTietDDH { get; set; }

        public int MaDonDH { get; set; }

        public int MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }
    }
}
