using Core.Entities;

namespace Core.Specifications;

public class ProductSpecParams : PagingParams
{

    public int? BrandId { get; set; }
    public int? TypeId { get; set; }

    private List<ProductType> _types = [];
    public List<ProductType> Types
    {
        get => _types;
        set
        {
            _types = value.ToList();
        }
    }

    public string? Sort { get; set; }

    private string? _search;
    public string Search
    {
        get => _search ?? "";
        set => _search = value.ToLower();
    }


}
