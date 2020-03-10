using System;
using System.Collections.Generic;
using System.Text;

namespace Request.Models
{
    /// <summary>
    /// Данные счёта для добавления
    /// </summary>
    public class AccountCreationRequest
    {
        /// <summary>
        /// Название счёта. Обязательное поле!
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Полное название счёта, если его нет, то ставим пустые ковычки
        /// </summary>
        public string LongTitle { get; set; }
        /// <summary>
        /// Коментарий, если его нет, то null.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Id юрлица. Обязательное поле!
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// Тип счёта. Cash - если наличные, Card - если карточка. Обязательное поле!
        /// </summary>
        public string AccountType { get; set;}
        /// <summary>
        /// Номер счёта, если его нет, то null.
        /// </summary>
        public string AccountAcct { get; set; }
        /// <summary>
        /// БИК, если его нет, то null. Только для безналичного счёта.
        /// </summary>
        public string AccountBik { get; set; }
        /// <summary>
        /// Банк, если нет, то null. Только для безналичного счёта.
        /// </summary>
        public string AccountBank { get; set; }
        /// <summary>
        /// Код валюты. Коды см. https://apidoc.planfact.io/
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Статус счёта. true - активный, false - архивный. Обязательное поле!
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Начальный остаток на счету. Обязательное поле!
        /// </summary>
        public decimal Remainder { get; set; }
        /// <summary>
        /// Дата начального остатка на счету. Формат: "YYYY-MM-DD". Обязательное поле!
        /// </summary>
        public string RemainderDate { get; set; }
    }
}
