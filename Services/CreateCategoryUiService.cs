using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using MuchMoneyUpgrade.Dtos;

namespace MuchMoneyUpgrade.Services
{
    public class CreateCategoryUiService
    {

         public CreateCategoryUiService()
        {
        }
        public CreateCategoryUiItems CreateInitialFormItem()
        {

            var createCategiryUiDto = new CreateCategoryUiItems();

            //Label Category
            createCategiryUiDto.CreateCategoryLabel.AutoSize = true;
            createCategiryUiDto.CreateCategoryLabel.Location = new Point(60, 58);
            createCategiryUiDto.CreateCategoryLabel.Name = "category";
            createCategiryUiDto.CreateCategoryLabel.Size = new Size(87, 15);
            createCategiryUiDto.CreateCategoryLabel.TabIndex = 0;
            createCategiryUiDto.CreateCategoryLabel.Text = "Create Category";

            //Label nameCategory
            createCategiryUiDto.CreateCategoryLabelName.AutoSize = true;
            createCategiryUiDto.CreateCategoryLabelName.Location = new Point(64, 93);
            createCategiryUiDto.CreateCategoryLabelName.Name = "nameCategory";
            createCategiryUiDto.CreateCategoryLabelName.Size = new Size(38, 15);
            createCategiryUiDto.CreateCategoryLabelName.Text = "Name";

            //textBox Create Category
            createCategiryUiDto.CreateCategoryTextBox.Location = new Point(108, 85);
            createCategiryUiDto.CreateCategoryTextBox.Name = "textBoxCreateCategory";
            createCategiryUiDto.CreateCategoryTextBox.Size = new Size(100, 23);
            createCategiryUiDto.CreateCategoryTextBox.TabIndex = 3;

            //Button Create Category
            createCategiryUiDto.CreateCategoryButton.Location = new Point(60, 137);
            createCategiryUiDto.CreateCategoryButton.Name = "buttonCreateCategory";
            createCategiryUiDto.CreateCategoryButton.Size = new Size(75, 23);
            createCategiryUiDto.CreateCategoryButton.TabIndex = 2;
            createCategiryUiDto.CreateCategoryButton.Text = "create";
            createCategiryUiDto.CreateCategoryButton.UseVisualStyleBackColor = true;

            //Form
            //Text = "Much Money";
            //ClientSize = new Size(824, 452);
            //Controls.Add(CreateCategoryLabel);
            //Controls.Add(CreateCategoryLabelName);
            //Controls.Add(CreateCategoryTextBox);
            //Controls.Add(CreateCategoryButton);
            return createCategiryUiDto;
        }
    }
}
