using AutoMapper;
using BalancePlatform.Backend.Domain.Ninject;
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
    /// OData Web Api контроллер работы с группами
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly ILogger<GroupsController> _logger;

        //private readonly IShopService _shopService;

        private readonly IMapper _mapper;

        /// <summary>
        /// OData Web Api контроллер работы с магазином
        /// </summary>
        public GroupsController(ILogger<GroupsController> logger)
        {
            _logger = logger;

            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            //_shopService = kernel.Get<IShopService>();

            _mapper = kernel.Get<IMapper>();
        }


    }
}
