using System.Text.Json;

namespace DotNet9Demo;
internal static class RespectNullableAnnotationsDemo
{
    public static void RespectNullableAnnotationsDotNet9()
    {
        JsonSerializerOptions options = new()
        {
            RespectNullableAnnotations = true
        };

        var userDto = JsonSerializer.Serialize(
            new UserResponseDto(null!), 
            options);


        Console.WriteLine(userDto);
    }

    private record UserResponseDto(string UserName);
}
