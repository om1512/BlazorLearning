using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> Create(Category obj);
        public Task<Category> Update(Category obj);
        public Task<bool> Delete(int categoryId);
        public Task<Category> GetCategory(int categoryId);
        public Task<IEnumerable<Category>> GetCategories();

    }
}
