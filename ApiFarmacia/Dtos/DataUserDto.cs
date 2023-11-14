using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiFarmacia.Dtos;

public class DataUserDto 
{
    /* [JsonIgnore] <- Para ignorar una propiedad */ 
    public string Message { get; set; }
    public bool IsAuthenticated { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public List<string> Roles { get; set; }
    public string Token { get; set; }
    [JsonIgnore]
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; }
}
