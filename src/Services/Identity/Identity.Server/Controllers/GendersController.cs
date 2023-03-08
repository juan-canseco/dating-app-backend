using AutoMapper;
using Identity.Server.Data;
using Identity.Server.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GendersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var genders = await _context.Genders.ToListAsync();
            var response = _mapper.Map<List<GenderViewModel>>(genders);
            return Ok(response);
        }

        [HttpGet("{genderId}")]
        public async Task<IActionResult> GetAll(int genderId)
        {
            var gender = await _context.Genders.FindAsync(genderId);
            if (gender == null)
            {
                return NotFound();
            }
            var response = _mapper.Map<GenderViewModel>(gender);
            return Ok(response);
        }
    }
}
