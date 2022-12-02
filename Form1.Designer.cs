namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filiére = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomText = new System.Windows.Forms.TextBox();
            this.prenomText = new System.Windows.Forms.TextBox();
            this.filiéreText = new System.Windows.Forms.TextBox();
            this.annéeText = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // Filiére
            // 
            this.Filiére.AutoSize = true;
            this.Filiére.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filiére.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filiére.Location = new System.Drawing.Point(51, 310);
            this.Filiére.Name = "Filiére";
            this.Filiére.Size = new System.Drawing.Size(64, 25);
            this.Filiére.TabIndex = 2;
            this.Filiére.Text = "Filiére";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Année";
            // 
            // nomText
            // 
            this.nomText.BackColor = System.Drawing.Color.Gainsboro;
            this.nomText.Enabled = false;
            this.nomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomText.Location = new System.Drawing.Point(145, 210);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(429, 35);
            this.nomText.TabIndex = 4;
            this.nomText.TextChanged += new System.EventHandler(this.nomText_TextChanged);
            // 
            // prenomText
            // 
            this.prenomText.BackColor = System.Drawing.Color.Gainsboro;
            this.prenomText.Enabled = false;
            this.prenomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomText.Location = new System.Drawing.Point(145, 259);
            this.prenomText.Name = "prenomText";
            this.prenomText.Size = new System.Drawing.Size(429, 35);
            this.prenomText.TabIndex = 5;
            // 
            // filiéreText
            // 
            this.filiéreText.BackColor = System.Drawing.Color.Gainsboro;
            this.filiéreText.Enabled = false;
            this.filiéreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filiéreText.Location = new System.Drawing.Point(145, 306);
            this.filiéreText.Name = "filiéreText";
            this.filiéreText.Size = new System.Drawing.Size(429, 35);
            this.filiéreText.TabIndex = 6;
            // 
            // annéeText
            // 
            this.annéeText.BackColor = System.Drawing.Color.Gainsboro;
            this.annéeText.Enabled = false;
            this.annéeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annéeText.Location = new System.Drawing.Point(145, 351);
            this.annéeText.Name = "annéeText";
            this.annéeText.Size = new System.Drawing.Size(429, 35);
            this.annéeText.TabIndex = 7;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(138, 435);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(120, 50);
            this.insertBtn.TabIndex = 8;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(264, 435);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 50);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(602, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID";
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.Gainsboro;
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(639, 211);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(43, 35);
            this.idText.TabIndex = 11;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(390, 435);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 50);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 173);
            this.dataGridView1.TabIndex = 14;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.viewAllBtn.Enabled = false;
            this.viewAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.Location = new System.Drawing.Point(516, 435);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(120, 50);
            this.viewAllBtn.TabIndex = 17;
            this.viewAllBtn.Text = "Confirm";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(12, 435);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(120, 50);
            this.newBtn.TabIndex = 18;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(773, 504);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.annéeText);
            this.Controls.Add(this.filiéreText);
            this.Controls.Add(this.prenomText);
            this.Controls.Add(this.nomText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filiére);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Filiére;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.TextBox prenomText;
        private System.Windows.Forms.TextBox filiéreText;
        private System.Windows.Forms.TextBox annéeText;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button newBtn;
    }
}

