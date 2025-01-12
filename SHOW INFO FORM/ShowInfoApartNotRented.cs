﻿using QuanlyCanHoGiangTran.ADDING_FORM;
using QuanlyCanHoGiangTran.DAL;
using QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM;
using QuanlyCanHoGiangTran.REMOVING_FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.SHOW_INFO_FORM
{
    public partial class ShowInfoApartNotRented : Form
    {
        public ShowInfoApartNotRented()
        {
            InitializeComponent();
            listApartTax();
            designDatagridview();
        }

        void listApartTax()
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.ForeColor = System.Drawing.Color.Black;
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED WHERE MACANHO LIKE '" + txbSearch.Text + "%' ");
        }
        void designDatagridview()
        {
            //Change column's name for datagridview
            dtgvApartInfo.Columns["MACANHO"].HeaderText = "APARTMENT CODE";
            dtgvApartInfo.Columns["TENCHUHO"].HeaderText = "HOUSE OWNER ";
            dtgvApartInfo.Columns["DUAN"].HeaderText = "AREA";
            dtgvApartInfo.Columns["SOPHONGNGU"].HeaderText = "BEDROOM";
            dtgvApartInfo.Columns["DIENTICH"].HeaderText = "SQM";
            dtgvApartInfo.Columns["TINHTRANG"].HeaderText = "STATUS";
            dtgvApartInfo.Columns["DAILY"].HeaderText = "AGENT NAME";

            //Edit colums style for datagridview
            foreach (DataGridViewColumn col in dtgvApartInfo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //col.HeaderCell.Style.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewApartNotRented addNewApartNotRented = new AddNewApartNotRented();
            addNewApartNotRented.Show();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            AddNewApartNotRented addNewApartNotRented = new AddNewApartNotRented();
            addNewApartNotRented.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApartNotRented removeApartNotRented = new RemoveApartNotRented();
            removeApartNotRented.Show();
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            RemoveApartNotRented removeApartNotRented = new RemoveApartNotRented();
            removeApartNotRented.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            dtgvApartInfo.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM APARTMENT_NOT_RENTED");
        }

        private void btnInformationDetail_Click(object sender, EventArgs e)
        {
            InforDetailApartNotRented inforDetailApartNotRented = new InforDetailApartNotRented();
            inforDetailApartNotRented.Show();
        }

        private void pbInfoDetails_Click(object sender, EventArgs e)
        {
            InforDetailApartNotRented inforDetailApartNotRented = new InforDetailApartNotRented();
            inforDetailApartNotRented.Show();
        }
    }
}
