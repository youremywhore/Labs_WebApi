﻿using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LR_WEB_API.Controllers
{
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public OrderController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetOrder()
        {
           
            
                var order = _repository.Order.GetAllOrder(trackChanges:false);
                var orderDto = _mapper.Map<IEnumerable<OrderDto>>(order);
                return Ok(orderDto);
           
           
            
        }
    }
}
