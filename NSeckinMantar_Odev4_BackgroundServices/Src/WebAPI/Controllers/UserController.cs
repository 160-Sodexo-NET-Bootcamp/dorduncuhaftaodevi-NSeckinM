using ApplicationCore.Entities;
using ApplicationCore.Interfaces.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //You can use the HttpGet request to take all User list
        //Request URL = https://localhost:44341/api/v1/Users
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWork.Users.GetAllAsync());
        }

        //You can use this HttpGet request with id  to get just one User object.
        //Request URL = https://localhost:44341/api/v1/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            User user = await _unitOfWork.Users.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<GetUserDTO>(user);

            return await Task.FromResult(Ok(result));
        }


    }
}
