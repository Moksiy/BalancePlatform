﻿using AutoMapper;
using BalancePlatform.Backend.Domain.Entities.Users;
using BalancePlatform.Backend.Domain.Ninject;
using BalancePlatform.Backend.Domain.Services.Interfaces.BalancePlatformInterfaces;
using BalancePlatform.Backend.WebApi.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.WebApi.Controllers
{
    /// <summary>
    /// OData Web Api контроллер работы с пользователями
    /// </summary>
    [HttpBearerAuthorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private readonly IUserService _userService;

        private readonly IUserForWebService _userForWebService;

        private readonly IMapper _mapper;

        /// <summary>
        /// OData Web Api контроллер работы с товарами
        /// </summary>
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;

            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            _userService = kernel.Get<IUserService>();
            _userForWebService = kernel.Get<IUserForWebService>();

            _mapper = kernel.Get<IMapper>();
        }

        [HttpGet, UseQuery]
        public ActionResult Get()
        {
            try
            {
                var userQueryable = _userForWebService.GetQueryable();
                return Ok(userQueryable);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CreateUser")]
        public void Post(NewUser user)
        {
            _userService.Create(user);
        }
    }
}
