using AutoMapper;
using Backend_Mapanimal.AppContext;
using Backend_Mapanimal.Dtos;
using Backend_Mapanimal.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Mapanimal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly MapanimalDbContext _context;
        private readonly IMapper mapper;

        public PetController(
            MapanimalDbContext _context,
            IMapper mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<PetDTO>>> Get()// Get general
        {
            var pet = await _context.Pets.ToListAsync();
            return mapper.Map<List<PetDTO>>(pet);
            
        }

        [HttpGet("{Id:int}")] // Get by Id
        public async Task<ActionResult<PetDTO>> Get(int Id)
        {
            var pet = await _context.Pets.FirstOrDefaultAsync(x => x.Id == Id);
            if (pet == null)
            {
                return NotFound();
            }

            return mapper.Map<PetDTO>(pet);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreatePetDTO createPetDTO)
        {
            var pet = mapper.Map<Pet>(createPetDTO);
            _context.Add(pet);
            await _context.SaveChangesAsync(); 
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Pet>> Put(int id, [FromBody] CreatePetDTO createPetDTO)
        {
            var pet = await _context.Pets.FirstOrDefaultAsync(x => x.Id == id);
            if (pet == null)
            {
                return NotFound();
            }

            pet = mapper.Map(createPetDTO, pet);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Pet>> Delete(int id)
        {
            var exist = await _context.Pets.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            _context.Remove(new Pet() { SetId = id });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
