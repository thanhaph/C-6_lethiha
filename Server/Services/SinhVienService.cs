using Data;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Server.Services
{
    public class SinhVienService : ISinhVienService
    {
        private readonly HttpClient _httpClient;

        public SinhVienService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Create(SinhVien sv)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:7026/api/SinhVien", sv);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync("https://localhost:7026/api/SinhVien/" + id);
        }

        public async Task<List<SinhVien>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<SinhVien>>("https://localhost:7026/api/SinhVien");
        }

        public async Task<SinhVien> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<SinhVien>("https://localhost:7026/api/SinhVien/" + id);
        }

        public async Task Update(SinhVien sv)
        {
            await _httpClient.PutAsJsonAsync("https://localhost:7026/api/SinhVien", sv);
        }
    }
}
