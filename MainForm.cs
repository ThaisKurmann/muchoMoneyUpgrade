using MuchMoneyUpgrade.Dtos;
using MuchMoneyUpgrade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMoneyUpgrade
{
    public class MainForm : Form
    {
        private readonly CreateCategoryUiService _createCategoryUiService;
        
        private CreateCategoryUiItems CreateCategoryUiItems;

        public MainForm(CreateCategoryUiService createCategoryUiService)
        {
            _createCategoryUiService = createCategoryUiService;
            CreateCategoryUiItems = _createCategoryUiService.CreateInitialFormItem();
                                    
            Text = "Much Money";
            ClientSize = new Size(824, 452);
            Controls.Add(CreateCategoryUiItems.CreateCategoryLabel);
            Controls.Add(CreateCategoryUiItems.CreateCategoryLabelName);
            Controls.Add(CreateCategoryUiItems.CreateCategoryTextBox);
            Controls.Add(CreateCategoryUiItems.CreateCategoryButton);
        }

        
    }
}
