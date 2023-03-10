using AutoMapper;
using MagicVilla_API.Data;
using MagicVilla_API.Models;
using MagicVilla_API.Models.DTO;
using MagicVilla_API.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;

namespace MagicVilla_API.Controllers
{
    [Route("api/VillaNumberAPI")]
    [ApiController]
    public class VillaNumberAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _mapper = mapper;
            _dbVillaNumber = dbVillaNumber;
            this._response = new();
            _dbVilla = dbVilla;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillaNumbers()
        {
            try
            {
                IEnumerable<VillaNumber> villaNumberList = await _dbVillaNumber.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaNumberDTO>>(villaNumberList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetVillaNumber")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villaNumber = await _dbVillaNumber.GetAsync(u => u.VillaNo == id);

                if (villaNumber == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

    // <--Post Method -->

        [HttpPost]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCrateDTO createDTO)
        {
                try
                {
                    if (await _dbVillaNumber.GetAsync(u => u.VillaNo == createDTO.VillaNo) != null)
                    {
                        ModelState.AddModelError("CustomError! ", "VillaNumber already Exits!!");
                        return BadRequest(ModelState);
                    }

                    if (await _dbVilla.GetAsync(u => u.Id == createDTO.VillaID) == null)
                    {
                        ModelState.AddModelError("CustomError", "Villa ID is Invalid!");
                        return BadRequest(ModelState);
                    }

                if (createDTO == null)
                    {
                        return BadRequest(createDTO);
                    }

                    VillaNumber villaNumber = _mapper.Map<VillaNumber>(createDTO);

                    await _dbVillaNumber.CreateAsync(villaNumber);
                    _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                    _response.StatusCode = HttpStatusCode.Created;
                    return CreatedAtRoute("GetVilla", new { id = villaNumber.VillaNo }, _response);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return _response;

        }

        // <--Delete Method -->

        [HttpDelete("{id:int}", Name = "DeleteVillaNumber")]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumber(int id)
        {
                try
                {
                    if (id == 0)
                    {
                        return BadRequest();
                    }
                    var villaNumber = await _dbVillaNumber.GetAsync(u => u.VillaNo == id);
                    if (villaNumber == null)
                    {
                        return NotFound();
                    }
                    await _dbVillaNumber.RemoveAsync(villaNumber);
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = true;
                    return Ok(_response);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return _response;
           
        }

        // <--Put Method -->

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpPut("{id:int}", Name = "UpdateVillaNumber")]
        public async Task<ActionResult<APIResponse>> UpdateVillaNumber(int id, [FromBody] VillaNumberUpdateDTO updateDTO)
        {
                try
                {
                    if (updateDTO == null || id != updateDTO.VillaNo)
                    {
                        return BadRequest();
                    }

                    if (await _dbVilla.GetAsync(u => u.Id == updateDTO.VillaID) == null)
                    {
                        ModelState.AddModelError("CustomError", "Villa ID is Invalid!");
                        return BadRequest(ModelState);
                    }

                VillaNumber model = _mapper.Map<VillaNumber>(updateDTO);

                    await _dbVillaNumber.UpdateAsync(model);
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = true;
                    return Ok(_response);
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return _response;
        }

    }

}

