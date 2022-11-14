using graduation.Interface;
using graduation.Model;

namespace graduation.Repository
{
    public class BannerRepo : IBanner
    {
        private readonly AppDbContext _context;

        public BannerRepo(AppDbContext context)
        {
            _context = context;
        }


        public void AddBanner(Banner banner)
        {
            try
            {
                _context.Banners.Add(banner);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Banner DeleteBanner(int id)
        {
            throw new NotImplementedException();
        }

        public Banner GetBannerById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Banner> GetBanners()
        {
            throw new NotImplementedException();
        }

        public void UpdateBanner(Banner banner)
        {
            throw new NotImplementedException();
        }
    }
}
