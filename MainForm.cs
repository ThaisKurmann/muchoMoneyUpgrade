using MuchMoneyUpgrade.Dtos;
using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Services;
using System.Data.Entity;

namespace MuchMoneyUpgrade
{
    public class MainForm : Form
    {
        private readonly CreateCategoryUiService _createCategoryUiService;
        private readonly CategoryService _categoryService;
        
        private CreateCategoryUiItems CreateCategoryUiItems;

        public MainForm(CreateCategoryUiService createCategoryUiService, CategoryService categoryService)
        {
            _createCategoryUiService = createCategoryUiService;
            _categoryService = categoryService;
            
            CreateCategoryUiItems = _createCategoryUiService.CreateInitialFormItem();

                                              
            Text = "Much Money";
            ClientSize = new Size(824, 452);
            Controls.Add(CreateCategoryUiItems.CreateCategoryLabel);
            Controls.Add(CreateCategoryUiItems.CreateCategoryLabelName);
            Controls.Add(CreateCategoryUiItems.CreateCategoryTextBox);
            Controls.Add(CreateCategoryUiItems.CreateCategoryButton);

            CreateCategoryUiItems.CreateCategoryButton.Click += ButtonCreateCategory_Click;
        }

        public void ButtonCreateCategory_Click(object sender, EventArgs e)
        {
            string nameOfNewCategory = CreateCategoryUiItems.CreateCategoryTextBox.Text;

            //CHAMAR SERVICE AQUI
            _categoryService.CreateCategory(nameOfNewCategory);

            //var newCategory = new Category { Name = nameOfNewCategory };

            //var dataBase = new DatabaseContext();
            //dataBase.Categories.Add(newCategory);
            //dataBase.SaveChanges();
            //dataBase.Dispose();

            MessageBox.Show("nome da categoria: " + nameOfNewCategory);

        }
    }
}
