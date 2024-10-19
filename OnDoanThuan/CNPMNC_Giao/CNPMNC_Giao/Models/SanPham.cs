﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMNC_Giao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.BaoHanhs = new HashSet<BaoHanh>();
            this.BinhLuans = new HashSet<BinhLuan>();
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.ChiTietGioHangs = new HashSet<ChiTietGioHang>();
            this.DanhGiaSanPhams = new HashSet<DanhGiaSanPham>();
            this.KichCoes = new HashSet<KichCo>();
            this.LichSuGiamGiaSanPhams = new HashSet<LichSuGiamGiaSanPham>();
            this.LichSuGiaSanPhams = new HashSet<LichSuGiaSanPham>();
            this.MauSacs = new HashSet<MauSac>();
            this.SanPhamYeuThiches = new HashSet<SanPhamYeuThich>();
        }
    
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int GiaTienMoi { get; set; }
        public int GiaTienCu { get; set; }
        public string MoTa { get; set; }
        public string AnhSP { get; set; }
        public int MaVatLieu { get; set; }
        public int MaDanhMuc { get; set; }
        public System.DateTime NgayTao { get; set; }
        public int MaNhaCungCap { get; set; }

        // Thuộc tính mới để theo dõi số lượt xem chi tiết
        public int SoLuotXem { get; set; } = 0;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPhams { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KichCo> KichCoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuGiamGiaSanPham> LichSuGiamGiaSanPhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuGiaSanPham> LichSuGiaSanPhams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MauSac> MauSacs { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual VatLieu VatLieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamYeuThich> SanPhamYeuThiches { get; set; }
    }
}
