using MuchMoneyUpgrade.Dtos;
using MuchMoneyUpgrade.Interfaces;
using MuchMoneyUpgrade.Models;
using MuchMoneyUpgrade.Ui;

namespace MuchMoneyUpgrade
{
    public class MainForm : Form
    {
        private readonly ICreateCategoryUiService createCategoryUiService;
        private readonly ICreateSubCategoryUiService createSubCategoryUiService;
        private readonly ICategoryService categoryService;
        private readonly ISubCategoryService subCategoryService;
        
        private Dtos.CreateCategoryUiItems createCategoryUiItems;
        private Ui.CreateSubCategoryUiItems createSubCategoryUiItems;

        public MainForm(ICreateCategoryUiService createCategoryUiService, 
            ICategoryService categoryService, 
            ICreateSubCategoryUiService createSubCategoryUiService, 
            ISubCategoryService subCategoryService)
        {
            this.createCategoryUiService = createCategoryUiService;
            this.createSubCategoryUiService = createSubCategoryUiService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;

            InitializeComponent();
        }

        public void InitializeComponent()
        {
            Text = "Much Money";
            ClientSize = new Size(1100, 452);

            CreateCategoryForm();
            CreateSubCategoryForm();
        }

        public void CreateCategoryForm()
        {
            createCategoryUiItems = this.createCategoryUiService.CreateInitialFormItem();

            Controls.Add(createCategoryUiItems.CreateCategoryLabel);
            Controls.Add(createCategoryUiItems.CreateCategoryLabelName);
            Controls.Add(createCategoryUiItems.CreateCategoryTextBox);
            Controls.Add(createCategoryUiItems.CreateCategoryButton);
            Controls.Add(createCategoryUiItems.CreateCategoryListBox);

            createCategoryUiItems.CreateCategoryButton.Click += ButtonCreateCategory;

            var categories = this.categoryService.GetAllCategories();

            createCategoryUiItems.CreateCategoryListBox.Items.AddRange(categories.ToArray());
            createCategoryUiItems.CreateCategoryListBox.SelectedIndexChanged += SelectedCategoryShowYoursSubCategoriesOnListBox;
        }

        public void SelectedCategoryShowYoursSubCategoriesOnListBox(object sender, EventArgs e)
        {
            string nameOfCategorySelected = createCategoryUiItems.CreateCategoryListBox.Text;

            var category = categoryService.GetCategoryByName(nameOfCategorySelected);

            createSubCategoryUiItems.CreateSubCategoryListBox.Items.Clear();

            foreach(var subCategory in category.SubCategories)
            {
                createSubCategoryUiItems.CreateSubCategoryListBox.Items.Add(subCategory.Name);
            }
        }

        public void ButtonCreateCategory(object sender, EventArgs e)
        {
            string newCategoryOnTextBox = createCategoryUiItems.CreateCategoryTextBox.Text;
            
            var category = categoryService.CreateCategory(newCategoryOnTextBox);

            if (category != null)
            {
                createCategoryUiItems.CreateCategoryListBox.Items.Add(category.Name);
            }

            createCategoryUiItems.CreateCategoryTextBox.ResetText();
        }

        public void CreateSubCategoryForm()
        {
            createSubCategoryUiItems = this.createSubCategoryUiService.CreateInitialFormItem();

            Controls.Add(createSubCategoryUiItems.CreateSubCategoryLabel);
            Controls.Add(createSubCategoryUiItems.CreateSubCategoryLabelName);
            Controls.Add(createSubCategoryUiItems.CreateSubCategoryTextBox);
            Controls.Add(createSubCategoryUiItems.CreateSubCategoryButton);
            Controls.Add(createSubCategoryUiItems.CreateSubCategoryListBox);

            createSubCategoryUiItems.CreateSubCategoryButton.Click += ButtonCreateSubCategory;

        }

        public void ButtonCreateSubCategory(object sender, EventArgs e)
        {
            string newSubCategoryOnTextBox = createSubCategoryUiItems.CreateSubCategoryTextBox.Text;

            string selectedCategory = createCategoryUiItems.CreateCategoryListBox.Text;
    
            var subCategory = subCategoryService.CreateSubCategory(selectedCategory,newSubCategoryOnTextBox);

            var subCategories = subCategoryService.GetAllSubCategories(subCategory, selectedCategory);

            createSubCategoryUiItems.CreateSubCategoryListBox.Items.Clear();

            foreach (var newSubCategory in subCategories) 
            {
                createSubCategoryUiItems.CreateSubCategoryListBox.Items.Add(newSubCategory.Name);
            }

            createSubCategoryUiItems.CreateSubCategoryTextBox.ResetText();

        }
    }
}
