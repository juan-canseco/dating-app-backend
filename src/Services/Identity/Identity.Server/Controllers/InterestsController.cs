using AutoMapper;
using Identity.Server.Data;
using Identity.Server.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InterestsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var interests = await _context.Interests.ToListAsync();
            var response = _mapper.Map<List<InterestViewModel>>(interests);
            return Ok(response);
        }

        [HttpGet("{interestid}")]
        public async Task<IActionResult> GetById(Guid interestId)
        {
            var interest = await _context.Interests.FindAsync(interestId);
            if (interest == null)
            {
                return NotFound();
            }
            var response = _mapper.Map<InterestViewModel>(interest);
            return Ok(response);
        }
    }
}
