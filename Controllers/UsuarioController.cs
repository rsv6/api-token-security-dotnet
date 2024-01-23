using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTokenSecurity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTokenSecurity.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController: ControllerBase
{
    private readonly DbHubContext _contextDbHub;

    public UsuarioController(DbHubContext contextDbhub)
    {
        _contextDbHub = contextDbhub;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsuarios()
    {
        var usuarios = await _contextDbHub.Usuario.ToArrayAsync();
        return Ok(usuarios);
    }
}
