namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статическую генерацию ID.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        private static int _customersID = 0;

        private static int _itemsID = 0;

        private static int _ordersID = 0;

        /// <summary>
        /// Генерирует и возвращает ID.
        /// </summary>
        /// <returns>ID.</returns>
        public static int GetNextCustomersID()
        {
            _customersID++;
            return _customersID;
        }

        public static int GetNextItemsID()
        {
            _itemsID++;
            return _itemsID;
        }

        public static int GetNextOrdersID()
        {
            _ordersID++;
            return _ordersID;
        }
    }
}


