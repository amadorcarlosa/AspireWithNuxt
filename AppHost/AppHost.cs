var builder = DistributedApplication.CreateBuilder(args);
var webApi = builder.AddProject<Projects.WebApi>("WebApi");

builder.Build().Run();
