using BalancePlatform.Backend.Domain.Entities.Base;
using BalancePlatform.Backend.Domain.Entities.Roles;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BalancePlatform.Backend.Domain.Entities.Auth
{
    /// <summary>
    /// Результат аутентификации для веб интерфейса
    /// </summary>
    [DataContract]
    [Serializable]
    public class AuthResultModel : BaseResult
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [Display(Name = "Id пользователя")]
        public int Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }
        /// <summary>
        /// Роль пользователя
        /// </summary>
        [Display(Name = "Роль пользователя")]
        public Role Role { get; set; }
        /// <summary>
        /// Токен
        /// </summary>
        [Display(Name = "Токен")]
        public string Token { get; set; }
    }
}
