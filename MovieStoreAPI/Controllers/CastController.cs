using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CastController : ControllerBase
    {
        private readonly ICastServiceAsync castServiceAsync;
        public CastController(ICastServiceAsync _castServiceAsync)
        {
            this.castServiceAsync = _castServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await castServiceAsync.GetAllCastAsync());

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await castServiceAsync.GetCastAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create( [FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.AddCastAsync(model));
        }

        [HttpDelete]
        [Route("remove/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await castServiceAsync.DeleteCastAsync(id));
        }

        [Route("top")]
        public async Task<IActionResult> GetTop10()
        { 
            return Ok(await castServiceAsync.GetLatest10Async());
        }
        [HttpPut]
        [Route("edit/{id}")]
        public async Task<IActionResult> UpdateAsync( int id, [FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.UpdateCastAsync(model));
        }
    }
}
