using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EArsivPortal.Services.Repositories;
using EArsivPortal.Models;
using YourNamespace.Models;
using Microsoft.AspNetCore.Authorization;

namespace EArsivPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BelgelerApiController : ControllerBase
    {
        private readonly IGenericRepository<Belge> _belgeRepository;

        public BelgelerApiController(IGenericRepository<Belge> belgeRepository)
        {
            _belgeRepository = belgeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var belgeler = await _belgeRepository.GetAllAsync();
            return Ok(belgeler);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var belge = await _belgeRepository.GetByIdAsync(id);
            if (belge == null)
            {
                return NotFound();
            }
            return Ok(belge);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Belge belge)
        {
            if (belge == null)
            {
                return BadRequest();
            }

            await _belgeRepository.AddAsync(belge);
            return CreatedAtAction(nameof(GetById), new { id = belge.BelgeNumarasi }, belge);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Belge belge)
        {
            if (id != belge.BelgeNumarasi)
            {
                return BadRequest();
            }

            var existingBelge = await _belgeRepository.GetByIdAsync(id);
            if (existingBelge == null)
            {
                return NotFound();
            }

            await _belgeRepository.UpdateAsync(belge);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var belge = await _belgeRepository.GetByIdAsync(id);
            if (belge == null)
            {
                return NotFound();
            }

            await _belgeRepository.RemoveAsync(belge);
            return NoContent();
        }
    }
}
