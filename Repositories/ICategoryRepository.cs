using WebBanHangPhongDien.Models;

namespace WebBanHangPhongDien.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
