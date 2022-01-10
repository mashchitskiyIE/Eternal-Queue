namespace Eternal_Queue
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CashRegisterDGV = new System.Windows.Forms.DataGridView();
            this.St_P_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServeTimeNU = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClDnstTrB = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ClDnstTB = new System.Windows.Forms.TextBox();
            this.ArFreqNU = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MainQTB = new System.Windows.Forms.TextBox();
            this.Served_GenTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Served = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dismissal = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CashRegisterDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServeTimeNU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClDnstTrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArFreqNU)).BeginInit();
            this.SuspendLayout();
            // 
            // CashRegisterDGV
            // 
            this.CashRegisterDGV.AllowUserToAddRows = false;
            this.CashRegisterDGV.AllowUserToDeleteRows = false;
            this.CashRegisterDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CashRegisterDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CashRegisterDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashRegisterDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Queue,
            this.ServeTime,
            this.Served,
            this.Dismissal});
            this.CashRegisterDGV.Location = new System.Drawing.Point(12, 12);
            this.CashRegisterDGV.Name = "CashRegisterDGV";
            this.CashRegisterDGV.ReadOnly = true;
            this.CashRegisterDGV.RowHeadersVisible = false;
            this.CashRegisterDGV.Size = new System.Drawing.Size(427, 275);
            this.CashRegisterDGV.TabIndex = 0;
            this.CashRegisterDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CashRegisterDGV_CellContentClick);
            // 
            // St_P_Button
            // 
            this.St_P_Button.Location = new System.Drawing.Point(496, 252);
            this.St_P_Button.Name = "St_P_Button";
            this.St_P_Button.Size = new System.Drawing.Size(139, 23);
            this.St_P_Button.TabIndex = 1;
            this.St_P_Button.Text = "Start/Pause";
            this.St_P_Button.UseVisualStyleBackColor = true;
            this.St_P_Button.Click += new System.EventHandler(this.St_P_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serve Time";
            // 
            // ServeTimeNU
            // 
            this.ServeTimeNU.Location = new System.Drawing.Point(12, 309);
            this.ServeTimeNU.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ServeTimeNU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ServeTimeNU.Name = "ServeTimeNU";
            this.ServeTimeNU.Size = new System.Drawing.Size(58, 20);
            this.ServeTimeNU.TabIndex = 4;
            this.ServeTimeNU.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(89, 306);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Hire";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClDnstTrB
            // 
            this.ClDnstTrB.Location = new System.Drawing.Point(466, 131);
            this.ClDnstTrB.Maximum = 50;
            this.ClDnstTrB.Name = "ClDnstTrB";
            this.ClDnstTrB.Size = new System.Drawing.Size(169, 45);
            this.ClDnstTrB.TabIndex = 6;
            this.ClDnstTrB.Value = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clients Density Maximum";
            // 
            // ClDnstTB
            // 
            this.ClDnstTB.BackColor = System.Drawing.SystemColors.Window;
            this.ClDnstTB.Location = new System.Drawing.Point(641, 131);
            this.ClDnstTB.Name = "ClDnstTB";
            this.ClDnstTB.ReadOnly = true;
            this.ClDnstTB.Size = new System.Drawing.Size(45, 20);
            this.ClDnstTB.TabIndex = 8;
            // 
            // ArFreqNU
            // 
            this.ArFreqNU.Location = new System.Drawing.Point(535, 207);
            this.ArFreqNU.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ArFreqNU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArFreqNU.Name = "ArFreqNU";
            this.ArFreqNU.Size = new System.Drawing.Size(48, 20);
            this.ArFreqNU.TabIndex = 9;
            this.ArFreqNU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Arrival Frequency";
            // 
            // MainQTB
            // 
            this.MainQTB.Location = new System.Drawing.Point(553, 31);
            this.MainQTB.Name = "MainQTB";
            this.MainQTB.Size = new System.Drawing.Size(100, 20);
            this.MainQTB.TabIndex = 11;
            this.MainQTB.Text = "0";
            // 
            // Served_GenTB
            // 
            this.Served_GenTB.Location = new System.Drawing.Point(553, 64);
            this.Served_GenTB.Name = "Served_GenTB";
            this.Served_GenTB.Size = new System.Drawing.Size(100, 20);
            this.Served_GenTB.TabIndex = 11;
            this.Served_GenTB.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Main Queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Served (General)";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Queue
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.Queue.DefaultCellStyle = dataGridViewCellStyle2;
            this.Queue.HeaderText = "Queue";
            this.Queue.Name = "Queue";
            this.Queue.ReadOnly = true;
            // 
            // ServeTime
            // 
            this.ServeTime.HeaderText = "Serve Time";
            this.ServeTime.Name = "ServeTime";
            this.ServeTime.ReadOnly = true;
            // 
            // Served
            // 
            dataGridViewCellStyle3.NullValue = "0";
            this.Served.DefaultCellStyle = dataGridViewCellStyle3;
            this.Served.HeaderText = "Served";
            this.Served.Name = "Served";
            this.Served.ReadOnly = true;
            this.Served.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Served.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dismissal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Fire";
            this.Dismissal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dismissal.HeaderText = "Dismissal";
            this.Dismissal.Name = "Dismissal";
            this.Dismissal.ReadOnly = true;
            this.Dismissal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dismissal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Served_GenTB);
            this.Controls.Add(this.MainQTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArFreqNU);
            this.Controls.Add(this.ClDnstTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClDnstTrB);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ServeTimeNU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.St_P_Button);
            this.Controls.Add(this.CashRegisterDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Eternal Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CashRegisterDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServeTimeNU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClDnstTrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArFreqNU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CashRegisterDGV;
        private System.Windows.Forms.Button St_P_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ServeTimeNU;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TrackBar ClDnstTrB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClDnstTB;
        private System.Windows.Forms.NumericUpDown ArFreqNU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MainQTB;
        private System.Windows.Forms.TextBox Served_GenTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Queue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Served;
        private System.Windows.Forms.DataGridViewButtonColumn Dismissal;
    }
}

