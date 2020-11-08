using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VaultexDataApi.Models;

namespace VaultexDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaultexController : ControllerBase
    {
        private readonly VaultexDbContext _context;

        public VaultexController(VaultexDbContext context)
        {
            _context = context;
        }

        // GET: api/Vaultex
        [Route("/api/Vaultex/Employees")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetEmployees()
        {
            try
            {
                var result = await _context.Employees.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }

        }

        // GET: api/Vaultex
        [Route("/api/Vaultex/Organisations")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrganisationModel>>> GetOrganisation()
        {
            try
            {
                var result = await _context.Organisations.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                var result = StatusCode(StatusCodes.Status500InternalServerError, ex);
                return result;
            }
        }
    }
}
