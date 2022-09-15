using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAClient
{
    public partial class mainForm : Form
    {
        private taService.taService ws = new taService.taService();
        private int newPlans = 0;

        public mainForm()
        {
            InitializeComponent();
            cmbReport.SelectedIndex = 0;
            cmbYear.DataSource = ws.GetYearList();
            cmbYear.DisplayMember = "listYear";
            cmbYear.ValueMember = "listYear";
            //
            bsPayments.DataSource = ws.dbPaymentList();
            bsRetails.DataSource = ws.dbRetailList();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int year = (int)cmbYear.SelectedValue;
            var frm = new reportForm(year, cmbReport.SelectedIndex);
            frm.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tcIndex = tabControl1.SelectedIndex;
            switch (tcIndex)
            {
                case 0:
                    cmbYear.DataSource = ws.GetYearList();
                    break;
                case 1:
                    bsProducts.DataSource = ws.dbProductList();
                    bsSales.DataSource = ws.dbSaleList();
                    break;
                case 2:
                    bsCategories.DataSource = ws.dbCategoryList();
                    bsUnits.DataSource = ws.dbUnitList();
                    bsProducts.DataSource = ws.dbProductList();
                    break;
                case 3:
                    bsPlans.DataSource = ws.dbPlanList();
                    newPlans = 0;
                    break;
                case 4:
                    bsCategories.DataSource = ws.dbCategoryList();
                    break;
                case 5:
                    bsUnits.DataSource = ws.dbUnitList();
                    break;
                default:
                    break;
            }

        }

        private void btnSalesNew_Click(object sender, EventArgs e)
        {
            dgvSales.Enabled = false;
            ctrSalesId.Text = Convert.ToString(-1);
            ctrSalesDates.Value = DateTime.Now;
            ctrSalesProduct.SelectedValue = 1;
            ctrSalesQuantity.Value = 1;
            ctrSalesSumma.Value = (decimal)0.01;
            ctrSalesPayment.SelectedValue = 1;
            ctrSalesRetail.SelectedValue = 1;
        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            if (ctrSalesId.Text == "-1")
            {
                ws.dbSaleInsert(ctrSalesDates.Value, (int)ctrSalesProduct.SelectedValue, (int)ctrSalesQuantity.Value, (decimal)ctrSalesSumma.Value, (int)ctrSalesPayment.SelectedValue, (int)ctrSalesRetail.SelectedValue);
            }
            else
            {
                ws.dbSaleUpdate(ctrSalesDates.Value, (int)ctrSalesProduct.SelectedValue, (int)ctrSalesQuantity.Value, (decimal)ctrSalesSumma.Value, (int)ctrSalesPayment.SelectedValue, (int)ctrSalesRetail.SelectedValue, Convert.ToInt32(ctrSalesId.Text));
            }
            bsSales.DataSource = ws.dbSaleList();
            dgvSales.Enabled = true;
        }

        private void btnSalesCancel_Click(object sender, EventArgs e)
        {
            dgvSales.Enabled = true;
            bsSales.DataSource = ws.dbSaleList();
        }

        private void btnSalesDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                ws.dbSaleDelete(Convert.ToInt32(ctrSalesId.Text));
                bsSales.DataSource = ws.dbSaleList();
                dgvSales.Enabled = true;
            }
        }

        private void btnProductsNew_Click(object sender, EventArgs e)
        {
            dgvProducts.Enabled = false;
            ctrProductId.Text = "-1";
            ctrProductName.Text = " ";
            ctrProductCategory.SelectedValue = 1;
            ctrProductUnit.SelectedValue = 1;
        }

        private void btnProductsSave_Click(object sender, EventArgs e)
        {
            if (ctrProductId.Text == "-1")
            {
                ws.dbProductInsert(ctrProductName.Text, (int)ctrProductCategory.SelectedValue, (int)ctrProductUnit.SelectedValue);
            }
            else
            {
                ws.dbProductUpdate(ctrProductName.Text, (int)ctrProductCategory.SelectedValue, (int)ctrProductUnit.SelectedValue, Convert.ToInt32(ctrProductId.Text));
            }
            bsProducts.DataSource = ws.dbProductList();
            dgvProducts.Enabled = true;
        }

        private void btnProductsCancel_Click(object sender, EventArgs e)
        {
            bsProducts.DataSource = ws.dbProductList();
            dgvProducts.Enabled = true;
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                ws.dbProductDelete(Convert.ToInt32(ctrProductId.Text));
                bsProducts.DataSource = ws.dbProductList();
                dgvProducts.Enabled = true;
            }
        }

        private void btnPlansNew_Click(object sender, EventArgs e)
        {
            dgvPlans.Enabled = false;
            ctrPlansYear.Value = 2015;
            ctrPlansMonth.Value = 1;
            ctrPlansSumma.Value = (decimal)10000;
            newPlans = -1;
        }

        private void btnPlansSave_Click(object sender, EventArgs e)
        {
            if (newPlans == -1)
            {
                ws.dbPlanInsert(Convert.ToDecimal(ctrPlansSumma.Value), (int)ctrPlansYear.Value, (int)ctrPlansMonth.Value);
            }
            else
            {
                ws.dbPlanUpdate(Convert.ToDecimal(ctrPlansSumma.Value), (int)ctrPlansYear.Value, (int)ctrPlansMonth.Value);
            }
            bsPlans.DataSource = ws.dbPlanList();
            dgvPlans.Enabled = true;
            newPlans = 0;
        }

        private void btnPlansCancel_Click(object sender, EventArgs e)
        {
            bsPlans.DataSource = ws.dbPlanList();
            dgvPlans.Enabled = true;
            newPlans = 0;
        }

        private void btnPlansDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                ws.dbPlanDelete((int)ctrPlansYear.Value, (int)ctrPlansMonth.Value);
                bsPlans.DataSource = ws.dbPlanList();
                dgvPlans.Enabled = true;
                newPlans = 0;
            }
        }

        private void btnCategoriesNew_Click(object sender, EventArgs e)
        {
            dgvCategories.Enabled = false;
            ctrCategoriesId.Text = "-1";
            ctrCategoriesName.Text = " ";
        }

        private void btnCategoriesSave_Click(object sender, EventArgs e)
        {
            if (ctrCategoriesId.Text == "-1")
            {
                ws.dbCategoryInsert(ctrCategoriesName.Text);
            }
            else
            {
                ws.dbCategoryUpdate(ctrCategoriesName.Text, Convert.ToInt32(ctrCategoriesId.Text));
            }
            bsCategories.DataSource = ws.dbCategoryList();
            dgvCategories.Enabled = true;
        }

        private void btnCategoriesCancel_Click(object sender, EventArgs e)
        {
            bsCategories.DataSource = ws.dbCategoryList();
            dgvCategories.Enabled = true;
        }

        private void btnCategoriesDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                ws.dbCategoryDelete(Convert.ToInt32(ctrCategoriesId.Text));
                bsCategories.DataSource = ws.dbCategoryList();
                dgvCategories.Enabled = true;
            }
        }

        private void btnUnitsNew_Click(object sender, EventArgs e)
        {
            dgvUnits.Enabled = false;
            ctrUnitsId.Text = "-1";
            ctrUnitsName.Text = " ";
        }

        private void btnUnitsSave_Click(object sender, EventArgs e)
        {
            if (ctrUnitsId.Text == "-1")
            {
                ws.dbUnitInsert(ctrUnitsName.Text);
            }
            else
            {
                ws.dbUnitUpdate(ctrUnitsName.Text, Convert.ToInt32(ctrUnitsId.Text));
            }
            bsUnits.DataSource = ws.dbUnitList();
            dgvUnits.Enabled = true;
        }

        private void btnUnitsCancel_Click(object sender, EventArgs e)
        {
            bsUnits.DataSource = ws.dbUnitList();
            dgvUnits.Enabled = true;
        }

        private void btnUnitsDelete_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                ws.dbUnitDelete(Convert.ToInt32(ctrUnitsId.Text));
                bsUnits.DataSource = ws.dbUnitList();
                dgvUnits.Enabled = true;
            }
        }

        private bool ConfirmDelete()
        {
            if (MessageBox.Show(
                    "Вы действительно хотите удалить элемент?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes) return true;
            else return false;
        }


    }
}
