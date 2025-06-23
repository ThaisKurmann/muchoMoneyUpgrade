using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMoneyUpgrade
{
    public class MainForm : Form
    {
        public MainForm()
        {
            categoryLabel = new Label();
            nameCategoryLabel = new Label();
            textBoxCreateCategory = new TextBox();
            buttonCreateCategory = new Button();

            //Label Category
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(60, 58);
            categoryLabel.Name = "category";
            categoryLabel.Size = new Size(87, 15);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Create Category";

            //Label nameCategory
            nameCategoryLabel.AutoSize = true;
            nameCategoryLabel.Location = new Point(64, 93);
            nameCategoryLabel.Name = "nameCategory";
            nameCategoryLabel.Size = new Size(38, 15);
            nameCategoryLabel.Text = "Name";
            
            //textBox Create Category
            textBoxCreateCategory.Location = new Point(108, 85);
            textBoxCreateCategory.Name = "textBoxCreateCategory";
            textBoxCreateCategory.Size = new Size(100, 23);
            textBoxCreateCategory.TabIndex = 3;

            //Button Create Category
            buttonCreateCategory.Location = new Point(60, 137);
            buttonCreateCategory.Name = "buttonCreateCategory";
            buttonCreateCategory.Size = new Size(75, 23);
            buttonCreateCategory.TabIndex = 2;
            buttonCreateCategory.Text = "create";
            buttonCreateCategory.UseVisualStyleBackColor = true;

            //Form
            Text = "Much Money";
            ClientSize = new Size(824, 452);
            Controls.Add(categoryLabel);
            Controls.Add(nameCategoryLabel);
            Controls.Add(textBoxCreateCategory);
            Controls.Add(buttonCreateCategory);
        }

        public Label categoryLabel;
        public Label nameCategoryLabel;
        public TextBox textBoxCreateCategory;
        public Button buttonCreateCategory;
        

    }
}
