namespace esoft
{
    partial class Administr
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
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16is32DataSet = new esoft._16is32DataSet();
            this.callTableAdapter = new esoft._16is32DataSetTableAdapters.CallTableAdapter();
            this.Vixod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16is32DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataMember = "Call";
            this.callBindingSource.DataSource = this._16is32DataSet;
            // 
            // _16is32DataSet
            // 
            this._16is32DataSet.DataSetName = "_16is32DataSet";
            this._16is32DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callTableAdapter
            // 
            this.callTableAdapter.ClearBeforeFill = true;
            // 
            // Vixod
            // 
            this.Vixod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vixod.Location = new System.Drawing.Point(426, 298);
            this.Vixod.Name = "Vixod";
            this.Vixod.Size = new System.Drawing.Size(34, 140);
            this.Vixod.TabIndex = 5;
            this.Vixod.Text = "Выход";
            this.Vixod.UseVisualStyleBackColor = true;
            this.Vixod.Click += new System.EventHandler(this.Vixod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Лодки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "Аксессуары для лодок";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(408, 67);
            this.button3.TabIndex = 8;
            this.button3.Text = "Клиенты";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(408, 67);
            this.button4.TabIndex = 9;
            this.button4.Text = "Заказы";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(408, 67);
            this.button5.TabIndex = 10;
            this.button5.Text = "Редактирование менеджеров";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(408, 67);
            this.button6.TabIndex = 11;
            this.button6.Text = "Счет";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Administr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vixod);
            this.Name = "Administr";
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.glav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16is32DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _16is32DataSet _16is32DataSet;
        private System.Windows.Forms.BindingSource callBindingSource;
        private _16is32DataSetTableAdapters.CallTableAdapter callTableAdapter;
        private System.Windows.Forms.Button Vixod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}