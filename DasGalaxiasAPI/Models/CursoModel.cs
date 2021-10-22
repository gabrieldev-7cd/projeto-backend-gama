using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DasGalaxiasAPI.Models
{
    public class CursoModel
    {
        [Key]
        public int CursoId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Titulo { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Professor { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string Capa { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Descricao { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string TituloAula1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LinkAula1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string DescricaoAula1 { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string TituloAula2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LinkAula2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string DescricaoAula2 { get; set; }

       [NotMapped]
       public IFormFile ImageFile { get; set; }
    }
}
