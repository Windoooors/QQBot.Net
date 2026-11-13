using System.Text.Json.Serialization;
using QQBot.Net.Converters;

namespace QQBot.API.Gateway;

internal class Author
{
    [JsonPropertyName("id")]
    [GuidJsonConverter]
    public required Guid Id { get; init; }

    [JsonPropertyName("user_openid")]
    [GuidJsonConverter]
    public Guid? UserOpenId { get; init; }

    [JsonPropertyName("member_openid")]
    [GuidJsonConverter]
    public Guid? MemberOpenId { get; init; }

    [JsonPropertyName("union_openid")]
    [GuidJsonConverter]
    public Guid? UnionOpenId { get; init; }

    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonPropertyName("member_nickname")]
    public string? MemberNickname { get; init; }

    [JsonPropertyName("member_role")]
    public string? MemberRole { get; init; }

    [JsonPropertyName("avatar")]
    public string? Avatar { get; init; }
}
