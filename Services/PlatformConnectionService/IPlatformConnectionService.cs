using MediaTrackerAuthenticationService.Dtos.PlatformConnection;
using MediaTrackerAuthenticationService.Models.AuthDB;
using MediaTrackerAuthenticationService.Models.Utils;

namespace MediaTrackerAuthenticationService.Services.PlatformConnectionService
{
    public interface IPlatformConnectionService
    {
        Task<ServiceResponse<GetPlatformConnectionDto>> GetPlatformConnectionByUserId(int userID);
        Task<ServiceResponse<GetPlatformConnectionDto>> AddPlatformConnection(
            AddPlatformConnectionDto newPlatformConnection
        );
        Task<ServiceResponse<GetPlatformConnectionDto>> UpdatePlatformConnection(
            UpdatePlatformConnectionDto updatedPlatformConnection
        );
        ServiceResponse<string> GetYoutube();
        Task<ServiceResponse<string>> GetRedirectYoutube(string? code, string? error, string? state);
        Task<ServiceResponse<GetPlatformConnectionDto>> YoutubeGetValidPlatformConnection(GetPlatformConnectionDto platformConnection);

        
    }
}
