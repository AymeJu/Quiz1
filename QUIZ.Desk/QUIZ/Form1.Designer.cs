namespace QUIZ
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BemVindo = new System.Windows.Forms.Label();
            this.comecar = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Label();
            this.medio = new System.Windows.Forms.RadioButton();
            this.facil = new System.Windows.Forms.RadioButton();
            this.dificil = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // BemVindo
            // 
            this.BemVindo.AutoSize = true;
            this.BemVindo.BackColor = System.Drawing.Color.Transparent;
            this.BemVindo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BemVindo.Location = new System.Drawing.Point(95, 119);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(398, 64);
            this.BemVindo.TabIndex = 0;
            this.BemVindo.Text = "Bem-Vindo! \r\nTeste seus conhecimentos.";
            this.BemVindo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comecar
            // 
            this.comecar.BackColor = System.Drawing.Color.Transparent;
            this.comecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.comecar.Enabled = false;
            this.comecar.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comecar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comecar.Location = new System.Drawing.Point(307, 347);
            this.comecar.Name = "comecar";
            this.comecar.Size = new System.Drawing.Size(174, 37);
            this.comecar.TabIndex = 5;
            this.comecar.Text = "Começar";
            this.comecar.UseVisualStyleBackColor = false;
            this.comecar.Click += new System.EventHandler(this.comecar_Click);
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.Transparent;
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture1.Image = global::QUIZ.Properties.Resources.teste;
            this.picture1.Location = new System.Drawing.Point(158, 12);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(240, 104);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture1.TabIndex = 7;
            this.picture1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(231, 224);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 8;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.White;
            this.Nome.Location = new System.Drawing.Point(66, 223);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(159, 19);
            this.Nome.TabIndex = 9;
            this.Nome.Text = "Nome do Jogador :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escolha um nível :\r\n";
            // 
            // click
            // 
            this.click.AutoSize = true;
            this.click.BackColor = System.Drawing.Color.Transparent;
            this.click.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.click.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.click.Location = new System.Drawing.Point(70, 347);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(194, 34);
            this.click.TabIndex = 11;
            this.click.Text = "Vamos jogar";
            // 
            // medio
            // 
            this.medio.AutoSize = true;
            this.medio.BackColor = System.Drawing.Color.Transparent;
            this.medio.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medio.ForeColor = System.Drawing.Color.White;
            this.medio.Location = new System.Drawing.Point(319, 278);
            this.medio.Name = "medio";
            this.medio.Size = new System.Drawing.Size(65, 20);
            this.medio.TabIndex = 12;
            this.medio.Text = "Médio";
            this.medio.UseVisualStyleBackColor = false;
            // 
            // facil
            // 
            this.facil.AutoSize = true;
            this.facil.BackColor = System.Drawing.Color.Transparent;
            this.facil.Checked = true;
            this.facil.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facil.ForeColor = System.Drawing.Color.White;
            this.facil.Location = new System.Drawing.Point(231, 278);
            this.facil.Name = "facil";
            this.facil.Size = new System.Drawing.Size(61, 20);
            this.facil.TabIndex = 13;
            this.facil.TabStop = true;
            this.facil.Text = "Fácil";
            this.facil.UseVisualStyleBackColor = false;
            // 
            // dificil
            // 
            this.dificil.AutoSize = true;
            this.dificil.BackColor = System.Drawing.Color.Transparent;
            this.dificil.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificil.ForeColor = System.Drawing.Color.White;
            this.dificil.Location = new System.Drawing.Point(410, 278);
            this.dificil.Name = "dificil";
            this.dificil.Size = new System.Drawing.Size(71, 20);
            this.dificil.TabIndex = 14;
            this.dificil.Text = "Difícil";
            this.dificil.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.BackgroundImage = global::QUIZ.Properties.Resources._7bf59cf96ad2f028555e06259cb70d0d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.dificil);
            this.Controls.Add(this.facil);
            this.Controls.Add(this.medio);
            this.Controls.Add(this.click);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.comecar);
            this.Controls.Add(this.BemVindo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 441);
            this.MinimumSize = new System.Drawing.Size(576, 441);
            this.Name = "Form1";
            this.Text = "Emily Chata";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindo;
        private System.Windows.Forms.Button comecar;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label click;
        private System.Windows.Forms.RadioButton medio;
        private System.Windows.Forms.RadioButton facil;
        private System.Windows.Forms.RadioButton dificil;
    }
}

