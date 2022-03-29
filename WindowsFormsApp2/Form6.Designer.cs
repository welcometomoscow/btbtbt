namespace WindowsFormsApp2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.риелторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rieltorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentNedvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentNedvDataSet = new WindowsFormsApp2.AgentNedvDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nedvizhimostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentNedvDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp2.AgentNedvDataSetTableAdapters.ClientTableAdapter();
            this.zastroyshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zastroyshikTableAdapter = new WindowsFormsApp2.AgentNedvDataSetTableAdapters.ZastroyshikTableAdapter();
            this.zastroyshikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nedvizhimostTableAdapter = new WindowsFormsApp2.AgentNedvDataSetTableAdapters.NedvizhimostTableAdapter();
            this.rieltorTableAdapter = new WindowsFormsApp2.AgentNedvDataSetTableAdapters.RieltorTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvizhimostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastroyshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastroyshikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.недвижимостьToolStripMenuItem,
            this.риелторыToolStripMenuItem,
            this.договорToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            this.недвижимостьToolStripMenuItem.Click += new System.EventHandler(this.недвижимостьToolStripMenuItem_Click);
            // 
            // риелторыToolStripMenuItem
            // 
            this.риелторыToolStripMenuItem.Name = "риелторыToolStripMenuItem";
            this.риелторыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.риелторыToolStripMenuItem.Text = "Риелторы";
            this.риелторыToolStripMenuItem.Click += new System.EventHandler(this.риелторыToolStripMenuItem_Click);
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.договорToolStripMenuItem.Text = "Договор";
            this.договорToolStripMenuItem.Click += new System.EventHandler(this.договорToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммемToolStripMenuItem,
            this.экспортВExcelToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммемToolStripMenuItem
            // 
            this.оПрограммемToolStripMenuItem.Name = "оПрограммемToolStripMenuItem";
            this.оПрограммемToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммемToolStripMenuItem.Text = "О программе";
            this.оПрограммемToolStripMenuItem.Click += new System.EventHandler(this.оПрограммемToolStripMenuItem_Click);
            // 
            // экспортВExcelToolStripMenuItem
            // 
            this.экспортВExcelToolStripMenuItem.Name = "экспортВExcelToolStripMenuItem";
            this.экспортВExcelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.экспортВExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.экспортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 104);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.rieltorBindingSource;
            this.comboBox3.DisplayMember = "Familya";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(494, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "ID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // rieltorBindingSource
            // 
            this.rieltorBindingSource.DataMember = "Rieltor";
            this.rieltorBindingSource.DataSource = this.agentNedvDataSetBindingSource;
            // 
            // agentNedvDataSetBindingSource
            // 
            this.agentNedvDataSetBindingSource.DataSource = this.agentNedvDataSet;
            this.agentNedvDataSetBindingSource.Position = 0;
            // 
            // agentNedvDataSet
            // 
            this.agentNedvDataSet.DataSetName = "AgentNedvDataSet";
            this.agentNedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.nedvizhimostBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(333, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID";
            // 
            // nedvizhimostBindingSource
            // 
            this.nedvizhimostBindingSource.DataMember = "Nedvizhimost";
            this.nedvizhimostBindingSource.DataSource = this.agentNedvDataSetBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "Familya";
            this.comboBox1.Location = new System.Drawing.Point(165, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.agentNedvDataSetBindingSource;
            // 
            // agentNedvDataSetBindingSource1
            // 
            this.agentNedvDataSetBindingSource1.DataSource = this.agentNedvDataSet;
            this.agentNedvDataSetBindingSource1.Position = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // zastroyshikBindingSource
            // 
            this.zastroyshikBindingSource.DataMember = "Zastroyshik";
            this.zastroyshikBindingSource.DataSource = this.agentNedvDataSetBindingSource;
            // 
            // zastroyshikTableAdapter
            // 
            this.zastroyshikTableAdapter.ClearBeforeFill = true;
            // 
            // zastroyshikBindingSource1
            // 
            this.zastroyshikBindingSource1.DataMember = "Zastroyshik";
            this.zastroyshikBindingSource1.DataSource = this.agentNedvDataSetBindingSource1;
            // 
            // nedvizhimostTableAdapter
            // 
            this.nedvizhimostTableAdapter.ClearBeforeFill = true;
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.Text = "Агенство недвижимости \"LTH\": Договор";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvizhimostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastroyshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastroyshikBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private AgentNedvDataSet agentNedvDataSet;
        private System.Windows.Forms.BindingSource agentNedvDataSetBindingSource;
        private System.Windows.Forms.BindingSource agentNedvDataSetBindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AgentNedvDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource zastroyshikBindingSource;
        private AgentNedvDataSetTableAdapters.ZastroyshikTableAdapter zastroyshikTableAdapter;
        private System.Windows.Forms.BindingSource zastroyshikBindingSource1;
        private System.Windows.Forms.BindingSource nedvizhimostBindingSource;
        private AgentNedvDataSetTableAdapters.NedvizhimostTableAdapter nedvizhimostTableAdapter;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private AgentNedvDataSetTableAdapters.RieltorTableAdapter rieltorTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВExcelToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem риелторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
    }
}