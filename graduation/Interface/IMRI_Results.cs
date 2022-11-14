using graduation.Model;
using Microsoft.AspNetCore.Mvc;

namespace graduation.Interface
{
    public interface IMRI_Results
    {
        
        public List<MRI_Result> GetMRI_Results(int userId);
        public MRI_Result GetMRI_ResultById(int id);
        public Task<ActionResult<MRI_Result>> AddMRI_Result(MRI_Result mRI_Result);
        public void UpdateMRI_Result(MRI_Result mRI_Result);
        public MRI_Result DeleteMRI_Result(int id);
    }
}
