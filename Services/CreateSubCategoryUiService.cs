using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Ui;

namespace MuchMoneyUpgrade.Services
{
    public class CreateSubCategoryUiService : ICreateSubCategoryUiService
    {
        public CreateSubCategoryUiItems CreateInitialFormItem()
        {

            var createSubCategoryUiDto = new CreateSubCategoryUiItems();

            //Label SubCategory
            createSubCategoryUiDto.CreateSubCategoryLabel.AutoSize = true;
            createSubCategoryUiDto.CreateSubCategoryLabel.Location = new Point(500, 58);
            createSubCategoryUiDto.CreateSubCategoryLabel.Name = "SubCategory";
            createSubCategoryUiDto.CreateSubCategoryLabel.Size = new Size(87, 15);
            createSubCategoryUiDto.CreateSubCategoryLabel.TabIndex = 0;
            createSubCategoryUiDto.CreateSubCategoryLabel.Text = "Create SubCategory";

            //Label nameCategory
            createSubCategoryUiDto.CreateSubCategoryLabelName.AutoSize = true;
            createSubCategoryUiDto.CreateSubCategoryLabelName.Location = new Point(504, 93);
            createSubCategoryUiDto.CreateSubCategoryLabelName.Name = "nameCategory";
            createSubCategoryUiDto.CreateSubCategoryLabelName.Size = new Size(38, 15);
            createSubCategoryUiDto.CreateSubCategoryLabelName.Text = "Name";

            //textBox Create Category
            createSubCategoryUiDto.CreateSubCategoryTextBox.Location = new Point(550, 85);
            createSubCategoryUiDto.CreateSubCategoryTextBox.Name = "textBoxCreateCategory";
            createSubCategoryUiDto.CreateSubCategoryTextBox.Size = new Size(100, 23);
            createSubCategoryUiDto.CreateSubCategoryTextBox.TabIndex = 3;


            //Button Create Category
            createSubCategoryUiDto.CreateSubCategoryButton.Location = new Point(500, 137);
            createSubCategoryUiDto.CreateSubCategoryButton.Name = "buttonCreateCategory";
            createSubCategoryUiDto.CreateSubCategoryButton.Size = new Size(75, 23);
            createSubCategoryUiDto.CreateSubCategoryButton.TabIndex = 2;
            createSubCategoryUiDto.CreateSubCategoryButton.Text = "create";
            createSubCategoryUiDto.CreateSubCategoryButton.UseVisualStyleBackColor = true;
            createSubCategoryUiDto.CreateSubCategoryButton.Tag = createSubCategoryUiDto.CreateSubCategoryTextBox;

            //ListBox Create Category
            createSubCategoryUiDto.CreateSubCategoryListBox.FormattingEnabled = true;
            createSubCategoryUiDto.CreateSubCategoryListBox.ItemHeight = 15;
            createSubCategoryUiDto.CreateSubCategoryListBox.Location = new Point(737, 47);
            createSubCategoryUiDto.CreateSubCategoryListBox.Name = "listBox1";
            createSubCategoryUiDto.CreateSubCategoryListBox.Size = new Size(182, 364);
            createSubCategoryUiDto.CreateSubCategoryListBox.TabIndex = 4;
            createSubCategoryUiDto.CreateSubCategoryListBox.Sorted = true;

            return createSubCategoryUiDto;
        }
    }
}
