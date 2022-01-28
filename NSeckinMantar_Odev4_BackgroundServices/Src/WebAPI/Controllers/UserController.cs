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

        //You can use this HttpPost request to create new User's object.
        //Request URL =  https://localhost:44341/api/v1/Users
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO UserCreateDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data.");
            }
            //Mapping

            var user = _mapper.Map<User>(UserCreateDto);

            await _unitOfWork.Users.AddAsync(user);
            _unitOfWork.Complete();

            return CreatedAtAction("GetUser", new { Id = user.Id }, UserCreateDto);
        }

    }
}
