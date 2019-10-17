namespace Boolean_Extended
{
    public static class Program
    {
        /// <summary>
        /// Метод реализует определения является ссылка null или нет.
        /// </summary>
        /// <param name="obj">
        /// Объект
        /// </param>
        /// <returns>
        /// Логический литерал (true или false)
        /// </returns>
        public static bool isNull(this object obj)
        {
            if (obj is null) return true;
            return false;
        }
    }
}
