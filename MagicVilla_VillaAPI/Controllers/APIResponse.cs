using MagicVilla_VillaAPI.Models.Dto;
using System.Net;

namespace MagicVilla_VillaAPI.Controllers
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; internal set; }
        public bool IsSuccess { get; internal set; }
        public object ErrorMessages { get; internal set; }
        public LoginResponseDTO Result { get; internal set; }
    }
}