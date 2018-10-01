
namespace DataService.DTOs.Responses
{
    public interface IBasicResponse
    {
        string ReturnCode { get; set; }
        string Message { get; set; }
        string Description { get; set; }
    }
}
