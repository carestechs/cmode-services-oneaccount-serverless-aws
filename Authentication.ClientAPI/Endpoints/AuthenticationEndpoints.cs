using Microsoft.AspNetCore.Http.HttpResults;

namespace Authentication.ClientAPI.Endpoints;

internal static class AuthenticationEndpoints
{
    public static async Task<Ok<string>> LogIn()
    {
        return TypedResults.Ok("");
    }

    public static async Task<Ok<string>> LogOut()
    {
        return TypedResults.Ok("");
    }
}
