using System;

namespace Toastify.Utilities
{
    public interface IDateTimeProvider
    {
        DateTime GetLocalDateTime();
        DateTime GetUtcDateTime();
    }
}