using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IbaseRepository<Author> _authorRepository;

        public AuthorsController(IbaseRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_authorRepository.GetById(id));
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_authorRepository.GetAll());
        }
    }
}
