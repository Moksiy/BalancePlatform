
namespace BalancePlatform.Backend.Infrastructure.Entites
{
    /// <summary>
    /// Валюта пользователя
    /// </summary>
    public class CurrencyDao : EntityWithIdDao<int>
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public UserDao User { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        public int Value { get; set; }
    }
}
