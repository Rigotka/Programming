using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статическую генерацию ID.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// ID
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// Генерирует и возвращает ID.
        /// </summary>
        /// <returns>ID.</returns>
        public static int GetNextID()
        {
            _id++;
            return _id;
        }
    }
}


