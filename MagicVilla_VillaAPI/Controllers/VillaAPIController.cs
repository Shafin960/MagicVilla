using MagicVilla_VillaAPI.DataStore;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villas;
        }

        [HttpGet("id")]

        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villas.FirstOrDefault(u => u.Id == id);
        }
    }
}
