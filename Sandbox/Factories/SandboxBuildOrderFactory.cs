using TactilePipeline;
using TactilePipeline.Builders;

namespace Sandbox;

public class SandboxBuildOrderFactory
{
    public BuildOrder Create()
    {
        var rootPath = PathUtilities.GetRootPath();
        
        var buildParameter = new BuildParametersBuilder()
            .WithProject(new Project("ProjectName", "android", "inhouse", "1.0.0"))
            .Build();

        var buildOrder = new BuildOrderBuilder()
            .WithBuildParameters(buildParameter)
            .WithProjectPath(rootPath)
            .WithArtifactPath(Path.Combine(rootPath, "_artifacts"))
            .Build();

        return buildOrder;
    }
}