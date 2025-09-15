using System;

namespace Password
{
    public class UuidUtils
    {
        /// <summary>
        /// Generates a valid UUID version 4 string.
        /// </summary>
        /// <returns>A string representing a UUID v4.</returns>
        public static string GenerateUuidV4()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
