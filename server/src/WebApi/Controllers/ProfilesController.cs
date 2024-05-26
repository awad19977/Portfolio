﻿using Application.DTOs;
using Application.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApi.Controllers
{
    [EnableCors("Policy1")]
    [Route("api/profiles")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IProfileService _ProfileService;
        public ProfilesController(IProfileService ProfileService)
        {
            _ProfileService = ProfileService;
        }
        [EnableCors("Policy1")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _ProfileService.Get();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Put([FromBody] ProfileDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var result = await _ProfileService.Update(dto);
                if (!result) return BadRequest();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
               
    }
}
