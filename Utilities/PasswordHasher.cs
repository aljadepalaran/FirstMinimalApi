using System.Security.Cryptography;
using System.Text;

namespace FirstMinimalApi.Utilities;

/// <summary>
/// This is a simple and insecure way to hash a password.
/// </summary>
public class PWHasher
{
    public static string Hash(string input)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = SHA256.HashData(bytes);

        return Convert.ToHexString(hash);
    }

    public static bool ValidateHash(string hashedValue, string input)
    {
        return Hash(input) == hashedValue;
    }
}
