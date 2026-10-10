using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class UserRoleDTO
{
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
    [JsonPropertyName("roleId")]
    public decimal? RoleId { get; set; }
    [JsonPropertyName("userId")]
    public decimal? UserId { get; set; }

    public static UserRoleDTO ConvertFrom(UserRole userRole)
    {
        return new UserRoleDTO
        {
            Id = userRole.Id,
            RoleId = userRole.RoldId, // La entity tiene el typo "RoldId", el DTO usa "RoleId"
            UserId = userRole.UserId
        };
    }

    public static UserRole ConvertTo(UserRoleDTO dto)
    {
        return new UserRole
        {
            Id = dto.Id,
            RoldId = dto.RoleId,
            UserId = dto.UserId
        };
    }
}