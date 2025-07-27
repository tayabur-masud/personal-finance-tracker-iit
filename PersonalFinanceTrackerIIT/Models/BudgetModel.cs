using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.Models;

public class BudgetModel : BaseModel
{
    public string MonthId { get; set; }

    public string MonthName {
        get
        {
            var year = Convert.ToInt32(MonthId.Substring(2, 4));
            var month = Convert.ToInt32(MonthId.Substring(0, 2));
            return new DateTime(year, month, 1).ToString(Constants.MonthNameFormat);
        }
    }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public decimal Amount { get; set; }
}
