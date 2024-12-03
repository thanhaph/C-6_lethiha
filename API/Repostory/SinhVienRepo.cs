using API.Context;
using Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repostory
{
    public class SinhVienRepo : ISinhVienRepo
    {
        private readonly DBContext _db;
        public SinhVienRepo(DBContext ha)
        {
            _db = ha;
        }
        public async Task<List<SinhVien>> GetAll()
        {
            return await _db.sinhViens.ToListAsync();
        }
        public async Task<SinhVien> GetById(int id)
        {
            return await _db.sinhViens.FindAsync(id);
        }
        public async Task Create(SinhVien sv)
        {
            _db.sinhViens.Add(sv);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var remo = await GetById(id);
            _db.sinhViens.Remove(remo);
            await _db.SaveChangesAsync();
        }


        public async Task Update(SinhVien sv)
        {
            _db.Entry(sv).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
