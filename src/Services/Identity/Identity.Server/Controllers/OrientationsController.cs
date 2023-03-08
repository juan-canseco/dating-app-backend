using AutoMapper;
using Identity.Server.Data;
using Identity.Server.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrientationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrientationsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orientations = await _context.Orientations.ToListAsync();
            var result = _mapper.Map<List<OrientationViewModel>>(orientations);
            return Ok(result);
        }

        [HttpGet("{orientationId}")]
        public async Task<IActionResult> GetById(Guid orientationId)
        {
            var orientation = await _context.Orientations.FindAsync(orientationId);
            if (orientation == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<OrientationViewModel>(orientation);
            return Ok(result);
        }
    }
}
