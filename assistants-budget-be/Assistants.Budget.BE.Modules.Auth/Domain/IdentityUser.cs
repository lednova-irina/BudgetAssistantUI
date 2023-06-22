﻿using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Assistants.Budget.BE.Modules.Auth.Domain;

public record IdentityUser(
    string Id,
    string UserName,
    IEnumerable<string> Roles,
    [property: BsonRepresentation(BsonType.String)] IdentityUserStatus Status,
    Guid CreatedBy,
    DateTime CreatedAt
) { }

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum IdentityUserStatus
{
    Active,
    Inactive
}
