using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300064.Models;
using System.Collections.Generic;

namespace tpmodul10_103022300064.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muhammad Endihan", Nim = "103022300064" },
            new Mahasiswa { Nama = "Muhammad Ihsan Romdhon", Nim = "103022330150" },
            new Mahasiswa { Nama = "Mohammad Ilham Firdaus", Nim = "103022300002" },
            new Mahasiswa { Nama = "Muthi'ah Az Zahra", Nim = "103022330117" },
            new Mahasiswa { Nama = "Triana Julianingsih", Nim = "103022300053" },
            new Mahasiswa { Nama = "Syahdan Mansiz Kurniawan", Nim = "103022300079" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult<IEnumerable<Mahasiswa>> AddMahasiswa(Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return daftarMahasiswa;
        }

        [HttpDelete("{index}")]
        public ActionResult<IEnumerable<Mahasiswa>> DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
