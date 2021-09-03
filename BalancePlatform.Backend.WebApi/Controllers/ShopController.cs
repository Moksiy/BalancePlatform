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
    /// OData Web Api контроллер работы с магазином
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ILogger<ShopController> _logger;

        //private readonly IShopService _shopService;

        private readonly IMapper _mapper;

        /// <summary>
        /// OData Web Api контроллер работы с магазином
        /// </summary>
        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;

            IKernel kernel = new StandardKernel(new BalancePlatformModule());

            //_shopService = kernel.Get<IShopService>();

            _mapper = kernel.Get<IMapper>();
        }


    }
}
