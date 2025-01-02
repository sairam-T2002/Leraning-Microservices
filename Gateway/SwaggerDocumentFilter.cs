using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Gateway;

public class SwaggerDocumentFilter : IDocumentFilter
{
    public void Apply( OpenApiDocument swaggerDoc, DocumentFilterContext context )
    {
        var paths = new OpenApiPaths();

        // Booking Service
        paths.Add("/gateway/booking", new OpenApiPathItem
        {
            Operations = new Dictionary<OperationType, OpenApiOperation>
            {
                [OperationType.Get] = new OpenApiOperation
                {
                    Tags = new List<OpenApiTag> { new OpenApiTag { Name = "Booking Service" } },
                    Summary = "Get booking information",
                    Responses = new OpenApiResponses
                    {
                        ["200"] = new OpenApiResponse { Description = "Successful response" }
                    }
                }
            }
        });

        // Cancellation Service
        paths.Add("/gateway/cancellation", new OpenApiPathItem
        {
            Operations = new Dictionary<OperationType, OpenApiOperation>
            {
                [OperationType.Get] = new OpenApiOperation
                {
                    Tags = new List<OpenApiTag> { new OpenApiTag { Name = "Cancellation Service" } },
                    Summary = "Get cancellation information",
                    Responses = new OpenApiResponses
                    {
                        ["200"] = new OpenApiResponse { Description = "Successful response" }
                    }
                }
            }
        });

        swaggerDoc.Paths = paths;
    }
}