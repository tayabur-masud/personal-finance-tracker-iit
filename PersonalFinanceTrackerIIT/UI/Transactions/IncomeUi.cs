using PersonalFinanceTrackerIIT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceTrackerIIT.UI.Transactions
{
    public partial class IncomeUi : Form
    {
        private readonly ICategoryService _categoryService;

        public IncomeUi(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private void IncomeUi_Load(object sender, EventArgs e)
        {

        }
    }
}
