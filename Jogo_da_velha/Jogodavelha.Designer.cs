namespace Jogo_da_velha
{
    partial class janela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(janela));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.bt_novo = new System.Windows.Forms.Button();
            this.gb_empate = new System.Windows.Forms.GroupBox();
            this.lb_empates = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_reiniciar = new System.Windows.Forms.Button();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.gb_placar = new System.Windows.Forms.GroupBox();
            this.lb_Pjogador2 = new System.Windows.Forms.Label();
            this.lb_Pjogador1 = new System.Windows.Forms.Label();
            this.gb_opcoes = new System.Windows.Forms.GroupBox();
            this.rb_O = new System.Windows.Forms.RadioButton();
            this.rb_X = new System.Windows.Forms.RadioButton();
            this.gb_jogadores = new System.Windows.Forms.GroupBox();
            this.tb_jogador2 = new System.Windows.Forms.TextBox();
            this.tb_jogador1 = new System.Windows.Forms.TextBox();
            this.lb_jogador2 = new System.Windows.Forms.Label();
            this.lb_jogador = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lb_cont = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.gb_empate.SuspendLayout();
            this.gb_placar.SuspendLayout();
            this.gb_opcoes.SuspendLayout();
            this.gb_jogadores.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnl_top.Controls.Add(this.bt_novo);
            this.pnl_top.Controls.Add(this.gb_empate);
            this.pnl_top.Controls.Add(this.bt_sair);
            this.pnl_top.Controls.Add(this.bt_reiniciar);
            this.pnl_top.Controls.Add(this.bt_iniciar);
            this.pnl_top.Controls.Add(this.gb_placar);
            this.pnl_top.Controls.Add(this.gb_opcoes);
            this.pnl_top.Controls.Add(this.gb_jogadores);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(733, 224);
            this.pnl_top.TabIndex = 1;
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_novo.Location = new System.Drawing.Point(382, 168);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(109, 46);
            this.bt_novo.TabIndex = 10;
            this.bt_novo.Text = "Novo Jogo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Visible = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // gb_empate
            // 
            this.gb_empate.Controls.Add(this.lb_empates);
            this.gb_empate.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_empate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_empate.Location = new System.Drawing.Point(536, 3);
            this.gb_empate.Name = "gb_empate";
            this.gb_empate.Size = new System.Drawing.Size(185, 121);
            this.gb_empate.TabIndex = 9;
            this.gb_empate.TabStop = false;
            this.gb_empate.Text = "Empate";
            // 
            // lb_empates
            // 
            this.lb_empates.AutoSize = true;
            this.lb_empates.Font = new System.Drawing.Font("Kozuka Gothic Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_empates.Location = new System.Drawing.Point(19, 51);
            this.lb_empates.Name = "lb_empates";
            this.lb_empates.Size = new System.Drawing.Size(0, 35);
            this.lb_empates.TabIndex = 0;
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_sair.Location = new System.Drawing.Point(612, 168);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(109, 46);
            this.bt_sair.TabIndex = 5;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_reiniciar
            // 
            this.bt_reiniciar.Enabled = false;
            this.bt_reiniciar.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_reiniciar.Location = new System.Drawing.Point(497, 168);
            this.bt_reiniciar.Name = "bt_reiniciar";
            this.bt_reiniciar.Size = new System.Drawing.Size(109, 46);
            this.bt_reiniciar.TabIndex = 4;
            this.bt_reiniciar.Text = "Reiniciar";
            this.bt_reiniciar.UseVisualStyleBackColor = true;
            this.bt_reiniciar.Click += new System.EventHandler(this.bt_reiniciar_Click);
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_iniciar.Location = new System.Drawing.Point(382, 168);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(109, 46);
            this.bt_iniciar.TabIndex = 3;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // gb_placar
            // 
            this.gb_placar.Controls.Add(this.lb_Pjogador2);
            this.gb_placar.Controls.Add(this.lb_Pjogador1);
            this.gb_placar.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_placar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_placar.Location = new System.Drawing.Point(330, 3);
            this.gb_placar.Name = "gb_placar";
            this.gb_placar.Size = new System.Drawing.Size(200, 121);
            this.gb_placar.TabIndex = 8;
            this.gb_placar.TabStop = false;
            this.gb_placar.Text = "Placar";
            // 
            // lb_Pjogador2
            // 
            this.lb_Pjogador2.AutoSize = true;
            this.lb_Pjogador2.Font = new System.Drawing.Font("Kozuka Gothic Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Pjogador2.Location = new System.Drawing.Point(15, 80);
            this.lb_Pjogador2.Name = "lb_Pjogador2";
            this.lb_Pjogador2.Size = new System.Drawing.Size(0, 35);
            this.lb_Pjogador2.TabIndex = 1;
            // 
            // lb_Pjogador1
            // 
            this.lb_Pjogador1.AutoSize = true;
            this.lb_Pjogador1.Font = new System.Drawing.Font("Kozuka Gothic Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Pjogador1.Location = new System.Drawing.Point(15, 31);
            this.lb_Pjogador1.Name = "lb_Pjogador1";
            this.lb_Pjogador1.Size = new System.Drawing.Size(0, 35);
            this.lb_Pjogador1.TabIndex = 0;
            // 
            // gb_opcoes
            // 
            this.gb_opcoes.Controls.Add(this.rb_O);
            this.gb_opcoes.Controls.Add(this.rb_X);
            this.gb_opcoes.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_opcoes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_opcoes.Location = new System.Drawing.Point(12, 139);
            this.gb_opcoes.Name = "gb_opcoes";
            this.gb_opcoes.Size = new System.Drawing.Size(162, 78);
            this.gb_opcoes.TabIndex = 1;
            this.gb_opcoes.TabStop = false;
            this.gb_opcoes.Text = "Opções";
            // 
            // rb_O
            // 
            this.rb_O.AutoSize = true;
            this.rb_O.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_O.Location = new System.Drawing.Point(79, 33);
            this.rb_O.Name = "rb_O";
            this.rb_O.Size = new System.Drawing.Size(50, 38);
            this.rb_O.TabIndex = 7;
            this.rb_O.Text = "O";
            this.rb_O.UseVisualStyleBackColor = true;
            // 
            // rb_X
            // 
            this.rb_X.AutoSize = true;
            this.rb_X.Checked = true;
            this.rb_X.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_X.Location = new System.Drawing.Point(15, 33);
            this.rb_X.Name = "rb_X";
            this.rb_X.Size = new System.Drawing.Size(48, 38);
            this.rb_X.TabIndex = 6;
            this.rb_X.TabStop = true;
            this.rb_X.Text = "X";
            this.rb_X.UseVisualStyleBackColor = true;
            // 
            // gb_jogadores
            // 
            this.gb_jogadores.Controls.Add(this.tb_jogador2);
            this.gb_jogadores.Controls.Add(this.tb_jogador1);
            this.gb_jogadores.Controls.Add(this.lb_jogador2);
            this.gb_jogadores.Controls.Add(this.lb_jogador);
            this.gb_jogadores.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_jogadores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_jogadores.Location = new System.Drawing.Point(12, 3);
            this.gb_jogadores.Name = "gb_jogadores";
            this.gb_jogadores.Size = new System.Drawing.Size(302, 121);
            this.gb_jogadores.TabIndex = 0;
            this.gb_jogadores.TabStop = false;
            this.gb_jogadores.Text = "Jogadores";
            // 
            // tb_jogador2
            // 
            this.tb_jogador2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jogador2.Location = new System.Drawing.Point(18, 73);
            this.tb_jogador2.Name = "tb_jogador2";
            this.tb_jogador2.Size = new System.Drawing.Size(182, 35);
            this.tb_jogador2.TabIndex = 2;
            // 
            // tb_jogador1
            // 
            this.tb_jogador1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jogador1.Location = new System.Drawing.Point(18, 34);
            this.tb_jogador1.Name = "tb_jogador1";
            this.tb_jogador1.Size = new System.Drawing.Size(182, 35);
            this.tb_jogador1.TabIndex = 1;
            // 
            // lb_jogador2
            // 
            this.lb_jogador2.AutoSize = true;
            this.lb_jogador2.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_jogador2.Location = new System.Drawing.Point(12, 80);
            this.lb_jogador2.Name = "lb_jogador2";
            this.lb_jogador2.Size = new System.Drawing.Size(0, 34);
            this.lb_jogador2.TabIndex = 3;
            // 
            // lb_jogador
            // 
            this.lb_jogador.AutoSize = true;
            this.lb_jogador.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_jogador.Location = new System.Drawing.Point(12, 42);
            this.lb_jogador.Name = "lb_jogador";
            this.lb_jogador.Size = new System.Drawing.Size(0, 34);
            this.lb_jogador.TabIndex = 2;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bottom.Controls.Add(this.lb_cont);
            this.pnl_bottom.Controls.Add(this.bt2);
            this.pnl_bottom.Controls.Add(this.bt9);
            this.pnl_bottom.Controls.Add(this.bt8);
            this.pnl_bottom.Controls.Add(this.bt7);
            this.pnl_bottom.Controls.Add(this.bt6);
            this.pnl_bottom.Controls.Add(this.bt5);
            this.pnl_bottom.Controls.Add(this.bt4);
            this.pnl_bottom.Controls.Add(this.bt3);
            this.pnl_bottom.Controls.Add(this.bt1);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Enabled = false;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 224);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(733, 268);
            this.pnl_bottom.TabIndex = 2;
            // 
            // lb_cont
            // 
            this.lb_cont.AutoSize = true;
            this.lb_cont.Font = new System.Drawing.Font("Kozuka Gothic Pro H", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_cont.Location = new System.Drawing.Point(272, 20);
            this.lb_cont.Name = "lb_cont";
            this.lb_cont.Size = new System.Drawing.Size(0, 35);
            this.lb_cont.TabIndex = 123;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt2.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(481, 10);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(91, 79);
            this.bt2.TabIndex = 11;
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt9.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt9.Location = new System.Drawing.Point(578, 180);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(91, 79);
            this.bt9.TabIndex = 18;
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt8.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt8.Location = new System.Drawing.Point(481, 180);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(91, 79);
            this.bt8.TabIndex = 17;
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt7.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt7.Location = new System.Drawing.Point(384, 180);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(91, 79);
            this.bt7.TabIndex = 16;
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt6.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt6.Location = new System.Drawing.Point(578, 95);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(91, 79);
            this.bt6.TabIndex = 15;
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt5.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Location = new System.Drawing.Point(481, 95);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(91, 79);
            this.bt5.TabIndex = 14;
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt4.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Location = new System.Drawing.Point(384, 95);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(91, 79);
            this.bt4.TabIndex = 13;
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt3.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Location = new System.Drawing.Point(578, 10);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(91, 79);
            this.bt3.TabIndex = 12;
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt1.Font = new System.Drawing.Font("Brush Script MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(384, 10);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(91, 79);
            this.bt1.TabIndex = 10;
            this.bt1.UseMnemonic = false;
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 492);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "janela";
            this.Text = "JOGO DA VELHA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.janela_FormClosing);
            this.pnl_top.ResumeLayout(false);
            this.gb_empate.ResumeLayout(false);
            this.gb_empate.PerformLayout();
            this.gb_placar.ResumeLayout(false);
            this.gb_placar.PerformLayout();
            this.gb_opcoes.ResumeLayout(false);
            this.gb_opcoes.PerformLayout();
            this.gb_jogadores.ResumeLayout(false);
            this.gb_jogadores.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.GroupBox gb_opcoes;
        private System.Windows.Forms.GroupBox gb_jogadores;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.GroupBox gb_placar;
        private System.Windows.Forms.Label lb_jogador2;
        private System.Windows.Forms.Label lb_jogador;
        private System.Windows.Forms.TextBox tb_jogador2;
        private System.Windows.Forms.TextBox tb_jogador1;
        private System.Windows.Forms.Label lb_Pjogador2;
        private System.Windows.Forms.Label lb_Pjogador1;
        private System.Windows.Forms.RadioButton rb_O;
        private System.Windows.Forms.RadioButton rb_X;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_reiniciar;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.GroupBox gb_empate;
        private System.Windows.Forms.Label lb_empates;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label lb_cont;
        private System.Windows.Forms.Button bt_novo;
    }
}

