﻿
namespace WindowsFormsAppCategory
{
    partial class FormCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.listBoxCategoties = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSubCategory = new System.Windows.Forms.ListBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnAddSubCategory = new System.Windows.Forms.Button();
            this.btnDeleteSubCategory = new System.Windows.Forms.Button();
            this.btnUpdateListCat = new System.Windows.Forms.Button();
            this.btnUpdateListSubCat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перечень категорий\r\n";
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(15, 350);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(172, 23);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Добавить категорию";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(16, 413);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(172, 23);
            this.btnRemoveCategory.TabIndex = 4;
            this.btnRemoveCategory.Text = "Удалить категорию";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // listBoxCategoties
            // 
            this.listBoxCategoties.FormattingEnabled = true;
            this.listBoxCategoties.Location = new System.Drawing.Point(16, 29);
            this.listBoxCategoties.Name = "listBoxCategoties";
            this.listBoxCategoties.Size = new System.Drawing.Size(172, 303);
            this.listBoxCategoties.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(170, 29);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 303);
            this.vScrollBar1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Подчинённые категории";
            // 
            // listBoxSubCategory
            // 
            this.listBoxSubCategory.FormattingEnabled = true;
            this.listBoxSubCategory.Location = new System.Drawing.Point(284, 29);
            this.listBoxSubCategory.Name = "listBoxSubCategory";
            this.listBoxSubCategory.Size = new System.Drawing.Size(171, 303);
            this.listBoxSubCategory.TabIndex = 8;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(438, 29);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 303);
            this.vScrollBar2.TabIndex = 9;
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Location = new System.Drawing.Point(284, 350);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(171, 23);
            this.btnAddSubCategory.TabIndex = 10;
            this.btnAddSubCategory.Text = "Добавить подкатегорию";
            this.btnAddSubCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(284, 413);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(171, 23);
            this.btnDeleteSubCategory.TabIndex = 11;
            this.btnDeleteSubCategory.Text = "Удалить подкатегорию";
            this.btnDeleteSubCategory.UseVisualStyleBackColor = true;
            // 
            // btnUpdateListCat
            // 
            this.btnUpdateListCat.Location = new System.Drawing.Point(16, 380);
            this.btnUpdateListCat.Name = "btnUpdateListCat";
            this.btnUpdateListCat.Size = new System.Drawing.Size(171, 23);
            this.btnUpdateListCat.TabIndex = 12;
            this.btnUpdateListCat.Text = "Обновить перечень";
            this.btnUpdateListCat.UseVisualStyleBackColor = true;
            this.btnUpdateListCat.Click += new System.EventHandler(this.btnUpdateListCat_Click);
            // 
            // btnUpdateListSubCat
            // 
            this.btnUpdateListSubCat.Location = new System.Drawing.Point(284, 379);
            this.btnUpdateListSubCat.Name = "btnUpdateListSubCat";
            this.btnUpdateListSubCat.Size = new System.Drawing.Size(171, 23);
            this.btnUpdateListSubCat.TabIndex = 13;
            this.btnUpdateListSubCat.Text = "Обновить перечень";
            this.btnUpdateListSubCat.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(685, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateListSubCat);
            this.Controls.Add(this.btnUpdateListCat);
            this.Controls.Add(this.btnDeleteSubCategory);
            this.Controls.Add(this.btnAddSubCategory);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.listBoxSubCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.listBoxCategoties);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.label1);
            this.Name = "FormCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.ListBox listBoxCategoties;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSubCategory;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnAddSubCategory;
        private System.Windows.Forms.Button btnDeleteSubCategory;
        private System.Windows.Forms.Button btnUpdateListCat;
        private System.Windows.Forms.Button btnUpdateListSubCat;
        private System.Windows.Forms.Button btnExit;
    }
}

