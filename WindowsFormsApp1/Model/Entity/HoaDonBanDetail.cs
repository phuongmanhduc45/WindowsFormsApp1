﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanThuoc.Model.Entity
{
    public class HoaDonBanDetail
    {
        public int Id { get; set; }
        public int IdThuoc { get; set; }
        public int SoLuong { get; set; }
        public float GiamGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
