namespace CollinsLab4
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
            this.radCash = new System.Windows.Forms.RadioButton();
            this.chkFlight = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.grLocation = new System.Windows.Forms.GroupBox();
            this.grTripInfo = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grBook = new System.Windows.Forms.GroupBox();
            this.grLocation.SuspendLayout();
            this.grTripInfo.SuspendLayout();
            this.grBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(26, 210);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 2;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // chkFlight
            // 
            this.chkFlight.AutoSize = true;
            this.chkFlight.Enabled = false;
            this.chkFlight.Location = new System.Drawing.Point(20, 101);
            this.chkFlight.Name = "chkFlight";
            this.chkFlight.Size = new System.Drawing.Size(122, 19);
            this.chkFlight.TabIndex = 3;
            this.chkFlight.Text = "Flight Included";
            this.chkFlight.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(20, 75);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(20, 49);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(20, 23);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(7, 22);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(230, 244);
            this.lblDisplay.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(82, 269);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 37);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(26, 185);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(101, 19);
            this.radCredit.TabIndex = 1;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(119, 268);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 37);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(75, 234);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "People:";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(76, 22);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 23);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grLocation
            // 
            this.grLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grLocation.Controls.Add(this.chkFlight);
            this.grLocation.Controls.Add(this.radMexico);
            this.grLocation.Controls.Add(this.radFlorida);
            this.grLocation.Controls.Add(this.radCuba);
            this.grLocation.Location = new System.Drawing.Point(6, 54);
            this.grLocation.Name = "grLocation";
            this.grLocation.Size = new System.Drawing.Size(209, 125);
            this.grLocation.TabIndex = 0;
            this.grLocation.TabStop = false;
            this.grLocation.Text = "Select Location";
            // 
            // grTripInfo
            // 
            this.grTripInfo.Controls.Add(this.lblDisplay);
            this.grTripInfo.Controls.Add(this.btnConfirm);
            this.grTripInfo.Location = new System.Drawing.Point(239, 12);
            this.grTripInfo.Name = "grTripInfo";
            this.grTripInfo.Size = new System.Drawing.Size(243, 312);
            this.grTripInfo.TabIndex = 3;
            this.grTripInfo.TabStop = false;
            this.grTripInfo.Text = "Trip Information";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(26, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grBook
            // 
            this.grBook.Controls.Add(this.radCash);
            this.grBook.Controls.Add(this.radCredit);
            this.grBook.Controls.Add(this.btnBook);
            this.grBook.Controls.Add(this.btnReset);
            this.grBook.Controls.Add(this.lblPrice);
            this.grBook.Controls.Add(this.label2);
            this.grBook.Controls.Add(this.label1);
            this.grBook.Controls.Add(this.txtPeople);
            this.grBook.Controls.Add(this.grLocation);
            this.grBook.Location = new System.Drawing.Point(12, 12);
            this.grBook.Name = "grBook";
            this.grBook.Size = new System.Drawing.Size(221, 312);
            this.grBook.TabIndex = 2;
            this.grBook.TabStop = false;
            this.grBook.Text = "Book";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grTripInfo);
            this.Controls.Add(this.grBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Chris Collins";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grLocation.ResumeLayout(false);
            this.grLocation.PerformLayout();
            this.grTripInfo.ResumeLayout(false);
            this.grBook.ResumeLayout(false);
            this.grBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.CheckBox chkFlight;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.GroupBox grLocation;
        private System.Windows.Forms.GroupBox grTripInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grBook;
    }
}

