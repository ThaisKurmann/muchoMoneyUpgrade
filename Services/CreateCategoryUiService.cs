using MuchMoneyUpgrade.Dtos;
using MuchMoneyUpgrade.Interfaces;

namespace MuchMoneyUpgrade.Services
{
    public class CreateCategoryUiService : ICreateCategoryUiService
    {

        public CreateCategoryUiService()
        {
        }
        public CreateCategoryUiItems CreateInitialFormItem()
        {

            var createCategoryUiDto = new CreateCategoryUiItems();

            //Label Category
            createCategoryUiDto.CreateCategoryLabel.AutoSize = true;
            createCategoryUiDto.CreateCategoryLabel.Location = new Point(60, 58);
            createCategoryUiDto.CreateCategoryLabel.Name = "category";
            createCategoryUiDto.CreateCategoryLabel.Size = new Size(87, 15);
            createCategoryUiDto.CreateCategoryLabel.TabIndex = 0;
            createCategoryUiDto.CreateCategoryLabel.Text = "Create Category";

            //Label nameCategory
            createCategoryUiDto.CreateCategoryLabelName.AutoSize = true;
            createCategoryUiDto.CreateCategoryLabelName.Location = new Point(64, 93);
            createCategoryUiDto.CreateCategoryLabelName.Name = "nameCategory";
            createCategoryUiDto.CreateCategoryLabelName.Size = new Size(38, 15);
            createCategoryUiDto.CreateCategoryLabelName.Text = "Name";

            //textBox Create Category
            createCategoryUiDto.CreateCategoryTextBox.Location = new Point(108, 85);
            createCategoryUiDto.CreateCategoryTextBox.Name = "textBoxCreateCategory";
            createCategoryUiDto.CreateCategoryTextBox.Size = new Size(100, 23);
            createCategoryUiDto.CreateCategoryTextBox.TabIndex = 3;
            

            //Button Create Category
            createCategoryUiDto.CreateCategoryButton.Location = new Point(60, 137);
            createCategoryUiDto.CreateCategoryButton.Name = "buttonCreateCategory";
            createCategoryUiDto.CreateCategoryButton.Size = new Size(75, 23);
            createCategoryUiDto.CreateCategoryButton.TabIndex = 2;
            createCategoryUiDto.CreateCategoryButton.Text = "create";
            createCategoryUiDto.CreateCategoryButton.UseVisualStyleBackColor = true;
            createCategoryUiDto.CreateCategoryButton.Tag = createCategoryUiDto.CreateCategoryTextBox;



           return createCategoryUiDto;
        }
    }
}
