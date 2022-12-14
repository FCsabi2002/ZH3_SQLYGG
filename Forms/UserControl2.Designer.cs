namespace Forms
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.instructorFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dayFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timeFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonSkDataGridViewTextBoxColumn,
            this.courseFkDataGridViewTextBoxColumn,
            this.instructorFkDataGridViewTextBoxColumn,
            this.dayFkDataGridViewTextBoxColumn,
            this.timeFkDataGridViewTextBoxColumn,
            this.roomFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(633, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(Forms.Models.Lesson);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Forms.Models.Course);
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(Forms.Models.Instructor);
            // 
            // dayBindingSource
            // 
            this.dayBindingSource.DataSource = typeof(Forms.Models.Day);
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(Forms.Models.Time);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(Forms.Models.Room);
            // 
            // lessonSkDataGridViewTextBoxColumn
            // 
            this.lessonSkDataGridViewTextBoxColumn.DataPropertyName = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.HeaderText = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.Name = "lessonSkDataGridViewTextBoxColumn";
            this.lessonSkDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseFkDataGridViewTextBoxColumn
            // 
            this.courseFkDataGridViewTextBoxColumn.DataPropertyName = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.DataSource = this.courseBindingSource;
            this.courseFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.courseFkDataGridViewTextBoxColumn.HeaderText = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.Name = "courseFkDataGridViewTextBoxColumn";
            this.courseFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.courseFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseFkDataGridViewTextBoxColumn.ValueMember = "CourseSk";
            // 
            // instructorFkDataGridViewTextBoxColumn
            // 
            this.instructorFkDataGridViewTextBoxColumn.DataPropertyName = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.DataSource = this.instructorBindingSource;
            this.instructorFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.instructorFkDataGridViewTextBoxColumn.HeaderText = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.Name = "instructorFkDataGridViewTextBoxColumn";
            this.instructorFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.instructorFkDataGridViewTextBoxColumn.ValueMember = "InstructorSk";
            // 
            // dayFkDataGridViewTextBoxColumn
            // 
            this.dayFkDataGridViewTextBoxColumn.DataPropertyName = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.DataSource = this.dayBindingSource;
            this.dayFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.dayFkDataGridViewTextBoxColumn.HeaderText = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.Name = "dayFkDataGridViewTextBoxColumn";
            this.dayFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dayFkDataGridViewTextBoxColumn.ValueMember = "DayId";
            // 
            // timeFkDataGridViewTextBoxColumn
            // 
            this.timeFkDataGridViewTextBoxColumn.DataPropertyName = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.DataSource = this.timeBindingSource;
            this.timeFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.timeFkDataGridViewTextBoxColumn.HeaderText = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.Name = "timeFkDataGridViewTextBoxColumn";
            this.timeFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timeFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.timeFkDataGridViewTextBoxColumn.ValueMember = "TimeId";
            // 
            // roomFkDataGridViewTextBoxColumn
            // 
            this.roomFkDataGridViewTextBoxColumn.DataPropertyName = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.DataSource = this.roomBindingSource;
            this.roomFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.roomFkDataGridViewTextBoxColumn.HeaderText = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.Name = "roomFkDataGridViewTextBoxColumn";
            this.roomFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomFkDataGridViewTextBoxColumn.ValueMember = "RoomSk";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(934, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn lessonSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn courseFkDataGridViewTextBoxColumn;
        private BindingSource courseBindingSource;
        private DataGridViewComboBoxColumn instructorFkDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
        private DataGridViewComboBoxColumn dayFkDataGridViewTextBoxColumn;
        private BindingSource dayBindingSource;
        private DataGridViewComboBoxColumn timeFkDataGridViewTextBoxColumn;
        private BindingSource timeBindingSource;
        private DataGridViewComboBoxColumn roomFkDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private BindingSource lessonBindingSource;
    }
}
