namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUNHAP")]
    public partial class CHITIETPHIEUNHAP
    {
        [Key]
        public int MaChiTietPN { get; set; }

        public int  MaSP { get; set; }

        public decimal DonGiaNhap { get; set; }

        public int SoLuongNhap { get; set; }
    }
}
