
namespace ProjetoM16
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.equipasAtlanticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSIM1619I_MatteoCordero_2219132DataSet = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.equipasCentralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.equipasAtlanticoTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasAtlanticoTableAdapter();
            this.equipasCentralTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasCentralTableAdapter();
            this.equipasSudesteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipasSudesteTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasSudesteTableAdapter();
            this.equipasNoroesteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipasNoroesteTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasNoroesteTableAdapter();
            this.equipasPacificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipasPacificoTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasPacificoTableAdapter();
            this.pSIM1619IMatteoCordero2219132DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipasSudoesteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipasSudoesteTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasSudoesteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipasAtlanticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619I_MatteoCordero_2219132DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasCentralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasSudesteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasNoroesteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasPacificoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619IMatteoCordero2219132DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasSudoesteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.equipasAtlanticoBindingSource;
            this.comboBox1.DisplayMember = "nomeEquipa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "nomeEquipa";
            // 
            // equipasAtlanticoBindingSource
            // 
            this.equipasAtlanticoBindingSource.DataMember = "equipasAtlantico";
            this.equipasAtlanticoBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            // 
            // pSIM1619I_MatteoCordero_2219132DataSet
            // 
            this.pSIM1619I_MatteoCordero_2219132DataSet.DataSetName = "PSIM1619I_MatteoCordero_2219132DataSet";
            this.pSIM1619I_MatteoCordero_2219132DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(72, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atlântico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Central";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sudeste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Noroeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pacífico";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.equipasCentralBindingSource;
            this.comboBox2.DisplayMember = "nomeEquipa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(159, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "nomeEquipa";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.equipasSudesteBindingSource;
            this.comboBox3.DisplayMember = "nomeEquipa";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(159, 169);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "nomeEquipa";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.equipasNoroesteBindingSource;
            this.comboBox4.DisplayMember = "nomeEquipa";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(159, 196);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.ValueMember = "nomeEquipa";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.equipasPacificoBindingSource;
            this.comboBox5.DisplayMember = "nomeEquipa";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(159, 221);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.ValueMember = "nomeEquipa";
            // 
            // equipasCentralBindingSource
            // 
            this.equipasCentralBindingSource.DataMember = "equipasCentral";
            this.equipasCentralBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.equipasSudoesteBindingSource;
            this.comboBox6.DisplayMember = "nomeEquipa";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(159, 250);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 11;
            this.comboBox6.ValueMember = "nomeEquipa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sudoeste";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "jogadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "jogadores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "procurar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "procurar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(293, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "procurar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(293, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "jogadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(386, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // equipasAtlanticoTableAdapter
            // 
            this.equipasAtlanticoTableAdapter.ClearBeforeFill = true;
            // 
            // equipasCentralTableAdapter
            // 
            this.equipasCentralTableAdapter.ClearBeforeFill = true;
            // 
            // equipasSudesteBindingSource
            // 
            this.equipasSudesteBindingSource.DataMember = "equipasSudeste";
            this.equipasSudesteBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            // 
            // equipasSudesteTableAdapter
            // 
            this.equipasSudesteTableAdapter.ClearBeforeFill = true;
            // 
            // equipasNoroesteBindingSource
            // 
            this.equipasNoroesteBindingSource.DataMember = "equipasNoroeste";
            this.equipasNoroesteBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            // 
            // equipasNoroesteTableAdapter
            // 
            this.equipasNoroesteTableAdapter.ClearBeforeFill = true;
            // 
            // equipasPacificoBindingSource
            // 
            this.equipasPacificoBindingSource.DataMember = "equipasPacifico";
            this.equipasPacificoBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            // 
            // equipasPacificoTableAdapter
            // 
            this.equipasPacificoTableAdapter.ClearBeforeFill = true;
            // 
            // pSIM1619IMatteoCordero2219132DataSetBindingSource
            // 
            this.pSIM1619IMatteoCordero2219132DataSetBindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet;
            this.pSIM1619IMatteoCordero2219132DataSetBindingSource.Position = 0;
            // 
            // equipasSudoesteBindingSource
            // 
            this.equipasSudoesteBindingSource.DataMember = "equipasSudoeste";
            this.equipasSudoesteBindingSource.DataSource = this.pSIM1619IMatteoCordero2219132DataSetBindingSource;
            // 
            // equipasSudoesteTableAdapter
            // 
            this.equipasSudoesteTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 348);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipasAtlanticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619I_MatteoCordero_2219132DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasCentralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasSudesteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasNoroesteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasPacificoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619IMatteoCordero2219132DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipasSudoesteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PSIM1619I_MatteoCordero_2219132DataSet pSIM1619I_MatteoCordero_2219132DataSet;
        private System.Windows.Forms.BindingSource equipasAtlanticoBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasAtlanticoTableAdapter equipasAtlanticoTableAdapter;
        private System.Windows.Forms.BindingSource equipasCentralBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasCentralTableAdapter equipasCentralTableAdapter;
        private System.Windows.Forms.BindingSource equipasSudesteBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasSudesteTableAdapter equipasSudesteTableAdapter;
        private System.Windows.Forms.BindingSource equipasNoroesteBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasNoroesteTableAdapter equipasNoroesteTableAdapter;
        private System.Windows.Forms.BindingSource equipasPacificoBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasPacificoTableAdapter equipasPacificoTableAdapter;
        private System.Windows.Forms.BindingSource pSIM1619IMatteoCordero2219132DataSetBindingSource;
        private System.Windows.Forms.BindingSource equipasSudoesteBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSetTableAdapters.equipasSudoesteTableAdapter equipasSudoesteTableAdapter;
    }
}