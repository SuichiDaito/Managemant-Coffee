﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyHoaDonDTO
    {
        public int MaHD {  get; set; }
        public int MaNV { get; set;}
        public int MaBan {  get; set; }
        public int MaKhuyenMai { get; set; }
        public DateTime NgayLap { get; set; }
        public bool TrangThai { get; set; }
    }
}
