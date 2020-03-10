namespace Request
{
    //Класс ответа
    public class Response<T>
    {
        /// <summary>
        /// Данные которые возвращаются
        /// </summary>
        public T Data { get; }
        /// <summary>
        /// Успешный ли был наш запрос
        /// </summary>
        public bool IsSuccess { get; }
        /// <summary>
        /// Сообщение ошибки
        /// </summary>
        public string ErrorMessage { get; }
        /// <summary>
        /// Код ошибки
        /// </summary>
        public int ErrorCode { get; }
    }
}