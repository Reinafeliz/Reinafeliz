using Core.Entities.MasterAggregate;

namespace Core.Specifications
{
    public class CountrySpecification : BaseSpecification<Countries>
    {
        public CountrySpecification(CountrySpecParams countrySpec) : base(x =>
        (string.IsNullOrEmpty(countrySpec.Search) || x.Name.ToLower().Contains(countrySpec.Search)))
        {
            AddOrderBy(x => x.Name);
            ApplyPaging(countrySpec.PageSize * (countrySpec.PageIndex - 1), countrySpec.PageSize);

            if (!string.IsNullOrEmpty(countrySpec.Sort))
            {
                switch (countrySpec.Sort)
                {
                    case "active":
                        AddOrderBy(p => p.IsActive == true);
                        break;
                    case "deactive":
                        AddOrderByDescending(p => p.IsActive == false);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }
        public CountrySpecification(int id) : base(x => x.Id == id)
        { }
    }
}