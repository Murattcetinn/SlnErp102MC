using Microsoft.EntityFrameworkCore;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository.Stocks.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Data.Repository.Stocks.Products
{
    public class ProductEntryRepository : Repository<ProductEntry>, IProductEntryRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public ProductEntryRepository(SlnDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<ProductEntry>> DistinctListByCompany()
        {
            IEnumerable<ProductEntry> test = await SlnDbContext.ProductEntries.Include(x=>x.Company)
                .GroupBy(x =>new
                {
                x.CompanyId,
                x.InvoiceNumber,
                x.EntryDate,
                x.Company.Name
                })
                .Select(g => g.First())
                .ToListAsync();
            return test;
           
        }

        public async Task<IEnumerable<ProductEntry>> GetProductByInvoiceNumber(string ivno)
        {
            var ProList = await SlnDbContext.ProductEntries.Include("Company").Include(t=>t.Product).Where(x => x.InvoiceNumber == ivno).ToListAsync();
            return ProList;
        }
    }
}
