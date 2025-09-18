namespace Windows_Forms_Tutorial
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCategories = new DataGridView();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            dataGridViewProducts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewCategories.DataSource = categoryBindingSource;
            dataGridViewCategories.Location = new Point(0, 0);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(240, 150);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged_1;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn2, categoryIdDataGridViewTextBoxColumn2, dataGridViewTextBoxColumn2 });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.Location = new Point(246, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(240, 150);
            dataGridViewProducts.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            dataGridViewTextBoxColumn1.HeaderText = "ProductId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // categoryIdDataGridViewTextBoxColumn2
            // 
            categoryIdDataGridViewTextBoxColumn2.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn2.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn2.Name = "categoryIdDataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Category";
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(411, 156);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 184);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewProducts);
            Controls.Add(dataGridViewCategories);
            Name = "MainForm";
            Text = "Products and Categories";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCategories;
        private DataGridView dataGridViewProducts;
        private Button buttonSave;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource productsBindingSource;
    }
}
