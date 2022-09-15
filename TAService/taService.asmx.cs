using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace TAService
{
    /// <summary>
    /// Сводное описание для taService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class taService : System.Web.Services.WebService
    {
        ////////////////////////////////////////////////
        // Работа с данными

        // Категории
        [WebMethod]
        public DataTable dbCategoryList()
        {
            dbDataSetTableAdapters.categoriesTableAdapter adCategory = new dbDataSetTableAdapters.categoriesTableAdapter();
            return adCategory.GetData();
        }

        [WebMethod]
        public int dbCategoryUpdate(string name, int id)
        {
            dbDataSetTableAdapters.categoriesTableAdapter ad = new dbDataSetTableAdapters.categoriesTableAdapter();
            return ad.Update(name, id);
        }

        [WebMethod]
        public int dbCategoryInsert(string name)
        {
            dbDataSetTableAdapters.categoriesTableAdapter ad = new dbDataSetTableAdapters.categoriesTableAdapter();
            return ad.Insert(name);
        }

        [WebMethod]
        public int dbCategoryDelete(int id)
        {
            dbDataSetTableAdapters.categoriesTableAdapter ad = new dbDataSetTableAdapters.categoriesTableAdapter();
            dbDataSetTableAdapters.productsTableAdapter adProduct = new dbDataSetTableAdapters.productsTableAdapter();
            if (adProduct.CountByCategory(id) > 0) return 0;
            else return ad.Delete(id);
        }

        // Единицы измерения
        [WebMethod]
        public DataTable dbUnitList()
        {
            dbDataSetTableAdapters.unitsTableAdapter ad = new dbDataSetTableAdapters.unitsTableAdapter();
            return ad.GetData();
        }

        [WebMethod]
        public int dbUnitUpdate(string name, int id)
        {
            dbDataSetTableAdapters.unitsTableAdapter ad = new dbDataSetTableAdapters.unitsTableAdapter();
            return ad.Update(name, id);
        }

        [WebMethod]
        public int dbUnitInsert(string name)
        {
            dbDataSetTableAdapters.unitsTableAdapter ad = new dbDataSetTableAdapters.unitsTableAdapter();
            return ad.Insert(name);
        }

        [WebMethod]
        public int dbUnitDelete(int id)
        {
            dbDataSetTableAdapters.unitsTableAdapter ad = new dbDataSetTableAdapters.unitsTableAdapter();
            dbDataSetTableAdapters.productsTableAdapter adProduct = new dbDataSetTableAdapters.productsTableAdapter();
            if (adProduct.CountByUnit(id) > 0) return 0;
            else return ad.Delete(id);
        }

        // План
        [WebMethod]
        public DataTable dbPlanList()
        {
            dbDataSetTableAdapters.plansTableAdapter ad = new dbDataSetTableAdapters.plansTableAdapter();
            return ad.GetData();
        }

        [WebMethod]
        public int dbPlanUpdate(Decimal summa, int year, int month)
        {
            dbDataSetTableAdapters.plansTableAdapter ad = new dbDataSetTableAdapters.plansTableAdapter();
            try { return ad.Update(summa, year, month); }
            catch { return 0; }
        }

        [WebMethod]
        public int dbPlanInsert(Decimal summa, int year, int month)
        {
            dbDataSetTableAdapters.plansTableAdapter ad = new dbDataSetTableAdapters.plansTableAdapter();
            try { return ad.Insert(year, month, summa); }
            catch { return 0; }
        }

        [WebMethod]
        public int dbPlanDelete(int year, int month)
        {
            dbDataSetTableAdapters.plansTableAdapter ad = new dbDataSetTableAdapters.plansTableAdapter();
            return ad.Delete(year, month);
        }

        // Товары
        [WebMethod]
        public DataTable dbProductList()
        {
            dbDataSetTableAdapters.productsTableAdapter ad = new dbDataSetTableAdapters.productsTableAdapter();
            return ad.GetData();
        }

        [WebMethod]
        public int dbProductUpdate(string name, int category, int unit, int id)
        {
            dbDataSetTableAdapters.productsTableAdapter ad = new dbDataSetTableAdapters.productsTableAdapter();
            return ad.Update(name, category, unit, id);
        }

        [WebMethod]
        public int dbProductInsert(string name, int category, int unit)
        {
            dbDataSetTableAdapters.productsTableAdapter ad = new dbDataSetTableAdapters.productsTableAdapter();
            return ad.Insert(name, category, unit);
        }

        [WebMethod]
        public int dbProductDelete(int id)
        {
            dbDataSetTableAdapters.productsTableAdapter ad = new dbDataSetTableAdapters.productsTableAdapter();
            dbDataSetTableAdapters.salesTableAdapter adSales = new dbDataSetTableAdapters.salesTableAdapter();
            if (adSales.CountByProduct(id) > 0) return 0;
            else return ad.Delete(id);
        }

        // Продажи
        [WebMethod]
        public DataTable dbSaleList()
        {
            dbDataSetTableAdapters.salesTableAdapter ad = new dbDataSetTableAdapters.salesTableAdapter();
            return ad.GetData();
        }

        [WebMethod]
        public int dbSaleUpdate(DateTime dates, int product, int quantity, decimal summa, int payment, int retail, int id)
        {
            dbDataSetTableAdapters.salesTableAdapter ad = new dbDataSetTableAdapters.salesTableAdapter();
            return ad.Update(dates, product, quantity, summa, payment, retail, id);
        }

        [WebMethod]
        public int dbSaleInsert(DateTime dates, int product, int quantity, decimal summa, int payment, int retail)
        {
            dbDataSetTableAdapters.salesTableAdapter ad = new dbDataSetTableAdapters.salesTableAdapter();
            return ad.Insert(dates, product, quantity, summa, payment, retail);
        }

        [WebMethod]
        public int dbSaleDelete(int id)
        {
            dbDataSetTableAdapters.salesTableAdapter ad = new dbDataSetTableAdapters.salesTableAdapter();
            return ad.Delete(id);
        }

        // Формы оплаты
        [WebMethod]
        public DataTable dbPaymentList()
        {
            dbDataSetTableAdapters.paymentsTableAdapter ad = new dbDataSetTableAdapters.paymentsTableAdapter();
            return ad.GetData();
        }

        // Формы торговли
        [WebMethod]
        public DataTable dbRetailList()
        {
            dbDataSetTableAdapters.retailsTableAdapter ad = new dbDataSetTableAdapters.retailsTableAdapter();
            return ad.GetData();
        }
        
        ////////////////////////////////////////////////
        // Формирование отчетов

        [WebMethod]
        public DataTable GetYearList()
        {
            taDataSetTableAdapters.YearListTableAdapter ad = new taDataSetTableAdapters.YearListTableAdapter();
            return ad.GetData();
        }

        [WebMethod]
        public DataTable GetSalePlan(int year)
        {
            taDataSetTableAdapters.SalePlanTableAdapter ad = new taDataSetTableAdapters.SalePlanTableAdapter();
            return ad.GetData(year);
        }

        [WebMethod]
        public DataTable GetTrade(int year)
        {
            taDataSetTableAdapters.TradeTableAdapter ad = new taDataSetTableAdapters.TradeTableAdapter();
            DataTable dt = ad.GetData(year);
            Decimal[] indexPrice = CalcIndexPrice(year);
            for (int i = 0; i < 12; i++)
            {
                dt.Rows[i]["indexPrice"] = Math.Round(indexPrice[i], 2);
                if (i == 0)
                {
                    dt.Rows[i]["baseSumma"] = dt.Rows[i]["factSumma"];
                    dt.Rows[i]["tr"] = 100;
                }
                else
                {
                    dt.Rows[i]["baseSumma"] = Math.Round(Convert.ToDecimal(dt.Rows[i]["factSumma"]) / Convert.ToDecimal(dt.Rows[i]["indexPrice"]), 2);
                    dt.Rows[i]["tr"] = Math.Round(100 * Convert.ToDecimal(dt.Rows[i]["baseSumma"]) / Convert.ToDecimal(dt.Rows[i - 1]["baseSumma"]), 2);
                }
                dt.Rows[i]["tp"] = Convert.ToDecimal(dt.Rows[i]["tr"]) - 100;
            }
            dt.AcceptChanges();
            return dt;
        }

        [WebMethod]
        public DataTable GetTradePayment(int year)
        {
            taDataSetTableAdapters.PaymentSalesYearTableAdapter ad = new taDataSetTableAdapters.PaymentSalesYearTableAdapter();
            return ad.GetData(year);
        }

        [WebMethod]
        public DataTable GetTradeRetail(int year)
        {
            taDataSetTableAdapters.RetailSalesYearTableAdapter ad = new taDataSetTableAdapters.RetailSalesYearTableAdapter();
            return ad.GetData(year);
        }

        [WebMethod]
        public DataTable GetTradeStructure(int year)
        {
            taDataSetTableAdapters.CategorySalesYearTableAdapter ad = new taDataSetTableAdapters.CategorySalesYearTableAdapter();
            DataTable dt = ad.GetData(year);
            Decimal yearSum = (Decimal)ad.GetYearSum(year);
            foreach (taDataSet.CategorySalesYearRow row in dt.Rows)
            {
                row.weight = Math.Round(100 * row.summaSum / yearSum, 2);
            }
            dt.AcceptChanges();
            return dt;
        }

        [WebMethod]
        public DataTable GetTradeRhytm(int year)
        {
            DataTable dt = new taDataSet.TradeRhytmDataTable();
            DataTable dtTrade = GetTrade(year);
            foreach (taDataSet.TradeRow rowTrade1 in dtTrade.Rows)
            {
                Double sum = 0;
                foreach (taDataSet.TradeRow rowTrade2 in dtTrade.Rows)
                {
                    sum += Math.Pow((Double)(rowTrade2.baseSumma - rowTrade1.baseSumma), 2);
                }
                Decimal sko = (Decimal)Math.Sqrt(sum / 12);
                Decimal kvar = 100 * sko / rowTrade1.baseSumma;
                DataRow row = dt.NewRow();
                row["dateYear"] = rowTrade1.dateYear;
                row["dateMonth"] = rowTrade1.dateMonth;
                row["baseSumma"] = Math.Round(rowTrade1.baseSumma, 2);
                row["sko"] = Math.Round(sko, 2);
                row["kvar"] = Math.Round(kvar, 2);
                dt.Rows.Add(row);
            }
            dt.AcceptChanges();
            return dt;
        }

        [WebMethod]
        public DataTable GetTradeSeason(int year)
        {
            DataTable dt = new taDataSet.TradeSeasonDataTable();
            DataTable dtTrade = GetTrade(year);
            for (int quarter = 0; quarter <= 3; quarter++)
            {
                DataRow row = dt.NewRow();
                row["dateYear"] = year;
                row["dateQuarter"] = quarter + 1;
                row["baseSumma"] = 0;
                for (int cnt = 0; cnt <=2 ; cnt++)
                {
                    int indTrade = quarter * 3 + cnt;
                    row["baseSumma"] = (Decimal)row["baseSumma"] + (Decimal)dtTrade.Rows[indTrade]["baseSumma"];
                }
                dt.Rows.Add(row);
            }
            dt.AcceptChanges();
            return dt;
        }

        [WebMethod]
        public DataTable GetAvgPrice(int year)
        {
            taDataSetTableAdapters.AvgPriceYearTableAdapter ad = new taDataSetTableAdapters.AvgPriceYearTableAdapter();
            return ad.GetData(year);
        }

        private Decimal[] CalcIndexPrice(int year)
        {
            Decimal[] arr = new Decimal[12];
            for (int cnt = 0; cnt < 12; cnt++)
            {
                int month = cnt + 1;
                taDataSetTableAdapters.FactSalesMonthTableAdapter ad = new taDataSetTableAdapters.FactSalesMonthTableAdapter();
                DataTable dt = ad.GetDataByYM(year, month);
                Decimal p1q1 = 0;
                Decimal p0q1 = 0;
                foreach (taDataSet.FactSalesMonthRow row in dt.Rows)
                {
                    try
                    {
                        Decimal avgPrice = (Decimal)ad.GetPriceByYMP(year, 1, row.product);
                        p1q1 += row.summaSum;
                        p0q1 += row.quantitySum * avgPrice;
                    }
                    catch { }
                }
                arr[cnt] = p1q1 / p0q1;
            }
            return arr;
        }

    }
}
