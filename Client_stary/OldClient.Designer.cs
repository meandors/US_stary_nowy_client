namespace Client_stary
{
    partial class Client_stary
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
            this.button1 = new System.Windows.Forms.Button();
            this.bGetAll = new System.Windows.Forms.Button();
            this.bGet = new System.Windows.Forms.Button();
            this.nGetById = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddSName = new System.Windows.Forms.TextBox();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModySName = new System.Windows.Forms.TextBox();
            this.tbModyName = new System.Windows.Forms.TextBox();
            this.bModify = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbClients = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nGetById)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bGetAll
            // 
            this.bGetAll.Location = new System.Drawing.Point(6, 19);
            this.bGetAll.Name = "bGetAll";
            this.bGetAll.Size = new System.Drawing.Size(75, 23);
            this.bGetAll.TabIndex = 2;
            this.bGetAll.Text = "Wszystkich";
            this.bGetAll.UseVisualStyleBackColor = true;
            this.bGetAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // bGet
            // 
            this.bGet.Location = new System.Drawing.Point(111, 19);
            this.bGet.Name = "bGet";
            this.bGet.Size = new System.Drawing.Size(75, 23);
            this.bGet.TabIndex = 3;
            this.bGet.Text = "Po id";
            this.bGet.UseVisualStyleBackColor = true;
            // 
            // nGetById
            // 
            this.nGetById.Location = new System.Drawing.Point(192, 22);
            this.nGetById.Name = "nGetById";
            this.nGetById.Size = new System.Drawing.Size(73, 20);
            this.nGetById.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAddSName);
            this.groupBox1.Controls.Add(this.tbAddName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj Klienta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Imie";
            // 
            // tbAddSName
            // 
            this.tbAddSName.Location = new System.Drawing.Point(134, 109);
            this.tbAddSName.Name = "tbAddSName";
            this.tbAddSName.Size = new System.Drawing.Size(100, 20);
            this.tbAddSName.TabIndex = 3;
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(134, 66);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(100, 20);
            this.tbAddName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbModySName);
            this.groupBox2.Controls.Add(this.tbModyName);
            this.groupBox2.Controls.Add(this.bModify);
            this.groupBox2.Location = new System.Drawing.Point(311, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modyfikuj dane klienta";
            // 
            // nId
            // 
            this.nId.Location = new System.Drawing.Point(134, 23);
            this.nId.Name = "nId";
            this.nId.Size = new System.Drawing.Size(100, 20);
            this.nId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imie";
            // 
            // tbModySName
            // 
            this.tbModySName.Location = new System.Drawing.Point(134, 109);
            this.tbModySName.Name = "tbModySName";
            this.tbModySName.Size = new System.Drawing.Size(100, 20);
            this.tbModySName.TabIndex = 3;
            // 
            // tbModyName
            // 
            this.tbModyName.Location = new System.Drawing.Point(134, 66);
            this.tbModyName.Name = "tbModyName";
            this.tbModyName.Size = new System.Drawing.Size(100, 20);
            this.tbModyName.TabIndex = 2;
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(6, 19);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(75, 23);
            this.bModify.TabIndex = 0;
            this.bModify.Text = "Modyfikuj";
            this.bModify.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbClients);
            this.groupBox3.Controls.Add(this.bGetAll);
            this.groupBox3.Controls.Add(this.bGet);
            this.groupBox3.Controls.Add(this.nGetById);
            this.groupBox3.Location = new System.Drawing.Point(34, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 306);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pobierz dane klienta";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(21, 48);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(229, 238);
            this.lbClients.TabIndex = 5;
            // 
            // Client_stary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client_stary";
            this.Text = "Client v1.00";
            ((System.ComponentModel.ISupportInitialize)(this.nGetById)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nId)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bGetAll;
        private System.Windows.Forms.Button bGet;
        private System.Windows.Forms.NumericUpDown nGetById;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddSName;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbModySName;
        private System.Windows.Forms.TextBox tbModyName;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbClients;
    }
}

