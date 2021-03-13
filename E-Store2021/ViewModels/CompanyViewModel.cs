using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class CompanyViewModel
    {
        public virtual IEnumerable<CountryModel> Countries { get; set; }

        public virtual IEnumerable<CompanyModel> Companies { get; set; } = new List<CompanyModel>();

        public virtual IEnumerable<CategoryModel> Categories { get; set; }

        public virtual IEnumerable<SubCategoryModel> SubCategories { get; set; }

        public virtual IEnumerable<ProductModel> Products { get; internal set; }

        public virtual PaginatedList<ProductModel> ProductsPagination { get; set; }
    }
}