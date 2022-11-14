using graduation.Model;

namespace graduation.Interface
{
    public interface IBanner
    {
        public List<Banner> GetBanners();
        public Banner GetBannerById(int id);
        public void AddBanner(Banner banner);
        public void UpdateBanner(Banner banner);    
        public Banner DeleteBanner(int id);
        
    }
}
