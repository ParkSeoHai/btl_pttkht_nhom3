namespace GUI_BHQA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MaKH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string MaSP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        public int? SoLuong { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
