
namespace Ch6_Ex6_ChatAWhile
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCallLength = new System.Windows.Forms.TextBox();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblAreaCodeLength = new System.Windows.Forms.Label();
            this.gbMainInput = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOutput.SuspendLayout();
            this.gbMainInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat-A-While International";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Area Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Call Length (mins)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(203, 207);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 46);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCallLength
            // 
            this.txtCallLength.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallLength.Location = new System.Drawing.Point(303, 145);
            this.txtCallLength.Name = "txtCallLength";
            this.txtCallLength.Size = new System.Drawing.Size(95, 29);
            this.txtCallLength.TabIndex = 1;
            this.txtCallLength.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaCode.Location = new System.Drawing.Point(303, 95);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(95, 29);
            this.txtAreaCode.TabIndex = 0;
            this.txtAreaCode.TextChanged += new System.EventHandler(this.AllTextboxes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "_____________________________________________________";
            // 
            // pnlOutput
            // 
            this.pnlOutput.BackColor = System.Drawing.Color.Transparent;
            this.pnlOutput.Controls.Add(this.lblTotalCost);
            this.pnlOutput.Controls.Add(this.lblAreaCodeLength);
            this.pnlOutput.Location = new System.Drawing.Point(73, 482);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(539, 186);
            this.pnlOutput.TabIndex = 4;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(207, 84);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(142, 34);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "**Output3";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAreaCodeLength
            // 
            this.lblAreaCodeLength.AutoSize = true;
            this.lblAreaCodeLength.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCodeLength.Location = new System.Drawing.Point(58, 17);
            this.lblAreaCodeLength.Name = "lblAreaCodeLength";
            this.lblAreaCodeLength.Size = new System.Drawing.Size(95, 24);
            this.lblAreaCodeLength.TabIndex = 0;
            this.lblAreaCodeLength.Text = "**Output1";
            this.lblAreaCodeLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbMainInput
            // 
            this.gbMainInput.BackColor = System.Drawing.Color.Transparent;
            this.gbMainInput.Controls.Add(this.btnSubmit);
            this.gbMainInput.Controls.Add(this.label3);
            this.gbMainInput.Controls.Add(this.label2);
            this.gbMainInput.Controls.Add(this.txtCallLength);
            this.gbMainInput.Controls.Add(this.txtAreaCode);
            this.gbMainInput.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMainInput.Location = new System.Drawing.Point(73, 172);
            this.gbMainInput.Name = "gbMainInput";
            this.gbMainInput.Size = new System.Drawing.Size(539, 304);
            this.gbMainInput.TabIndex = 5;
            this.gbMainInput.TabStop = false;
            this.gbMainInput.Text = "Call Billing System";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 734);
            this.Controls.Add(this.gbMainInput);
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat-A-While Application - Boluwaji Oyewumi";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.gbMainInput.ResumeLayout(false);
            this.gbMainInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCallLength;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Label lblAreaCodeLength;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.GroupBox gbMainInput;
    }
}

