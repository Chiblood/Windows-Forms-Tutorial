using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Windows_Forms_Tutorial;

public class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}