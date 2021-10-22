using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DasGalaxiasAPI.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace DasGalaxiasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CursoController(CursoDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/Curso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoModel>>> GetCurso()
        {
            return await _context.Curso.ToListAsync();
        }

        // GET: api/Curso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursoModel>> GetCursoModel(int id)
        {
            var cursoModel = await _context.Curso.FindAsync(id);

            if (cursoModel == null)
            {
                return NotFound();
            }

            return cursoModel;
        }

        // PUT: api/Curso/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutCursoModel(int id, CursoModel cursoModel)
        {
            if (id != cursoModel.CursoId)
            {
                return BadRequest();
            }

            _context.Entry(cursoModel).State = EntityState.Modified;

            try
            {
             
                cursoModel.Capa = await SaveImage(cursoModel.ImageFile);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Curso
        [HttpPost]
        public async Task<ActionResult<CursoModel>> PostCursoModel([FromForm]CursoModel cursoModel)
        {

            cursoModel.Capa = await SaveImage(cursoModel.ImageFile);
            _context.Curso.Add(cursoModel);
            await _context.SaveChangesAsync();

            return StatusCode(201);
        }

        // DELETE: api/Curso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursoModel(int id)
        {
            var cursoModel = await _context.Curso.FindAsync(id);
            if (cursoModel == null)
            {
                return NotFound();
            }

            _context.Curso.Remove(cursoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        //=================================================================================================================
        [HttpPost]
        [Route("/api/Curso/Edita/{id}")]
        public async Task<IActionResult> AtualizaCursoModel(int id,[FromForm] CursoModel cursoModel)
        {
            if (id != cursoModel.CursoId)
            {
                return BadRequest();
            }

            _context.Entry(cursoModel).State = EntityState.Modified;

            try
            {

                cursoModel.Capa = await SaveImage(cursoModel.ImageFile);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }


            //=================================================================================================================

            private bool CursoModelExists(int id)
        {
            return _context.Curso.Any(e => e.CursoId == id);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            
            String imageName = "void.jpg";
            if (imageFile != null)
            {
                imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
                imageName = imageName + DateTime.Now.ToString("yymmssff") + Path.GetExtension(imageFile.FileName);

                var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                }
            }
            return imageName;
        }
    }
}

