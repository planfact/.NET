using System;
using System.Collections.Generic;
using System.Text;

namespace Request.Models
{
    /// <summary>
    /// Класс запроса на изменение операции
    /// </summary>
    public class OperationModificationRequest
    {
        /// <summary>
        /// Дата оплаты. Формат: "YYYY-MM-DD". Обязательное поле!
        /// </summary>
        public string OperationDate { get; set; }
        /// <summary>
        /// Id счёта. Обязательное поле!
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Назначение платежа операции. Зависит от настроек аккаута. Если поле не обязательное, то можно оставить пустые кавычки, в инном случае вставить в кавычки любое значение
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Признак подтверждения даты оплаты операции. true - подтвеждена, false - неподтверждена. Обязательное поле!
        /// </summary>
        public bool IsCommitted { get; set; }
        /// <summary>
        /// Список частей операции. Должен содержать не менее одного элемента.
        /// </summary>
        public List<OperationItemRequest> Items { get; set; }
    }
    /// <summary>
    /// Класс части операции.
    /// </summary>
    public class OperationItemRequest
    {
        /// <summary>
        /// Дата начисления. Формат: "YYYY-MM-DD". Обязательное поле!
        /// </summary>
        public string CalculationDate { get; set; }
        /// <summary>
        /// Признак подтверждения даты начисления операции. true - подтверждена, false - неподтверждена. Обязательное поле!
        /// </summary>
        public bool IsCalculationCommitted { get; set; }
        /// <summary>
        /// Id контрагента, если нет, то null.
        /// </summary>
        public object ContrAgentId { get; set; }
        /// <summary>
        /// Id статьи, если нет, то null.
        /// </summary>
        public object OperationCategoryId { get; set; }
        /// <summary>
        /// Id проекта к которому привязанна операция, если его нет, то null
        /// </summary>
        public object ProjectId { get; set; }
        /// <summary>
        /// Сумма этой части операции. Обязательное поле!
        /// </summary>
        public int Value { get; set; }
    }
}
