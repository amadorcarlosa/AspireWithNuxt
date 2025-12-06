var builder = DistributedApplication.CreateBuilder(args);

var webApi = builder.AddProject<Projects.WebApi>("WebApi");





var webApp = builder.AddJavaScriptApp("WebApp", "../WebApp")
    .WithPnpm()
    .WithRunScript("dev")
    .WithHttpEndpoint(port: 4000)
    .WithExternalHttpEndpoints()
    .WithReference(webApi)
    .WaitFor(webApi)
    .WithEnvironment("API_BASE_URL", webApi.GetEndpoint("https"));

builder.Build().Run();