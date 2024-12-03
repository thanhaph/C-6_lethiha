using API.Repostory;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienRepo _sinhVienRepo;

        public SinhVienController(ISinhVienRepo sinhVienRepo)
        {
            _sinhVienRepo = sinhVienRepo; // Gán giá trị
        }
        [HttpGet]
        public async Task<List<SinhVien>> GetAll()
        {
            return await _sinhVienRepo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<SinhVien> GetById(int id)
        {
            return await _sinhVienRepo.GetById(id);
        }
        [HttpPost]
        public async Task Create(SinhVien sv)
        {
            await _sinhVienRepo.Create(sv);
        }
        [HttpPut]
        public async Task Update(SinhVien sv)
        {
            await _sinhVienRepo.Update(sv);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _sinhVienRepo.Delete(id);
        }
    }
}
