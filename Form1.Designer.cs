
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодАбонентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поБатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cardFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.картотека_абонентів_АТСDataSet = new WindowsFormsApp1.Картотека_абонентів_АТСDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.card_FileTableAdapter = new WindowsFormsApp1.Картотека_абонентів_АТСDataSetTableAdapters.Card_FileTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентівПоТарифуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентаПоНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.картотека_абонентів_АТСDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАбонентаDataGridViewTextBoxColumn,
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.поБатьковіDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.тарифDataGridViewTextBoxColumn,
            this.оплатаDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.cardFileBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодАбонентаDataGridViewTextBoxColumn
            // 
            this.кодАбонентаDataGridViewTextBoxColumn.DataPropertyName = "Код абонента";
            this.кодАбонентаDataGridViewTextBoxColumn.HeaderText = "Код абонента";
            this.кодАбонентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАбонентаDataGridViewTextBoxColumn.Name = "кодАбонентаDataGridViewTextBoxColumn";
            this.кодАбонентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодАбонентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            this.прізвищеDataGridViewTextBoxColumn.ReadOnly = true;
            this.прізвищеDataGridViewTextBoxColumn.Width = 125;
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            this.імяDataGridViewTextBoxColumn.ReadOnly = true;
            this.імяDataGridViewTextBoxColumn.Width = 125;
            // 
            // поБатьковіDataGridViewTextBoxColumn
            // 
            this.поБатьковіDataGridViewTextBoxColumn.DataPropertyName = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.поБатьковіDataGridViewTextBoxColumn.Name = "поБатьковіDataGridViewTextBoxColumn";
            this.поБатьковіDataGridViewTextBoxColumn.ReadOnly = true;
            this.поБатьковіDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // тарифDataGridViewTextBoxColumn
            // 
            this.тарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф";
            this.тарифDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.тарифDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тарифDataGridViewTextBoxColumn.Name = "тарифDataGridViewTextBoxColumn";
            this.тарифDataGridViewTextBoxColumn.ReadOnly = true;
            this.тарифDataGridViewTextBoxColumn.Width = 125;
            // 
            // оплатаDataGridViewCheckBoxColumn
            // 
            this.оплатаDataGridViewCheckBoxColumn.DataPropertyName = "Оплата";
            this.оплатаDataGridViewCheckBoxColumn.HeaderText = "Оплата";
            this.оплатаDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.оплатаDataGridViewCheckBoxColumn.Name = "оплатаDataGridViewCheckBoxColumn";
            this.оплатаDataGridViewCheckBoxColumn.ReadOnly = true;
            this.оплатаDataGridViewCheckBoxColumn.Width = 125;
            // 
            // cardFileBindingSource
            // 
            this.cardFileBindingSource.DataMember = "Card_File";
            this.cardFileBindingSource.DataSource = this.картотека_абонентів_АТСDataSet;
            // 
            // картотека_абонентів_АТСDataSet
            // 
            this.картотека_абонентів_АТСDataSet.DataSetName = "Картотека_абонентів_АТСDataSet";
            this.картотека_абонентів_АТСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати абонента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(890, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(389, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "Змінити тарифний план абоненту";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(20, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 77);
            this.button4.TabIndex = 4;
            this.button4.Text = "Видалити абонента";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(401, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Картотека абонентів АТС\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 6;
            // 
            // card_FileTableAdapter
            // 
            this.card_FileTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вкажіть код абонента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(891, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вкажіть код абонента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(895, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вкажіть новий тариф:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1166, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1166, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 22);
            this.textBox3.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1055, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 70);
            this.button2.TabIndex = 13;
            this.button2.Text = "Оновити дані таблиці";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(445, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(385, 80);
            this.button5.TabIndex = 14;
            this.button5.Text = "Внести відомості про оплату";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(450, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введіть \"True\" / \"False\"";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(730, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(451, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вкажіть код абонента:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(730, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 33);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентівПоТарифуToolStripMenuItem,
            this.абонентаПоНомеруToolStripMenuItem,
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem});
            this.пошукToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // абонентівПоТарифуToolStripMenuItem
            // 
            this.абонентівПоТарифуToolStripMenuItem.Name = "абонентівПоТарифуToolStripMenuItem";
            this.абонентівПоТарифуToolStripMenuItem.Size = new System.Drawing.Size(384, 30);
            this.абонентівПоТарифуToolStripMenuItem.Text = "абонентів по тарифу";
            this.абонентівПоТарифуToolStripMenuItem.Click += new System.EventHandler(this.абонентівПоТарифуToolStripMenuItem_Click);
            // 
            // абонентаПоНомеруToolStripMenuItem
            // 
            this.абонентаПоНомеруToolStripMenuItem.Name = "абонентаПоНомеруToolStripMenuItem";
            this.абонентаПоНомеруToolStripMenuItem.Size = new System.Drawing.Size(384, 30);
            this.абонентаПоНомеруToolStripMenuItem.Text = "абонента по номеру";
            this.абонентаПоНомеруToolStripMenuItem.Click += new System.EventHandler(this.абонентаПоНомеруToolStripMenuItem_Click);
            // 
            // абонентівПоЗдійсненнюОплатиToolStripMenuItem
            // 
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem.Name = "абонентівПоЗдійсненнюОплатиToolStripMenuItem";
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem.Size = new System.Drawing.Size(384, 30);
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem.Text = "абонентів по здійсненню оплати";
            this.абонентівПоЗдійсненнюОплатиToolStripMenuItem.Click += new System.EventHandler(this.абонентівПоЗдійсненнюОплатиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1291, 706);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Картотека абонентів АТС";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.картотека_абонентів_АТСDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Картотека_абонентів_АТСDataSet картотека_абонентів_АТСDataSet;
        private System.Windows.Forms.BindingSource cardFileBindingSource;
        private Картотека_абонентів_АТСDataSetTableAdapters.Card_FileTableAdapter card_FileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАбонентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn оплатаDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентівПоТарифуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентаПоНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентівПоЗдійсненнюОплатиToolStripMenuItem;
    }
}

