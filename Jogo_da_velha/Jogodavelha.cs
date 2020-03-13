using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class janela : Form
    {
        string Njogador1, Njogador2, jogada;
        int cont = 0, Pjogador1 = 0, Pjogador2 = 0, empates = 0;

        public janela()
        {
            InitializeComponent();
        }

        private void janela_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(MessageBox.Show("Deseja Fechar o Jogo?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
               e.Cancel = true;
            }



        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bt_reiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
            habilita_botao();
            cont = 0;
        }
        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            Njogador1 = tb_jogador1.Text;
            tb_jogador1.Visible = false;
            lb_jogador.Text = Njogador1 + " Joga Com ";

            Njogador2 = tb_jogador2.Text;
            tb_jogador2.Visible = false;
            lb_jogador2.Text = Njogador2 + " Joga Com ";

            if (rb_X.Checked)
            {
                lb_jogador.Text = lb_jogador.Text + " X ";
                lb_jogador2.Text = lb_jogador2.Text + " O ";
            }

            else if (rb_O.Checked)
            {
                lb_jogador.Text = lb_jogador.Text + " O ";
                lb_jogador2.Text = lb_jogador2.Text + " X ";
            }
            gb_opcoes.Enabled = false;
            pnl_bottom.Enabled = true;
            
            lb_Pjogador1.Text = "0 - Vitórias";
            lb_Pjogador2.Text = "0 - Vitórias";
            lb_empates.Text = "0 - empates";

            bt_reiniciar.Enabled = true;
            bt_iniciar.Enabled = false;
            bt_iniciar.Visible = false;
            bt_novo.Visible = true;

            cont = 0;
            reiniciar();
            habilita_botao();

        }
        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_jogador1.Visible = true;
            tb_jogador2.Visible = true;
            rb_X.Checked = true;
            pnl_bottom.Enabled = false;
            gb_opcoes.Enabled = true;


            bt_reiniciar.Enabled = false;
            bt_iniciar.Enabled = true;
            bt_iniciar.Visible = true;
            bt_novo.Visible = false;

            lb_jogador.Text = "";
            lb_jogador2.Text = "";
            lb_Pjogador1.Text = "0 - Vitórias";
            lb_Pjogador2.Text = "0 - Vitórias";
            lb_empates.Text = "0 - empates";
            Pjogador1 = 0;
            Pjogador2 = 0;
            empates = 0;
            cont = 0;
            reiniciar();
        }

        public void vencedor()
        {
           if ((bt1.Text == "O") && (bt2.Text == "O") && (bt3.Text == "O") ||
               (bt1.Text == "O") && (bt5.Text == "O") && (bt9.Text == "O") ||
               (bt1.Text == "O") && (bt4.Text == "O") && (bt7.Text == "O") ||
               (bt4.Text == "O") && (bt5.Text == "O") && (bt6.Text == "O") ||
               (bt7.Text == "O") && (bt8.Text == "O") && (bt9.Text == "O") ||
               (bt2.Text == "O") && (bt5.Text == "O") && (bt8.Text == "O") ||
               (bt3.Text == "O") && (bt5.Text == "O") && (bt7.Text == "O") ||
               (bt3.Text == "O") && (bt6.Text == "O") && (bt9.Text == "O"))
           {
               MessageBox.Show("Ganhou, parabéns", "Vencedor");
               pnl_bottom.Enabled = false;
               Pjogador2 = Pjogador2 + 1;
               lb_Pjogador2.Text = Pjogador2.ToString() + " - Vitórias";
           }
           else
               if ((bt1.Text == "X") && (bt2.Text == "X") && (bt3.Text == "X") ||
                  (bt1.Text == "X") && (bt5.Text == "X") && (bt9.Text == "X") ||
                  (bt1.Text == "X") && (bt4.Text == "X") && (bt7.Text == "X") ||
                  (bt4.Text == "X") && (bt5.Text == "X") && (bt6.Text == "X") ||
                  (bt7.Text == "X") && (bt8.Text == "X") && (bt9.Text == "X") ||
                  (bt2.Text == "X") && (bt5.Text == "X") && (bt8.Text == "X") ||
                  (bt3.Text == "X") && (bt5.Text == "X") && (bt7.Text == "X") ||
                  (bt3.Text == "X") && (bt6.Text == "X") && (bt9.Text == "X"))
               {
                   MessageBox.Show("Ganhou, parabéns", "Vencedor");
                   pnl_bottom.Enabled = false;
                   Pjogador1 = Pjogador1 + 1;
                   lb_Pjogador1.Text = Pjogador1.ToString() + " - Vitórias";
               }
               else if(cont >= 9)
               { 
                   empates = empates + 1;
                   lb_empates.Text = empates.ToString() + " - empates";
                   MessageBox.Show("Empate", "Tente novamente");
                   cont = 0;
               }
       }

        public void reiniciar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }

        public void habilita_botao()
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
            pnl_bottom.Enabled = true;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                bt1.Text = jogada;
                bt1.Enabled = false;
                rb_O.Checked = true;
                
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                bt1.Text = jogada;
                bt1.Enabled = false;
                rb_X.Checked = true;
            }
          cont++;
          vencedor();
        }
       private void bt2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                bt2.Text = jogada;
                bt2.Enabled = false;
                rb_O.Checked = true;

            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                bt2.Text = jogada;
                bt2.Enabled = false;
                rb_X.Checked = true;
            }
            cont++;
            vencedor();
        }
       private void bt3_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt3.Text = jogada;
               bt3.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt3.Text = jogada;
               bt3.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt4_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt4.Text = jogada;
               bt4.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt4.Text = jogada;
               bt4.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt5_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt5.Text = jogada;
               bt5.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt5.Text = jogada;
               bt5.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt6_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt6.Text = jogada;
               bt6.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt6.Text = jogada;
               bt6.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt7_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt7.Text = jogada;
               bt7.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt7.Text = jogada;
               bt7.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt8_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt8.Text = jogada;
               bt8.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt8.Text = jogada;
               bt8.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

       private void bt9_Click(object sender, EventArgs e)
       {
           if (rb_X.Checked)
           {
               jogada = rb_X.Text;
               bt9.Text = jogada;
               bt9.Enabled = false;
               rb_O.Checked = true;

           }
           else if (rb_O.Checked)
           {
               jogada = rb_O.Text;
               bt9.Text = jogada;
               bt9.Enabled = false;
               rb_X.Checked = true;
           }
           cont++;
           vencedor();
       }

   





      




       
    }
       
    
}

