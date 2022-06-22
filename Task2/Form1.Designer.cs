namespace Task2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.contextContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextContainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextContainerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AccessibleName = "";
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(42, 23);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(691, 357);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // contextContainerBindingSource
            // 
            this.contextContainerBindingSource.DataSource = typeof(Task2.ContextContainer);
            // 
            // contextContainerBindingSource1
            // 
            this.contextContainerBindingSource1.DataSource = typeof(Task2.ContextContainer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextContainerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.BindingSource contextContainerBindingSource;
        private System.Windows.Forms.BindingSource contextContainerBindingSource1;
    }
}

