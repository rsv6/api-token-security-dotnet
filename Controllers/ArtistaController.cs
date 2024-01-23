using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTokenSecurity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTokenSecurity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistaController: ControllerBase
    {
        private readonly DbScreenSoundContext _context;

        public ArtistaController(DbScreenSoundContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetArtistas()
        {
            var artistas = await _context.Artistas.ToArrayAsync();
            return Ok(artistas);
        }
    }
}