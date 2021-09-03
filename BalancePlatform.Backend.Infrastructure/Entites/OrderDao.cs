using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class OrderDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Ид юзера
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ид товара
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Дата и время
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
