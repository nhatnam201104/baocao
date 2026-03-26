using MyWinFormsApp.Models;

namespace MyWinFormsApp.Services;

public static class AddressService
{
    /// <summary>
    /// Normalizes street name by replacing abbreviations
    /// </summary>
    public static string NormalizeStreet(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        return input.Replace("NCV", "Nguyễn Cửu Vân");
    }

    /// <summary>
    /// Builds full address string from Address object
    /// </summary>
    public static string BuildFullAddress(Address addr)
    {
        return $"{addr.SoNha}, {addr.Duong}, {addr.Phuong}, {addr.Quan}, {addr.ThanhPho}";
    }
}