using Khaart.Modules.Identity.Application.Commands.RegisterUser;
using Khaart.SharedKernel.Presentation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Khaart.Modules.Identity.Presentation;

internal sealed class RegisterUserEndpoint
    : IEndpoint
{
    public void Map(IEndpointRouteBuilder app)
    {
        app.MapPost("/users", RegisterUserAsync);
    }

    private static async Task<IResult> RegisterUserAsync(
        ISender sender)
    {
        var command = new RegisterUserCommand();

        var result = await sender.Send(command);

        return Results.Ok(result.Value);
    }
}
