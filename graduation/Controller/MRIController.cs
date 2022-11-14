using graduation.Interface;
using graduation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace graduation.Controller
{
    [Route("api/mri")]
    [ApiController]
    public class MRIController : ControllerBase
    {
        private readonly IMRI_Results _mRI_Results;

        public MRIController(IMRI_Results mRI_Results)
        {
            _mRI_Results = mRI_Results;
        }

        [HttpPost]
        public async Task<ActionResult<MRI_Result>> Post(MRI_Result mRI_Result)
        {
            _mRI_Results.AddMRI_Result(mRI_Result);
            return await Task.FromResult(mRI_Result);
        }

        //return list of related results => the user results
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MRI_Result>>> Get(int id)
        {
            List<MRI_Result> results = _mRI_Results.GetMRI_Results(id);
            return await Task.FromResult(results);
        }

        /// <summary>
        /// return one result by it's id directly without using the user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/getoneres/{id}")]
        public async Task<ActionResult<MRI_Result>> GetResult(int id)
        {
            MRI_Result result = _mRI_Results.GetMRI_ResultById(id);
            return await Task.FromResult(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MRI_Result>> Put(int id,MRI_Result result)
        {
            if (id != result.ResultId)
            {
                return BadRequest();
            }
            try
            {
                _mRI_Results.UpdateMRI_Result(result);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return await Task.FromResult(result);
        }

        [HttpDelete]
        public async Task<ActionResult<MRI_Result>> Delete(int id)
        {
            var obj = _mRI_Results.DeleteMRI_Result(id);
            return await Task.FromResult(obj);
        }


    }
}
