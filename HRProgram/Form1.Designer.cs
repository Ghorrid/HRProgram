namespace HRProgram
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
            this.dgvEmpolyees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.cmbEmployeeGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpolyees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpolyees
            // 
            this.dgvEmpolyees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpolyees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpolyees.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvEmpolyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpolyees.Location = new System.Drawing.Point(16, 107);
            this.dgvEmpolyees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpolyees.Name = "dgvEmpolyees";
            this.dgvEmpolyees.RowHeadersVisible = false;
            this.dgvEmpolyees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpolyees.Size = new System.Drawing.Size(1065, 501);
            this.dgvEmpolyees.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 28);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(107, 71);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Dodaj Pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditEmployee.Location = new System.Drawing.Point(131, 28);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(107, 71);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Edytuj Pracownika";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRefresh.Location = new System.Drawing.Point(599, 28);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 71);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Filtruj";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(976, 28);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 71);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń błędny rekord";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.Pink;
            this.btnDismiss.Location = new System.Drawing.Point(246, 28);
            this.btnDismiss.Margin = new System.Windows.Forms.Padding(4);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(107, 71);
            this.btnDismiss.TabIndex = 5;
            this.btnDismiss.Text = "Zwolnij pracownika";
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // cmbEmployeeGroup
            // 
            this.cmbEmployeeGroup.FormattingEnabled = true;
            this.cmbEmployeeGroup.Location = new System.Drawing.Point(412, 60);
            this.cmbEmployeeGroup.Name = "cmbEmployeeGroup";
            this.cmbEmployeeGroup.Size = new System.Drawing.Size(135, 24);
            this.cmbEmployeeGroup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtr:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployeeGroup);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgvEmpolyees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1122, 662);
            this.Name = "Form1";
            this.Text = "Kadry i płace";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpolyees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpolyees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.ComboBox cmbEmployeeGroup;
        private System.Windows.Forms.Label label1;
    }
}

