using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Бейджи пользователя
    /// </summary>
    public class UserBadges : EntityWithIdDao<int>
    {
        /// <summary>
        /// Ид юзера
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Ид бейджа
        /// </summary>
        public int BadgeId { get; set; }
    }
}
