namespace DemoTDCPadroes
{
    partial class ReconhecimentoForm
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
            this.btnNovoProjeto = new System.Windows.Forms.Button();
            this.labelProjeto = new System.Windows.Forms.Label();
            this.labelDominios = new System.Windows.Forms.Label();
            this.btnTagCerveja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelImagem = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnTagChima = new System.Windows.Forms.Button();
            this.btnTreinar = new System.Windows.Forms.Button();
            this.btnReconhecerCerveja = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoProjeto
            // 
            this.btnNovoProjeto.Location = new System.Drawing.Point(33, 34);
            this.btnNovoProjeto.Name = "btnNovoProjeto";
            this.btnNovoProjeto.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProjeto.TabIndex = 0;
            this.btnNovoProjeto.Text = "Criar Projeto";
            this.btnNovoProjeto.UseVisualStyleBackColor = true;
            this.btnNovoProjeto.Click += new System.EventHandler(this.btnNovoProjeto_Click);
            // 
            // labelProjeto
            // 
            this.labelProjeto.AutoSize = true;
            this.labelProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjeto.Location = new System.Drawing.Point(26, 134);
            this.labelProjeto.Name = "labelProjeto";
            this.labelProjeto.Size = new System.Drawing.Size(377, 37);
            this.labelProjeto.TabIndex = 1;
            this.labelProjeto.Text = "Nenhum projeto Criado...";
            // 
            // labelDominios
            // 
            this.labelDominios.AutoSize = true;
            this.labelDominios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDominios.Location = new System.Drawing.Point(35, 253);
            this.labelDominios.Name = "labelDominios";
            this.labelDominios.Size = new System.Drawing.Size(0, 37);
            this.labelDominios.TabIndex = 2;
            // 
            // btnTagCerveja
            // 
            this.btnTagCerveja.Location = new System.Drawing.Point(114, 34);
            this.btnTagCerveja.Name = "btnTagCerveja";
            this.btnTagCerveja.Size = new System.Drawing.Size(151, 23);
            this.btnTagCerveja.TabIndex = 3;
            this.btnTagCerveja.Text = "Criar Tag Cerveja";
            this.btnTagCerveja.UseVisualStyleBackColor = true;
            this.btnTagCerveja.Click += new System.EventHandler(this.btnTagCerveja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(604, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelImagem
            // 
            this.labelImagem.AutoSize = true;
            this.labelImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagem.Location = new System.Drawing.Point(597, 76);
            this.labelImagem.Name = "labelImagem";
            this.labelImagem.Size = new System.Drawing.Size(0, 37);
            this.labelImagem.TabIndex = 5;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(597, 21);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(0, 37);
            this.labelTag.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(35, 371);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 37);
            this.labelStatus.TabIndex = 7;
            // 
            // btnTagChima
            // 
            this.btnTagChima.Location = new System.Drawing.Point(271, 34);
            this.btnTagChima.Name = "btnTagChima";
            this.btnTagChima.Size = new System.Drawing.Size(151, 23);
            this.btnTagChima.TabIndex = 8;
            this.btnTagChima.Text = "Criar Tag Chimarrão";
            this.btnTagChima.UseVisualStyleBackColor = true;
            this.btnTagChima.Click += new System.EventHandler(this.btnTagChima_Click);
            // 
            // btnTreinar
            // 
            this.btnTreinar.Location = new System.Drawing.Point(428, 34);
            this.btnTreinar.Name = "btnTreinar";
            this.btnTreinar.Size = new System.Drawing.Size(75, 23);
            this.btnTreinar.TabIndex = 9;
            this.btnTreinar.Text = "Treinar";
            this.btnTreinar.UseVisualStyleBackColor = true;
            this.btnTreinar.Click += new System.EventHandler(this.btnTreinar_Click);
            // 
            // btnReconhecerCerveja
            // 
            this.btnReconhecerCerveja.Location = new System.Drawing.Point(33, 89);
            this.btnReconhecerCerveja.Name = "btnReconhecerCerveja";
            this.btnReconhecerCerveja.Size = new System.Drawing.Size(175, 23);
            this.btnReconhecerCerveja.TabIndex = 10;
            this.btnReconhecerCerveja.Text = "Reconhecer Imagem";
            this.btnReconhecerCerveja.UseVisualStyleBackColor = true;
            this.btnReconhecerCerveja.Click += new System.EventHandler(this.btnReconhecerCerveja_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(597, 487);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 37);
            this.labelResultado.TabIndex = 12;
            // 
            // ReconhecimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnReconhecerCerveja);
            this.Controls.Add(this.btnTreinar);
            this.Controls.Add(this.btnTagChima);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelImagem);
            this.Controls.Add(this.btnTagCerveja);
            this.Controls.Add(this.labelDominios);
            this.Controls.Add(this.labelProjeto);
            this.Controls.Add(this.btnNovoProjeto);
            this.Name = "ReconhecimentoForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoProjeto;
        private System.Windows.Forms.Label labelProjeto;
        private System.Windows.Forms.Label labelDominios;
        private System.Windows.Forms.Button btnTagCerveja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelImagem;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnTagChima;
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.Button btnReconhecerCerveja;
        private System.Windows.Forms.Label labelResultado;
    }
}

