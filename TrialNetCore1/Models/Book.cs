using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialNetCore1.Models
{
    public class Book
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Deskripsi { get; set; }
        public string Gambar { get; set; }
        public bool Status { get; set; }
    }
}
