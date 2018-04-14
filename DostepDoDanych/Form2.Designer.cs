namespace DostepDoDanych
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._DostepDoDanych_BloggingContextDataSet = new DostepDoDanych._DostepDoDanych_BloggingContextDataSet();
            this.dostepDoDanychBloggingContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aktorsTableAdapter = new DostepDoDanych._DostepDoDanych_BloggingContextDataSetTableAdapters.AktorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._DostepDoDanych_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostepDoDanychBloggingContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 142);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.aktorsBindingSource;
            this.listBox1.DisplayMember = "Nazwisko";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "Imie";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // _DostepDoDanych_BloggingContextDataSet
            // 
            this._DostepDoDanych_BloggingContextDataSet.DataSetName = "_DostepDoDanych_BloggingContextDataSet";
            this._DostepDoDanych_BloggingContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostepDoDanychBloggingContextDataSetBindingSource
            // 
            this.dostepDoDanychBloggingContextDataSetBindingSource.DataSource = this._DostepDoDanych_BloggingContextDataSet;
            this.dostepDoDanychBloggingContextDataSetBindingSource.Position = 0;
            // 
            // aktorsBindingSource
            // 
            this.aktorsBindingSource.DataMember = "Aktors";
            this.aktorsBindingSource.DataSource = this.dostepDoDanychBloggingContextDataSetBindingSource;
            // 
            // aktorsTableAdapter
            // 
            this.aktorsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 268);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DostepDoDanych_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostepDoDanychBloggingContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource dostepDoDanychBloggingContextDataSetBindingSource;
        private _DostepDoDanych_BloggingContextDataSet _DostepDoDanych_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource aktorsBindingSource;
        private _DostepDoDanych_BloggingContextDataSetTableAdapters.AktorsTableAdapter aktorsTableAdapter;
    }
}