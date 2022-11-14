using graduation.Interface;
using graduation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace graduation.Repository
{
    public class MRI_ResultsRepo : IMRI_Results
    {
        private readonly AppDbContext _context;

        public MRI_ResultsRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<MRI_Result>> AddMRI_Result(MRI_Result mRI_Result)
        {
            if(mRI_Result == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                try
                {
                    User user = await _context.Users.FindAsync(mRI_Result.UserId);
                    var resObj = new MRI_Result
                    {
                        User = user,
                        UserId = mRI_Result.UserId,
                        BrainMriUrl = mRI_Result.BrainMriUrl,
                        Result = mRI_Result.Result
                    };
                    _context.MRI_Results.Add(resObj);
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
            return await Task.FromResult(mRI_Result);
        }

        public MRI_Result DeleteMRI_Result(int id)
        {
            try
            {
                MRI_Result result = _context.MRI_Results.Find(id);

                if (result != null)
                {
                    _context.Remove(result);
                    _context.SaveChanges();
                    return result;
                }
                else
                {
                    throw new ArgumentNullException();
                }

            }
            catch
            {
                throw;
            }
        }

        public MRI_Result GetMRI_ResultById(int id)
        {
            try
            {
                MRI_Result result = _context.MRI_Results.Find(id);
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //returen the results related the current user
        public List<MRI_Result> GetMRI_Results(int userId)
        {
            try
            {
                return _context.MRI_Results.Where(r => r.UserId == userId).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateMRI_Result(MRI_Result mRI_Result)
        {
            try
            {
                _context.Entry(mRI_Result).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
