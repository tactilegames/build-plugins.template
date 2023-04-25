using NSubstitute;
using TactilePipeline;

namespace Sandbox;

public class SandboxBuildResultFactory
{
    public IBuildResult Create()
    {
        var buildResult = Substitute.For<IBuildResult>();
        
        ConfigureStub(buildResult);

        return buildResult;
    }

    private static void ConfigureStub(IBuildResult buildResult)
    {
        // Configure the stub to return the calls you will use
    }
}