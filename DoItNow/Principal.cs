﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoItNow
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDiasPrioridade1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtDiasPrioridade1.Text == "")
            {
                txtDiasPrioridade1.Text = "";
            }
            else
            {
                int qDiasP1 = Convert.ToInt16(txtDiasPrioridade1.Text);

                switch (qDiasP1)
                {
                    case 1:
                        txtDiasPrioridade1.Text = "1";
                        break;
                    case 2:
                        txtDiasPrioridade1.Text = "1";
                        break;
                    case 3:
                        txtDiasPrioridade1.Text = "2";
                        break;
                    case 4:
                        txtDiasPrioridade1.Text = "2";
                        break;
                    case 5:
                        txtDiasPrioridade1.Text = "3";
                        break;
                    case 6:
                        txtDiasPrioridade1.Text = "4";
                        break;
                    case 7:
                        txtDiasPrioridade1.Text = "4";
                        break;
                    case 8:
                        txtDiasPrioridade1.Text = "5";
                        break;
                    case 9:
                        txtDiasPrioridade1.Text = "6";
                        break;
                    case 10:
                        txtDiasPrioridade1.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }

            if (txtDiasPrioridade2.Text == "")
            {
                txtDiasPrioridade2.Text = "";
            }
            else
            {
                int qDiasP2 = Convert.ToInt16(txtDiasPrioridade2.Text);

                switch (qDiasP2)
                {
                    case 1:
                        txtDiasPrioridade2.Text = "1";
                        break;
                    case 2:
                        txtDiasPrioridade2.Text = "1";
                        break;
                    case 3:
                        txtDiasPrioridade2.Text = "2";
                        break;
                    case 4:
                        txtDiasPrioridade2.Text = "2";
                        break;
                    case 5:
                        txtDiasPrioridade2.Text = "3";
                        break;
                    case 6:
                        txtDiasPrioridade2.Text = "4";
                        break;
                    case 7:
                        txtDiasPrioridade2.Text = "4";
                        break;
                    case 8:
                        txtDiasPrioridade2.Text = "5";
                        break;
                    case 9:
                        txtDiasPrioridade2.Text = "6";
                        break;
                    case 10:
                        txtDiasPrioridade2.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }


            if (txtDiasPrioridade3.Text == "")
            {
                txtDiasPrioridade3.Text = "";
            }
            else
            {
                int qDiasP3 = Convert.ToInt16(txtDiasPrioridade3.Text);
                if (qDiasP3 == 0)
                {
                    txtDiasPrioridade3.Text = "";
                }
                else
                    switch (qDiasP3)
                    {
                        case 0:
                            txtDiasPrioridade3.Text = "";
                            break;
                        case 1:
                            txtDiasPrioridade3.Text = "1";
                            break;
                        case 2:
                            txtDiasPrioridade3.Text = "1";
                            break;
                        case 3:
                            txtDiasPrioridade3.Text = "2";
                            break;
                        case 4:
                            txtDiasPrioridade3.Text = "2";
                            break;
                        case 5:
                            txtDiasPrioridade3.Text = "3";
                            break;
                        case 6:
                            txtDiasPrioridade3.Text = "4";
                            break;
                        case 7:
                            txtDiasPrioridade3.Text = "4";
                            break;
                        case 8:
                            txtDiasPrioridade3.Text = "5";
                            break;
                        case 9:
                            txtDiasPrioridade3.Text = "6";
                            break;
                        case 10:
                            txtDiasPrioridade3.Text = "6";
                            break;
                        default:
                            MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                            break;
                    }
            }


            if (txtDiasPrioridade4.Text == "")
            {
                txtDiasPrioridade4.Text = "";
            }
            else
            {
                int qDiasP4 = Convert.ToInt16(txtDiasPrioridade4.Text);
                if (qDiasP4 == 0)
                {
                    txtDiasPrioridade4.Text = "";
                }
                else
                    switch (qDiasP4)
                    {
                        case 1:
                            txtDiasPrioridade4.Text = "1";
                            break;
                        case 2:
                            txtDiasPrioridade4.Text = "1";
                            break;
                        case 3:
                            txtDiasPrioridade4.Text = "2";
                            break;
                        case 4:
                            txtDiasPrioridade4.Text = "2";
                            break;
                        case 5:
                            txtDiasPrioridade4.Text = "3";
                            break;
                        case 6:
                            txtDiasPrioridade4.Text = "4";
                            break;
                        case 7:
                            txtDiasPrioridade4.Text = "4";
                            break;
                        case 8:
                            txtDiasPrioridade4.Text = "5";
                            break;
                        case 9:
                            txtDiasPrioridade4.Text = "6";
                            break;
                        case 10:
                            txtDiasPrioridade4.Text = "6";
                            break;
                        default:
                            MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                            break;
                    }
            }


            if (txtDiasPrioridade5.Text == "")
            {
                txtDiasPrioridade5.Text = "";
            }
            else
            {
                int qDiasP5 = Convert.ToInt16(txtDiasPrioridade5.Text);
                if (qDiasP5 == 0)
                {
                    txtDiasPrioridade5.Text = "";
                }
                else
                    switch (qDiasP5)
                    {
                        case 1:
                            txtDiasPrioridade5.Text = "1";
                            break;
                        case 2:
                            txtDiasPrioridade5.Text = "1";
                            break;
                        case 3:
                            txtDiasPrioridade5.Text = "2";
                            break;
                        case 4:
                            txtDiasPrioridade5.Text = "2";
                            break;
                        case 5:
                            txtDiasPrioridade5.Text = "3";
                            break;
                        case 6:
                            txtDiasPrioridade5.Text = "4";
                            break;
                        case 7:
                            txtDiasPrioridade5.Text = "4";
                            break;
                        case 8:
                            txtDiasPrioridade5.Text = "5";
                            break;
                        case 9:
                            txtDiasPrioridade5.Text = "6";
                            break;
                        case 10:
                            txtDiasPrioridade5.Text = "6";
                            break;
                        default:
                            MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                            break;
                    }
            }


            if (txtDiasPrioridade6.Text == "")
            {
                txtDiasPrioridade6.Text = "";
            }
            else
            {
                int qDiasP6 = Convert.ToInt16(txtDiasPrioridade6.Text);
                if (qDiasP6 == 0)
                {
                    txtDiasPrioridade6.Text = "";
                }
                else
                    switch (qDiasP6)
                    {
                        case 1:
                            txtDiasPrioridade6.Text = "1";
                            break;
                        case 2:
                            txtDiasPrioridade6.Text = "1";
                            break;
                        case 3:
                            txtDiasPrioridade6.Text = "2";
                            break;
                        case 4:
                            txtDiasPrioridade6.Text = "2";
                            break;
                        case 5:
                            txtDiasPrioridade6.Text = "3";
                            break;
                        case 6:
                            txtDiasPrioridade6.Text = "4";
                            break;
                        case 7:
                            txtDiasPrioridade6.Text = "4";
                            break;
                        case 8:
                            txtDiasPrioridade6.Text = "5";
                            break;
                        case 9:
                            txtDiasPrioridade6.Text = "6";
                            break;
                        case 10:
                            txtDiasPrioridade6.Text = "6";
                            break;
                        default:
                            MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                            break;
                    }
            }

            if (txtDiasTarefa1.Text == "")
            {
                txtDiasTarefa1.Text = "";
            }
            else
            {
                int qDiasT1 = Convert.ToInt16(txtDiasTarefa1.Text);
                switch (qDiasT1)
                {
                    case 1:
                        txtDiasTarefa1.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa1.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa1.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa1.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa1.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa1.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa1.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa1.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa1.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa1.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }

            if (txtDiasTarefa2.Text == "")
            {
                txtDiasTarefa2.Text = "";
            }
            else
            {
                int qDiasT2 = Convert.ToInt16(txtDiasTarefa2.Text);
                switch (qDiasT2)
                {
                    case 1:
                        txtDiasTarefa2.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa2.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa2.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa2.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa2.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa2.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa2.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa2.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa2.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa2.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }

            if (txtDiasTarefa3.Text == "")
            {
                txtDiasTarefa3.Text = "";
            }
            else
            {
                int qDiasT3 = Convert.ToInt16(txtDiasTarefa3.Text);
                switch (qDiasT3)
                {

                    case 1:
                        txtDiasTarefa3.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa3.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa3.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa3.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa3.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa3.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa3.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa3.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa3.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa3.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }



            if (txtDiasTarefa4.Text == "")
            {
                txtDiasTarefa4.Text = "";
            }
            else
            {
                int qDiasT4 = Convert.ToInt16(txtDiasTarefa4.Text);
                switch (qDiasT4)
                {
                    case 1:
                        txtDiasTarefa4.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa4.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa4.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa4.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa4.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa4.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa4.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa4.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa4.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa4.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }


            if (txtDiasTarefa5.Text == "")
            {
                txtDiasTarefa5.Text = "";
            }
            else
            {
                int qDiasT5 = Convert.ToInt16(txtDiasTarefa5.Text);
                switch (qDiasT5)
                {
                    case 1:
                        txtDiasTarefa5.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa5.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa5.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa5.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa5.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa5.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa5.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa5.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa5.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa5.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }


            if (txtDiasTarefa6.Text == "")
            {
                txtDiasTarefa6.Text = "";
            }
            else
            {
                int qDiasT6 = Convert.ToInt16(txtDiasTarefa6.Text);
                switch (qDiasT6)
                {
                    case 1:
                        txtDiasTarefa6.Text = "1";
                        break;
                    case 2:
                        txtDiasTarefa6.Text = "1";
                        break;
                    case 3:
                        txtDiasTarefa6.Text = "2";
                        break;
                    case 4:
                        txtDiasTarefa6.Text = "2";
                        break;
                    case 5:
                        txtDiasTarefa6.Text = "3";
                        break;
                    case 6:
                        txtDiasTarefa6.Text = "4";
                        break;
                    case 7:
                        txtDiasTarefa6.Text = "4";
                        break;
                    case 8:
                        txtDiasTarefa6.Text = "5";
                        break;
                    case 9:
                        txtDiasTarefa6.Text = "6";
                        break;
                    case 10:
                        txtDiasTarefa6.Text = "6";
                        break;
                    default:
                        MessageBox.Show("Valor acima do limite máximo permitido (10 dias)");
                        break;
                }
            }
        }

            private void btnCaiPrio1_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade1.Text;
                String txt2 = txtTarefa1.Text;

                txtPrioridade1.Text = txt2;
                txtTarefa1.Text = txt1;
            }

            private void btnCaiPrio2_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade2.Text;
                String txt2 = txtTarefa2.Text;

                txtPrioridade2.Text = txt2;
                txtTarefa2.Text = txt1;
            }

            private void btnCaiPrio3_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade3.Text;
                String txt2 = txtTarefa3.Text;

                txtPrioridade3.Text = txt2;
                txtTarefa3.Text = txt1;
            }

            private void btnCaiPrio4_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade4.Text;
                String txt2 = txtTarefa4.Text;

                txtPrioridade4.Text = txt2;
                txtTarefa4.Text = txt1;
            }

            private void btnCaiPrio5_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade5.Text;
                String txt2 = txtTarefa5.Text;

                txtPrioridade5.Text = txt2;
                txtTarefa5.Text = txt1;
            }

            private void btnCaiPrio6_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade6.Text;
                String txt2 = txtTarefa6.Text;

                txtPrioridade6.Text = txt2;
                txtTarefa6.Text = txt1;
            }

            private void txtDiasPrioridade3_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnPrioSobe1_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade1.Text;
                String txt2 = txtTarefa1.Text;

                txtPrioridade1.Text = txt2;
                txtTarefa1.Text = txt1;
            }

            private void btnPrioSobe2_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade2.Text;
                String txt2 = txtTarefa2.Text;

                txtPrioridade2.Text = txt2;
                txtTarefa2.Text = txt1;
            }

            private void btnPrioSobe3_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade3.Text;
                String txt2 = txtTarefa3.Text;

                txtPrioridade3.Text = txt2;
                txtTarefa3.Text = txt1;
            }

            private void btnPrioSobe4_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade4.Text;
                String txt2 = txtTarefa4.Text;

                txtPrioridade4.Text = txt2;
                txtTarefa4.Text = txt1;
            }

            private void btnPrioSobe5_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade5.Text;
                String txt2 = txtTarefa5.Text;

                txtPrioridade5.Text = txt2;
                txtTarefa5.Text = txt1;
            }

            private void btnPrioSobe6_Click(object sender, EventArgs e)
            {
                String txt1 = txtPrioridade6.Text;
                String txt2 = txtTarefa6.Text;

                txtPrioridade6.Text = txt2;
                txtTarefa6.Text = txt1;
            }
        }
    }

