﻿using QuanlyCanHoGiangTran.SHOW_INFO_FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM
{
    public partial class InforDetailApartNotRented : Form
    {
        public InforDetailApartNotRented()
        {
            InitializeComponent();
        }

        private void btnDetailInformation_Click(object sender, EventArgs e)
        {
            ShowInfoApartNotRentedDetail showInfoApartNotRentedDetail = new ShowInfoApartNotRentedDetail();
            showInfoApartNotRentedDetail.Show();
            this.Close();
        }
    }
}
