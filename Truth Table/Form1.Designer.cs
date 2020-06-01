namespace Truth_Table
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
            this.CBX_Operators = new System.Windows.Forms.ComboBox();
            this.BTN_Table = new System.Windows.Forms.Button();
            this.TBL_TruthTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truth Table Generator";
            // 
            // CBX_Operators
            // 
            this.CBX_Operators.FormattingEnabled = true;
            this.CBX_Operators.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NAND",
            "NOR",
            "XOR"});
            this.CBX_Operators.Location = new System.Drawing.Point(18, 120);
            this.CBX_Operators.Name = "CBX_Operators";
            this.CBX_Operators.Size = new System.Drawing.Size(298, 21);
            this.CBX_Operators.TabIndex = 2;
            // 
            // BTN_Table
            // 
            this.BTN_Table.Location = new System.Drawing.Point(12, 146);
            this.BTN_Table.Name = "BTN_Table";
            this.BTN_Table.Size = new System.Drawing.Size(305, 37);
            this.BTN_Table.TabIndex = 4;
            this.BTN_Table.Text = "Generate Table";
            this.BTN_Table.UseVisualStyleBackColor = true;
            this.BTN_Table.Click += new System.EventHandler(this.BTN_Table_Click);
            // 
            // TBL_TruthTable
            // 
            this.TBL_TruthTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TBL_TruthTable.ColumnCount = 3;
            this.TBL_TruthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TBL_TruthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBL_TruthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBL_TruthTable.Location = new System.Drawing.Point(12, 189);
            this.TBL_TruthTable.Name = "TBL_TruthTable";
            this.TBL_TruthTable.RowCount = 3;
            this.TBL_TruthTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TBL_TruthTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBL_TruthTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TBL_TruthTable.Size = new System.Drawing.Size(305, 148);
            this.TBL_TruthTable.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 354);
            this.Controls.Add(this.TBL_TruthTable);
            this.Controls.Add(this.BTN_Table);
            this.Controls.Add(this.CBX_Operators);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_Operators;
        private System.Windows.Forms.Button BTN_Table;
        private System.Windows.Forms.TableLayoutPanel TBL_TruthTable;
    }
}

