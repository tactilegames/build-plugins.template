using NSubstitute;
using TactilePipeline;

namespace Sandbox;

public class SandboxPipelineServiceFactory
{
    public IPipelineService Create()
    {
        var pipelineService = Substitute.For<IPipelineService>();
        
        ConfigureStub(pipelineService);

        return pipelineService;
    }

    private static void ConfigureStub(IPipelineService pipelineService)
    {
        // Configure to write in console when using LogInfo.
        pipelineService
            .When(service => service.LogInfo(Arg.Any<string>()))
            .Do(callInfo => Console.WriteLine(callInfo.Arg<string>()));
    }
}