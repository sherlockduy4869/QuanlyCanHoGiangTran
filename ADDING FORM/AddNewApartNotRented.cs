﻿using QuanlyCanHoGiangTran.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.ADDING_FORM
{
    public partial class AddNewApartNotRented : Form
    {
        public AddNewApartNotRented()
        {
            InitializeComponent();
            listAllComboBox();
        }
        void listAllComboBox()
        {

            List<string> listTinhTrang = new List<string>();
            string[] arrayListTinhTrang = { "Chưa nhận bàn giao nhà", "Đã nhận bàn giao nhà", "Đang available cho thuê" };
            foreach (string str in arrayListTinhTrang)
            {
                listTinhTrang.Add(str);
            }
            cbTinhTrang.DataSource = listTinhTrang;

            List<string> listDuAn = new List<string>();
            string[] arrayListDuAn = { "Vinhomes Golden River", "Vinhomes Central Park", "Estella Height", "Estella", "The Vista", "Celesta" };
            foreach (string str in arrayListDuAn)
            {
                listDuAn.Add(str);
            }
            cbDuAn.DataSource = listDuAn;

            List<string> listPhongNgu = new List<string>();
            string[] arrayListPhongNgu = { "1 PN", "2 PN", "2 PN + 1", "3 PN", "3 PN + 1", "4 PN", "4 PN + 1" };
            foreach (string str in arrayListPhongNgu)
            {
                listPhongNgu.Add(str);
            }
            cbSoPhongNgu.DataSource = listPhongNgu;

        }

        void clearInfo()
        {
            txbMaCanHo.Clear();
            txbTenChuHo.Clear();
            txbDaiLy.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string maCanHo = txbMaCanHo.Text;
            string duan = cbDuAn.Text;
            string tinhTrang = cbTinhTrang.Text;
            string tenChuHo = txbTenChuHo.Text;
            string daiLy = txbDaiLy.Text;
            string soPhongNgu = cbSoPhongNgu.Text;
            string dienTich = txbSQM.Text;

            int i = AdminDAL.Instance.addApartmentNotRented(maCanHo, tenChuHo, duan, tinhTrang, daiLy, soPhongNgu, dienTich);

            try
            {
                if (i != 0)
                {
                    clearInfo();
                    MessageBox.Show("Added");

                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
    }
}
