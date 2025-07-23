namespace PersonalFinanceTrackerIIT.Models;

public class BaseModel
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? LastModifiedOn { get; set; }
}
