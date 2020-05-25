namespace Menu_Builder
{
    partial class MenuBuilder_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.ChooseLB = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ObjectsLB = new System.Windows.Forms.ListBox();
            this.PropertiesLB = new System.Windows.Forms.ListBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.PropsTB = new System.Windows.Forms.TextBox();
            this.PropsCB = new System.Windows.Forms.ComboBox();
            this.SerializersCB = new System.Windows.Forms.ComboBox();
            this.LoadBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileD = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ClassesCB
            // 
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(261, 47);
            this.ClassesCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(206, 28);
            this.ClassesCB.TabIndex = 3;
            this.ClassesCB.SelectedIndexChanged += new System.EventHandler(this.ClassesCB_SelectedIndexChanged);
            // 
            // ChooseLB
            // 
            this.ChooseLB.AutoSize = true;
            this.ChooseLB.Location = new System.Drawing.Point(311, 18);
            this.ChooseLB.Name = "ChooseLB";
            this.ChooseLB.Size = new System.Drawing.Size(96, 17);
            this.ChooseLB.TabIndex = 4;
            this.ChooseLB.Text = "Choose class:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateBtn.Location = new System.Drawing.Point(261, 95);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(82, 32);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(380, 95);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(87, 32);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ObjectsLB
            // 
            this.ObjectsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObjectsLB.FormattingEnabled = true;
            this.ObjectsLB.ItemHeight = 26;
            this.ObjectsLB.Location = new System.Drawing.Point(12, 35);
            this.ObjectsLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ObjectsLB.Name = "ObjectsLB";
            this.ObjectsLB.Size = new System.Drawing.Size(226, 290);
            this.ObjectsLB.TabIndex = 8;
            this.ObjectsLB.SelectedIndexChanged += new System.EventHandler(this.ObjectsLB_SelectedIndexChanged);
            // 
            // PropertiesLB
            // 
            this.PropertiesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesLB.FormattingEnabled = true;
            this.PropertiesLB.ItemHeight = 26;
            this.PropertiesLB.Location = new System.Drawing.Point(500, 35);
            this.PropertiesLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropertiesLB.Name = "PropertiesLB";
            this.PropertiesLB.Size = new System.Drawing.Size(261, 290);
            this.PropertiesLB.TabIndex = 9;
            this.PropertiesLB.SelectedIndexChanged += new System.EventHandler(this.PropertiesLB_SelectedIndexChanged);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.AutoSize = true;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmBtn.Location = new System.Drawing.Point(314, 186);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(93, 30);
            this.ConfirmBtn.TabIndex = 10;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // PropsTB
            // 
            this.PropsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropsTB.Location = new System.Drawing.Point(261, 142);
            this.PropsTB.Name = "PropsTB";
            this.PropsTB.Size = new System.Drawing.Size(206, 27);
            this.PropsTB.TabIndex = 11;
            // 
            // PropsCB
            // 
            this.PropsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropsCB.Enabled = false;
            this.PropsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropsCB.FormattingEnabled = true;
            this.PropsCB.Location = new System.Drawing.Point(261, 142);
            this.PropsCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropsCB.Name = "PropsCB";
            this.PropsCB.Size = new System.Drawing.Size(206, 28);
            this.PropsCB.TabIndex = 12;
            this.PropsCB.Visible = false;
            this.PropsCB.SelectedIndexChanged += new System.EventHandler(this.PropsCB_SelectedIndexChanged);
            // 
            // SerializersCB
            // 
            this.SerializersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerializersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerializersCB.FormattingEnabled = true;
            this.SerializersCB.Location = new System.Drawing.Point(261, 234);
            this.SerializersCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerializersCB.Name = "SerializersCB";
            this.SerializersCB.Size = new System.Drawing.Size(206, 28);
            this.SerializersCB.TabIndex = 13;
            // 
            // LoadBT
            // 
            this.LoadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadBT.Location = new System.Drawing.Point(261, 276);
            this.LoadBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadBT.Name = "LoadBT";
            this.LoadBT.Size = new System.Drawing.Size(82, 32);
            this.LoadBT.TabIndex = 14;
            this.LoadBT.Text = "Load";
            this.LoadBT.UseVisualStyleBackColor = true;
            this.LoadBT.Click += new System.EventHandler(this.LoadBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBT.Location = new System.Drawing.Point(380, 276);
            this.SaveBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(87, 32);
            this.SaveBT.TabIndex = 15;
            this.SaveBT.Text = "Save";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // OpenFileD
            // 
            this.OpenFileD.FileName = "openFileDialog1";
            // 
            // MenuBuilder_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 346);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.LoadBT);
            this.Controls.Add(this.SerializersCB);
            this.Controls.Add(this.PropsCB);
            this.Controls.Add(this.PropsTB);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.PropertiesLB);
            this.Controls.Add(this.ObjectsLB);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.ChooseLB);
            this.Controls.Add(this.ClassesCB);
            this.Name = "MenuBuilder_form";
            this.Text = "Menu Builder";
            this.Load += new System.EventHandler(this.MenuBuilder_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChooseLB;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListBox ObjectsLB;
        private System.Windows.Forms.ListBox PropertiesLB;
        private System.Windows.Forms.ComboBox ClassesCB;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox PropsTB;
        private System.Windows.Forms.ComboBox PropsCB;
        private System.Windows.Forms.ComboBox SerializersCB;
        private System.Windows.Forms.Button LoadBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.OpenFileDialog OpenFileD;
        private System.Windows.Forms.SaveFileDialog SaveFileD;
    }
}

