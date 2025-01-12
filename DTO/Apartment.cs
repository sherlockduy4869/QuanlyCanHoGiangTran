﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCanHoGiangTran.DTO
{
    public class Apartment
    {
        private string _macanho;
        private string _tenchuho;
        private string _masothue;
        private string _hinhthucthuthue;
        private string _coquanthuthue;
        private string _duan;
        private string _daily;
        private string _email;
        private string _phone;

        private double _thue;
        private double _phikekhaithue;
        private double _phiquanly;
        private double _tienrefundkhach;
        private double _phidonvesinh;
        private double _tienthu;
        private double _tienthuemotthang;

        private DateTime _ngaybatdau;
        private DateTime _ngayketthuc;

        private int _songaynhacnho;
        private int _chuky;
        public Apartment(DataRow row)
        {
            _tenchuho = (string)row["TENCHUHO"];
            _macanho = (string)row["MACANHO"];
            _duan = (string)row["DUAN"];
            _masothue = (string)row["MASOTHUE"];
            _hinhthucthuthue = (string)row["HINHTHUCKHAITHUE"];
            _coquanthuthue = (string)row["COQUANTHUTHUE"];
            _thue = (double)row["THUE"];
            _phikekhaithue = (double)row["PHIKEKHAITHUE"];
            _phiquanly = (double)row["PHIQUANLY"];
            _tienrefundkhach = (double)row["TIENREFUNDKHACH"];
            _phidonvesinh = (double)row["PHIDONVESINH"];
            _tienthu = (double)row["TIENTHU"];
            _tienthuemotthang = (double)row["TIENTHUEMOTTHANG"];
            _chuky = (int)row["CHUKY"];
            _ngaybatdau = (DateTime)row["NGAYBATDAU"];
            _ngayketthuc = (DateTime)row["NGAYKETTHUC"];
            _songaynhacnho = (int)row["SONGAYNHACNHO"];
            _daily = (string)row["DAILY"];
            _email = (string)row["EMAIL"];
            _phone = (string)row["PHONE"];
        }
        public string Macanho
        {
            get { return _macanho; }
            set { _macanho = value; }
        }
        public string Tenchuho
        {
            get { return _tenchuho; }
            set { _tenchuho = value; }
        }
        public string Masothue
        {
            get { return _masothue; }
            set { _masothue = value; }
        }
        public string Hinhthucthuthue
        {
            get { return _hinhthucthuthue; }
            set { _hinhthucthuthue = value; }
        }
        public string Coquanthuthue
        {
            get { return _coquanthuthue; }
            set { _coquanthuthue = value; }
        }
        public int Chuky
        {
            get { return _chuky; }
            set { _chuky = value; }
        }
        public string Duan
        {
            get { return _duan; }
            set { _duan = value; }
        }
        public DateTime Ngaybatdau
        {
            get { return _ngaybatdau; }
            set { _ngaybatdau = value; }
        }
        public DateTime Ngayketthuc
        {
            get { return _ngayketthuc; }
            set { _ngayketthuc = value; }
        }

        public double Thue
        {
            get { return _thue; }
            set { _thue = value; }
        }

        public double Tienthu
        {
            get { return _tienthu; }
            set { _tienthu = value; }
        }

        public double Phikekhaithue
        {
            get { return _phikekhaithue; }
            set { _phikekhaithue = value; }
        }

        public double Phiquanly
        {
            get { return _phiquanly; }
            set { _phiquanly = value; }
        }

        public double Tienrefundkhach
        {
            get { return _tienrefundkhach; }
            set { _tienrefundkhach = value; }
        }

        public double Phidonvesinh
        {
            get { return _phidonvesinh; }
            set { _phidonvesinh = value; }
        }

        public int SoNgayNhacNho
        {
            get { return _songaynhacnho; }
            set { _songaynhacnho = value; }
        }

        public double Tienthuemotthang
        {
            get { return _tienthuemotthang; }
            set { _tienthuemotthang = value; }
        }

        public string Daily
        {
            get { return _daily; }
            set { _daily = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

    }
}