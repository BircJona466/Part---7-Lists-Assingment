namespace Part___7_Lists_Assingment
{
    partial class ListAssingment
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.btnNewList = new System.Windows.Forms.Button();
            this.btnSortList = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.lblRemoveNumbers = new System.Windows.Forms.Label();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddHero = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemoveHeroes = new System.Windows.Forms.TextBox();
            this.btnRemoveHeroes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(95, 126);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(216, 164);
            this.lstNumbers.TabIndex = 0;
            // 
            // lstHeroes
            // 
            this.lstHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.ItemHeight = 20;
            this.lstHeroes.Location = new System.Drawing.Point(490, 126);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(216, 164);
            this.lstHeroes.TabIndex = 1;
            // 
            // btnNewList
            // 
            this.btnNewList.BackColor = System.Drawing.Color.Black;
            this.btnNewList.Location = new System.Drawing.Point(95, 84);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(102, 36);
            this.btnNewList.TabIndex = 2;
            this.btnNewList.Text = "New List";
            this.btnNewList.UseVisualStyleBackColor = false;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // btnSortList
            // 
            this.btnSortList.BackColor = System.Drawing.Color.Black;
            this.btnSortList.Location = new System.Drawing.Point(209, 84);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(102, 36);
            this.btnSortList.TabIndex = 3;
            this.btnSortList.Text = "Sort";
            this.btnSortList.UseVisualStyleBackColor = false;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(91, 379);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status :";
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.BackColor = System.Drawing.Color.Black;
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(209, 317);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(102, 36);
            this.btnRemoveAllNumbers.TabIndex = 5;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = false;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.BackColor = System.Drawing.Color.Black;
            this.btnRemoveNumber.Location = new System.Drawing.Point(95, 317);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(102, 36);
            this.btnRemoveNumber.TabIndex = 6;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // lblRemoveNumbers
            // 
            this.lblRemoveNumbers.AutoSize = true;
            this.lblRemoveNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveNumbers.Location = new System.Drawing.Point(91, 288);
            this.lblRemoveNumbers.Name = "lblRemoveNumbers";
            this.lblRemoveNumbers.Size = new System.Drawing.Size(237, 24);
            this.lblRemoveNumbers.TabIndex = 7;
            this.lblRemoveNumbers.Text = "Select a number to remove";
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.BackColor = System.Drawing.Color.Black;
            this.btnSortHeroes.Location = new System.Drawing.Point(604, 84);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(102, 36);
            this.btnSortHeroes.TabIndex = 8;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = false;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.BackColor = System.Drawing.Color.Black;
            this.btnNewHeroes.Location = new System.Drawing.Point(490, 84);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(102, 36);
            this.btnNewHeroes.TabIndex = 9;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = false;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(88, 42);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(166, 39);
            this.lblNumbers.TabIndex = 10;
            this.lblNumbers.Text = "Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Heroes";
            // 
            // lblAddHero
            // 
            this.lblAddHero.AutoSize = true;
            this.lblAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHero.Location = new System.Drawing.Point(486, 288);
            this.lblAddHero.Name = "lblAddHero";
            this.lblAddHero.Size = new System.Drawing.Size(227, 24);
            this.lblAddHero.TabIndex = 12;
            this.lblAddHero.Text = "Enter a Hero name to add";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(491, 324);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(169, 20);
            this.txtAddHero.TabIndex = 13;
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.Black;
            this.btnAddHero.Location = new System.Drawing.Point(675, 318);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(57, 30);
            this.btnAddHero.TabIndex = 14;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = false;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter a Hero name to Remove";
            // 
            // txtRemoveHeroes
            // 
            this.txtRemoveHeroes.Location = new System.Drawing.Point(491, 384);
            this.txtRemoveHeroes.Name = "txtRemoveHeroes";
            this.txtRemoveHeroes.Size = new System.Drawing.Size(167, 20);
            this.txtRemoveHeroes.TabIndex = 16;
            // 
            // btnRemoveHeroes
            // 
            this.btnRemoveHeroes.BackColor = System.Drawing.Color.Black;
            this.btnRemoveHeroes.Location = new System.Drawing.Point(664, 379);
            this.btnRemoveHeroes.Name = "btnRemoveHeroes";
            this.btnRemoveHeroes.Size = new System.Drawing.Size(68, 30);
            this.btnRemoveHeroes.TabIndex = 17;
            this.btnRemoveHeroes.Text = "Remove";
            this.btnRemoveHeroes.UseVisualStyleBackColor = false;
            this.btnRemoveHeroes.Click += new System.EventHandler(this.btnRemoveHeroes_Click);
            // 
            // ListAssingment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveHeroes);
            this.Controls.Add(this.txtRemoveHeroes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblAddHero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.lblRemoveNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ListAssingment";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.ListAssingment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Label lblRemoveNumbers;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddHero;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemoveHeroes;
        private System.Windows.Forms.Button btnRemoveHeroes;
    }
}

