using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Логин
        /// </summary>
        [MaxLength(256)]
        public string Login { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        [MaxLength(256)]
        public string UserName { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        [MaxLength(64)]
        public string Email { get; set; }
        /// <summary>
        /// Хэш пароля
        /// </summary>
        [MaxLength(256)]
        public string PasswordHash { get; set; }
        /// <summary>
        /// Соль
        /// </summary>
        [MaxLength(128)]
        public string Salt { get; set; }
        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Роль
        /// </summary>
        public RoleDao Role { get; set; }
        /// <summary>
        /// Активен?
        /// </summary>
        public bool IsActive { get; set; }
    }
}
