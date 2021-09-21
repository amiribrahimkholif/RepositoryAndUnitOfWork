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
    public class BooksController : ControllerBase
    {
        private readonly IbaseRepository<Book> _bookRepository;

        public BooksController(IbaseRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_bookRepository.GetById(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_bookRepository.GetAll());
        }
    }
}
