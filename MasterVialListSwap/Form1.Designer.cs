namespace MasterVialListSwap
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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSelDest = new System.Windows.Forms.Button();
            this.BtnSelA = new System.Windows.Forms.Button();
            this.BtnSelB = new System.Windows.Forms.Button();
            this.TxtDest = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.BtnPushB = new System.Windows.Forms.Button();
            this.BtnPushA = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 5;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Controls.Add(this.BtnSelDest, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.BtnSelA, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.BtnSelB, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TxtDest, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.TxtA, 2, 2);
            this.TableLayoutPanel.Controls.Add(this.TxtB, 2, 3);
            this.TableLayoutPanel.Controls.Add(this.BtnPushB, 3, 3);
            this.TableLayoutPanel.Controls.Add(this.BtnPushA, 3, 2);
            this.TableLayoutPanel.Controls.Add(this.LblStatus, 3, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(849, 140);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // BtnSelDest
            // 
            this.BtnSelDest.BackColor = System.Drawing.Color.White;
            this.BtnSelDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelDest.Location = new System.Drawing.Point(23, 23);
            this.BtnSelDest.Name = "BtnSelDest";
            this.BtnSelDest.Size = new System.Drawing.Size(155, 26);
            this.BtnSelDest.TabIndex = 0;
            this.BtnSelDest.Tag = "D";
            this.BtnSelDest.Text = "Select Destination";
            this.BtnSelDest.UseVisualStyleBackColor = false;
            this.BtnSelDest.Click += new System.EventHandler(this.BtnSelFile);
            // 
            // BtnSelA
            // 
            this.BtnSelA.BackColor = System.Drawing.Color.White;
            this.BtnSelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelA.Location = new System.Drawing.Point(23, 55);
            this.BtnSelA.Name = "BtnSelA";
            this.BtnSelA.Size = new System.Drawing.Size(155, 26);
            this.BtnSelA.TabIndex = 1;
            this.BtnSelA.Tag = "A";
            this.BtnSelA.Text = "Select File A";
            this.BtnSelA.UseVisualStyleBackColor = false;
            this.BtnSelA.Click += new System.EventHandler(this.BtnSelFile);
            // 
            // BtnSelB
            // 
            this.BtnSelB.BackColor = System.Drawing.Color.White;
            this.BtnSelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelB.Location = new System.Drawing.Point(23, 87);
            this.BtnSelB.Name = "BtnSelB";
            this.BtnSelB.Size = new System.Drawing.Size(155, 26);
            this.BtnSelB.TabIndex = 2;
            this.BtnSelB.Tag = "B";
            this.BtnSelB.Text = "Select File B";
            this.BtnSelB.UseVisualStyleBackColor = false;
            this.BtnSelB.Click += new System.EventHandler(this.BtnSelFile);
            // 
            // TxtDest
            // 
            this.TxtDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDest.Location = new System.Drawing.Point(184, 23);
            this.TxtDest.Name = "TxtDest";
            this.TxtDest.Size = new System.Drawing.Size(479, 26);
            this.TxtDest.TabIndex = 3;
            // 
            // TxtA
            // 
            this.TxtA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtA.Location = new System.Drawing.Point(184, 55);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(479, 26);
            this.TxtA.TabIndex = 4;
            // 
            // TxtB
            // 
            this.TxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB.Location = new System.Drawing.Point(184, 87);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(479, 26);
            this.TxtB.TabIndex = 5;
            // 
            // BtnPushB
            // 
            this.BtnPushB.BackColor = System.Drawing.Color.White;
            this.BtnPushB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPushB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPushB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPushB.Location = new System.Drawing.Point(669, 87);
            this.BtnPushB.Name = "BtnPushB";
            this.BtnPushB.Size = new System.Drawing.Size(155, 26);
            this.BtnPushB.TabIndex = 7;
            this.BtnPushB.Text = "Push B";
            this.BtnPushB.UseVisualStyleBackColor = false;
            this.BtnPushB.Click += new System.EventHandler(this.BtnPushB_Click);
            // 
            // BtnPushA
            // 
            this.BtnPushA.BackColor = System.Drawing.Color.White;
            this.BtnPushA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPushA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPushA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPushA.Location = new System.Drawing.Point(669, 55);
            this.BtnPushA.Name = "BtnPushA";
            this.BtnPushA.Size = new System.Drawing.Size(155, 26);
            this.BtnPushA.TabIndex = 8;
            this.BtnPushA.Text = "Push A";
            this.BtnPushA.UseVisualStyleBackColor = false;
            this.BtnPushA.Click += new System.EventHandler(this.BtnPushA_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(669, 20);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(155, 32);
            this.LblStatus.TabIndex = 9;
            this.LblStatus.Text = "Push Complete";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblStatus.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 140);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Master Vial List Swap";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button BtnSelDest;
        private System.Windows.Forms.Button BtnSelA;
        private System.Windows.Forms.Button BtnSelB;
        private System.Windows.Forms.TextBox TxtDest;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Button BtnPushB;
        private System.Windows.Forms.Button BtnPushA;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Timer Timer;
    }
}

