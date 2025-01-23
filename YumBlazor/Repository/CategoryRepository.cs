using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Category> Create(Category obj)
        {
            _db.Category.Add(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<Category> Update(Category obj)
        {
            var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                _db.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }

        public async Task<bool> Delete(int categoryId)
        {
            var obj = await _db.Category.FirstOrDefaultAsync(u => u.Id == categoryId);
            if (obj == null)
            {
                return false;
            }
            _db.Category.Remove(obj);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            var category = await _db.Category.FirstOrDefaultAsync(u => u.Id == categoryId);
            if(category == null) {

                return new Category();
            }
            return category;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _db.Category.ToListAsync();
        }
    }
}
