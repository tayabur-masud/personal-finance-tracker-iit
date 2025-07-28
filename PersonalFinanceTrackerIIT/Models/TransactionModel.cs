using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.Models;

public class TransactionModel : BaseModel
{
    public DateTime Date { get; set; }

    public string DateString
    {
        get
        {
            return Date.ToString(Constants.DateFormat);
        }
    }

    public decimal Amount { get; set; }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public string Description { get; set; }
}
