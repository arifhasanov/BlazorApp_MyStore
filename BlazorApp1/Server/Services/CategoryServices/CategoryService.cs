using BlazorApp1.Shared;

namespace BlazorApp1.Server.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Category>> GetCategoryAsync(int categoryId)
        {
            var response = new ServiceResponse<Category>();
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null)
            {
                response.Success = false;
                response.Message = "The category does not exist";
            }
            else
            {
                response.Data = category;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }

        
    }
}
