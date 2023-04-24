namespace webapi.Interfaces
{
    public interface ICVParserService
    {
        Task<(string FirstName, string LastName)> ExtractNameFromCVAsync(string cvUrl);
    }
}
