
namespace CO2_Interface.Controls
{
    partial class ErrorsTable
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ErrorsGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.rType5 = new System.Windows.Forms.RadioButton();
            this.rType4 = new System.Windows.Forms.RadioButton();
            this.rType3 = new System.Windows.Forms.RadioButton();
            this.rType2 = new System.Windows.Forms.RadioButton();
            this.rType1 = new System.Windows.Forms.RadioButton();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorsGrid)).BeginInit();
            this.groupBoxAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorsGrid
            // 
            this.ErrorsGrid.AllowUserToAddRows = false;
            this.ErrorsGrid.AllowUserToDeleteRows = false;
            this.ErrorsGrid.AllowUserToResizeColumns = false;
            this.ErrorsGrid.AllowUserToResizeRows = false;
            this.ErrorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ErrorsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ErrorsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ErrorsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ErrorsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ErrorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ErrorsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ErrorsGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ErrorsGrid.Location = new System.Drawing.Point(5, 6);
            this.ErrorsGrid.MultiSelect = false;
            this.ErrorsGrid.Name = "ErrorsGrid";
            this.ErrorsGrid.ReadOnly = true;
            this.ErrorsGrid.RowHeadersVisible = false;
            this.ErrorsGrid.RowHeadersWidth = 62;
            this.ErrorsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ErrorsGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ErrorsGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.ErrorsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Navy;
            this.ErrorsGrid.RowTemplate.ReadOnly = true;
            this.ErrorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorsGrid.Size = new System.Drawing.Size(712, 591);
            this.ErrorsGrid.TabIndex = 3;
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAlarm.Controls.Add(this.rType5);
            this.groupBoxAlarm.Controls.Add(this.rType4);
            this.groupBoxAlarm.Controls.Add(this.rType3);
            this.groupBoxAlarm.Controls.Add(this.rType2);
            this.groupBoxAlarm.Controls.Add(this.rType1);
            this.groupBoxAlarm.Controls.Add(this.rAll);
            this.groupBoxAlarm.Controls.Add(this.label1);
            this.groupBoxAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBoxAlarm.ForeColor = System.Drawing.Color.White;
            this.groupBoxAlarm.Location = new System.Drawing.Point(731, 57);
            this.groupBoxAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAlarm.Size = new System.Drawing.Size(357, 540);
            this.groupBoxAlarm.TabIndex = 21;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Text = "Configuration";
            // 
            // rType5
            // 
            this.rType5.AutoSize = true;
            this.rType5.ForeColor = System.Drawing.Color.White;
            this.rType5.Location = new System.Drawing.Point(135, 404);
            this.rType5.Name = "rType5";
            this.rType5.Size = new System.Drawing.Size(151, 35);
            this.rType5.TabIndex = 21;
            this.rType5.Text = "Functions";
            this.rType5.UseVisualStyleBackColor = true;
            // 
            // rType4
            // 
            this.rType4.AutoSize = true;
            this.rType4.ForeColor = System.Drawing.Color.White;
            this.rType4.Location = new System.Drawing.Point(135, 351);
            this.rType4.Name = "rType4";
            this.rType4.Size = new System.Drawing.Size(70, 35);
            this.rType4.TabIndex = 20;
            this.rType4.Text = "DB";
            this.rType4.UseVisualStyleBackColor = true;
            // 
            // rType3
            // 
            this.rType3.AutoSize = true;
            this.rType3.ForeColor = System.Drawing.Color.White;
            this.rType3.Location = new System.Drawing.Point(135, 294);
            this.rType3.Name = "rType3";
            this.rType3.Size = new System.Drawing.Size(88, 35);
            this.rType3.TabIndex = 19;
            this.rType3.Text = "CSV";
            this.rType3.UseVisualStyleBackColor = true;
            // 
            // rType2
            // 
            this.rType2.AutoSize = true;
            this.rType2.ForeColor = System.Drawing.Color.White;
            this.rType2.Location = new System.Drawing.Point(135, 240);
            this.rType2.Name = "rType2";
            this.rType2.Size = new System.Drawing.Size(90, 35);
            this.rType2.TabIndex = 18;
            this.rType2.Text = "Data";
            this.rType2.UseVisualStyleBackColor = true;
            // 
            // rType1
            // 
            this.rType1.AutoSize = true;
            this.rType1.ForeColor = System.Drawing.Color.White;
            this.rType1.Location = new System.Drawing.Point(135, 183);
            this.rType1.Name = "rType1";
            this.rType1.Size = new System.Drawing.Size(95, 35);
            this.rType1.TabIndex = 17;
            this.rType1.Text = "COM";
            this.rType1.UseVisualStyleBackColor = true;
            // 
            // rAll
            // 
            this.rAll.AutoSize = true;
            this.rAll.Checked = true;
            this.rAll.ForeColor = System.Drawing.Color.White;
            this.rAll.Location = new System.Drawing.Point(135, 124);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(62, 35);
            this.rAll.TabIndex = 16;
            this.rAll.TabStop = true;
            this.rAll.Text = "All";
            this.rAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ref :";
            // 
            // ErrorsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxAlarm);
            this.Controls.Add(this.ErrorsGrid);
            this.Name = "ErrorsTable";
            this.Size = new System.Drawing.Size(1111, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorsGrid)).EndInit();
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView ErrorsGrid;
        internal System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RadioButton rType5;
        internal System.Windows.Forms.RadioButton rType4;
        internal System.Windows.Forms.RadioButton rType3;
        internal System.Windows.Forms.RadioButton rType2;
        internal System.Windows.Forms.RadioButton rType1;
        internal System.Windows.Forms.RadioButton rAll;
    }
}
