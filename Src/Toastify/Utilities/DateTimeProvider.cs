using System;

namespace Toastify.Utilities
{
    internal class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetLocalDateTime()
        {
            return DateTime.Now;
        }

        public DateTime GetUtcDateTime()
        {
            return DateTime.UtcNow;
        }
    }
}