using System;

namespace API.DTOs.Account;

public sealed record AuthKeyExpiresAtDto
{
    public required DateTime? ExpiresAt { get; set; }
}
