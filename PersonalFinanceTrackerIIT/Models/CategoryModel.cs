namespace PersonalFinanceTrackerIIT.Models;

public class CategoryModel
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? LastModifiedOn { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
}
