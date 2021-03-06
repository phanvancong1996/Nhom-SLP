﻿using qewewqewqe.DAO;
using qewewqewqe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qewewqewqe
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<table> tableList = tableDAO.Instance.LoadTableList();

            foreach (table item in tableList)
            {
                Button btn = new Button() { Width = tableDAO.TableWidth, Height = tableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                fl1.Controls.Add(btn);
            }
        }
    }
}
