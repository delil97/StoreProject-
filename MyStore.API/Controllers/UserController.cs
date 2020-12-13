﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.API.Resources;
using MyStore.Core.Models;
using MyStore.Core.Services;

namespace MyStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService musicService, IMapper mapper)
        {
            this._userService = musicService;
            this._mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserResources>> GetUserById(int id)
        {
            var user = await _userService.GetUserWithAdress(id);

            if(user is null)
            {
                return NoContent();
            }

            var automappedUser = _mapper.Map<User, UserResources>(user);

            return Ok(automappedUser);
        }

    }
}