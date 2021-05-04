﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNVSSV.DATA.Interfaces;
using QLNVSSV.DATA.Repository;
using QLNVSSV.Models.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVSSV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseAPIController<T> : ControllerBase
    {
        protected readonly IBaseRepository<T> _baseRepository;
        public BaseAPIController(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _baseRepository.GetById(id);
            return Ok(data);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _baseRepository.Get();
            return Ok(data);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public IActionResult Create([FromForm] IFormFile mill)
        {
            return Ok("aaa");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _baseRepository.Delete(id);
            return Ok(result);
        }

        [HttpPut]
         public  IActionResult Update([FromBody]T Entity)
         {

            var serviceResponse= _baseRepository.Update(Entity);
            return Ok(serviceResponse);
         }

        
        [HttpGet("GetCount")]
        public IActionResult GetCountRecord()
        {
            var serviceResponse = _baseRepository.GetCountRecord();
            return Ok(serviceResponse);
        }
        
    }
}