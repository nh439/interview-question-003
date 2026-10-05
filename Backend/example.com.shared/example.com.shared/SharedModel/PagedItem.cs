namespace example.com.shared.SharedModel;

public class PagedItem<T> 
{
    public IEnumerable<T> Items { get; init; }
    public int TotalItems { get; init; }
    public int LastPage { get; init; }
    public bool HasData => Items.Any();
}