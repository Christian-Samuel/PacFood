namespace PacFood
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.parede1 = new System.Windows.Forms.Label();
            this.parede3 = new System.Windows.Forms.Label();
            this.parede2 = new System.Windows.Forms.Label();
            this.parede4 = new System.Windows.Forms.Label();
            this.vidaLabel = new System.Windows.Forms.Label();
            this.pontoLabel = new System.Windows.Forms.Label();
            this.Jogador = new System.Windows.Forms.Label();
            this.comida = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.frcTxt = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Panel();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // parede1
            // 
            this.parede1.BackColor = System.Drawing.Color.Black;
            this.parede1.Location = new System.Drawing.Point(1, -1);
            this.parede1.Name = "parede1";
            this.parede1.Size = new System.Drawing.Size(1073, 23);
            this.parede1.TabIndex = 1;
            this.parede1.Text = "label1";
            // 
            // parede3
            // 
            this.parede3.BackColor = System.Drawing.Color.Black;
            this.parede3.Location = new System.Drawing.Point(1, 489);
            this.parede3.Name = "parede3";
            this.parede3.Size = new System.Drawing.Size(1073, 23);
            this.parede3.TabIndex = 2;
            this.parede3.Text = "label1";
            // 
            // parede2
            // 
            this.parede2.BackColor = System.Drawing.Color.Black;
            this.parede2.Location = new System.Drawing.Point(1037, 22);
            this.parede2.Name = "parede2";
            this.parede2.Size = new System.Drawing.Size(37, 467);
            this.parede2.TabIndex = 3;
            this.parede2.Text = "label2";
            // 
            // parede4
            // 
            this.parede4.BackColor = System.Drawing.Color.Black;
            this.parede4.Location = new System.Drawing.Point(1, 22);
            this.parede4.Name = "parede4";
            this.parede4.Size = new System.Drawing.Size(37, 467);
            this.parede4.TabIndex = 4;
            this.parede4.Text = "label3";
            // 
            // vidaLabel
            // 
            this.vidaLabel.AutoSize = true;
            this.vidaLabel.Location = new System.Drawing.Point(127, 0);
            this.vidaLabel.Name = "vidaLabel";
            this.vidaLabel.Size = new System.Drawing.Size(50, 20);
            this.vidaLabel.TabIndex = 7;
            this.vidaLabel.Text = "Vida:";
            // 
            // pontoLabel
            // 
            this.pontoLabel.AutoSize = true;
            this.pontoLabel.Location = new System.Drawing.Point(3, 0);
            this.pontoLabel.Name = "pontoLabel";
            this.pontoLabel.Size = new System.Drawing.Size(70, 20);
            this.pontoLabel.TabIndex = 6;
            this.pontoLabel.Text = "Pontos:";
            // 
            // Jogador
            // 
            this.Jogador.BackColor = System.Drawing.Color.Coral;
            this.Jogador.Location = new System.Drawing.Point(13, 261);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(25, 25);
            this.Jogador.TabIndex = 6;
            // 
            // comida
            // 
            this.comida.BackColor = System.Drawing.Color.Red;
            this.comida.Location = new System.Drawing.Point(523, 56);
            this.comida.Name = "comida";
            this.comida.Size = new System.Drawing.Size(40, 40);
            this.comida.TabIndex = 19;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bloco1.jpg");
            // 
            // frcTxt
            // 
            this.frcTxt.AutoSize = true;
            this.frcTxt.Location = new System.Drawing.Point(248, 0);
            this.frcTxt.Name = "frcTxt";
            this.frcTxt.Size = new System.Drawing.Size(50, 20);
            this.frcTxt.TabIndex = 8;
            this.frcTxt.Text = "Vida:";
            // 
            // status
            // 
            this.status.Controls.Add(this.frcTxt);
            this.status.Controls.Add(this.pontoLabel);
            this.status.Controls.Add(this.vidaLabel);
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(356, -1);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(350, 23);
            this.status.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 512);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comida);
            this.Controls.Add(this.Jogador);
            this.Controls.Add(this.parede4);
            this.Controls.Add(this.parede2);
            this.Controls.Add(this.parede3);
            this.Controls.Add(this.parede1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label parede1;
        private System.Windows.Forms.Label parede3;
        private System.Windows.Forms.Label parede2;
        private System.Windows.Forms.Label parede4;
        private System.Windows.Forms.Label vidaLabel;
        private System.Windows.Forms.Label pontoLabel;
        private System.Windows.Forms.Label Jogador;
        private System.Windows.Forms.Label comida;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label frcTxt;
        private System.Windows.Forms.Panel status;
    }
}

