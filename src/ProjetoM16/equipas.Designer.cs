﻿
namespace ProjetoM16
{
    partial class equipas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pSIM1619I_MatteoCordero_2219132DataSet1 = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSet1();
            this.pSIM1619IMatteoCordero2219132DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadoresTableAdapter = new ProjetoM16.PSIM1619I_MatteoCordero_2219132DataSet1TableAdapters.JogadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619I_MatteoCordero_2219132DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619IMatteoCordero2219132DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.jogadoresBindingSource;
            this.comboBox1.DisplayMember = "jogadores";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "jogadores";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pSIM1619I_MatteoCordero_2219132DataSet1
            // 
            this.pSIM1619I_MatteoCordero_2219132DataSet1.DataSetName = "PSIM1619I_MatteoCordero_2219132DataSet1";
            this.pSIM1619I_MatteoCordero_2219132DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pSIM1619IMatteoCordero2219132DataSet1BindingSource
            // 
            this.pSIM1619IMatteoCordero2219132DataSet1BindingSource.DataSource = this.pSIM1619I_MatteoCordero_2219132DataSet1;
            this.pSIM1619IMatteoCordero2219132DataSet1BindingSource.Position = 0;
            // 
            // jogadoresBindingSource
            // 
            this.jogadoresBindingSource.DataMember = "Jogadores";
            this.jogadoresBindingSource.DataSource = this.pSIM1619IMatteoCordero2219132DataSet1BindingSource;
            // 
            // jogadoresTableAdapter
            // 
            this.jogadoresTableAdapter.ClearBeforeFill = true;
            // 
            // equipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(444, 306);
            this.Controls.Add(this.comboBox1);
            this.Name = "equipas";
            this.Text = "equipas";
            this.Load += new System.EventHandler(this.equipas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619I_MatteoCordero_2219132DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSIM1619IMatteoCordero2219132DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource pSIM1619IMatteoCordero2219132DataSet1BindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSet1 pSIM1619I_MatteoCordero_2219132DataSet1;
        private System.Windows.Forms.BindingSource jogadoresBindingSource;
        private PSIM1619I_MatteoCordero_2219132DataSet1TableAdapters.JogadoresTableAdapter jogadoresTableAdapter;
    }
}