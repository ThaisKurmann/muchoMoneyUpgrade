﻿using MuchMoneyUpgrade.Dtos;
using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;

namespace MuchMoneyUpgrade
{
    public class MainForm : Form
    {
        private readonly ICreateCategoryUiService _createCategoryUiService;
        private readonly ICategoryService _categoryService;
        
        private CreateCategoryUiItems CreateCategoryUiItems;

        public MainForm(ICreateCategoryUiService createCategoryUiService, ICategoryService categoryService)
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
            Controls.Add(CreateCategoryUiItems.CreateCategoryListBox);

            CreateCategoryUiItems.CreateCategoryButton.Click += ButtonCreateCategory_Click;

            var categories = _categoryService.GetAllCategories();

            CreateCategoryUiItems.CreateCategoryListBox.Items.AddRange(categories.ToArray());
        }

        public void ButtonCreateCategory_Click(object sender, EventArgs e)
        {
            string nameOfNewCategory = CreateCategoryUiItems.CreateCategoryTextBox.Text;
            
            var newCategory = _categoryService.CreateCategory(nameOfNewCategory);

            if (newCategory != null)
            {
                CreateCategoryUiItems.CreateCategoryListBox.Items.Add(newCategory.Name);
            }

            CreateCategoryUiItems.CreateCategoryTextBox.ResetText();
        }

    }
}
