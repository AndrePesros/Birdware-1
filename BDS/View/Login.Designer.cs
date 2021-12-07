
namespace BDS
{
    partial class Login
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenhaLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uttonCadastrodeUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(115, 86);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 31);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textUsuarioLogin
            // 
            this.textUsuarioLogin.Location = new System.Drawing.Point(157, 25);
            this.textUsuarioLogin.Name = "textUsuarioLogin";
            this.textUsuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.textUsuarioLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // textSenhaLogin
            // 
            this.textSenhaLogin.Location = new System.Drawing.Point(157, 51);
            this.textSenhaLogin.Name = "textSenhaLogin";
            this.textSenhaLogin.Size = new System.Drawing.Size(100, 20);
            this.textSenhaLogin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BDS.Properties.Resources.logoBD;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // uttonCadastrodeUsuario
            // 
            this.uttonCadastrodeUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.uttonCadastrodeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uttonCadastrodeUsuario.Location = new System.Drawing.Point(2, 175);
            this.uttonCadastrodeUsuario.Name = "uttonCadastrodeUsuario";
            this.uttonCadastrodeUsuario.Size = new System.Drawing.Size(75, 23);
            this.uttonCadastrodeUsuario.TabIndex = 7;
            this.uttonCadastrodeUsuario.Text = "Cadastrar";
            this.uttonCadastrodeUsuario.UseVisualStyleBackColor = false;
            this.uttonCadastrodeUsuario.Click += new System.EventHandler(this.uttonCadastrodeUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Caso não seja registrado:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(269, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uttonCadastrodeUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSenhaLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsuarioLogin);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textUsuarioLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenhaLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uttonCadastrodeUsuario;
        private System.Windows.Forms.Label label3;
    }
}

