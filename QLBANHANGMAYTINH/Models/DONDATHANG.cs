namespace QLBANHANGMAYTINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [Key]
        public int MaDonDH { get; set; }

        public int MaKH { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime NgayGiao { get; set; }

        public bool TinhTrangGiao { get; set; }

        public bool DaThanhToan { get; set; }
    }
}
