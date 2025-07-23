namespace PersonalFinanceTrackerIIT.Models;

public class CategoryModel : BaseModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public int TypeId { get; set; }

    public string TypeName { get; set; }
}
