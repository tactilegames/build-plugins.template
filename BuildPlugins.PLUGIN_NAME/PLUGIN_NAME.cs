using TactilePipeline;

namespace BuildPlugins.PLUGIN_NAME;

public class PLUGIN_NAME : IStep
{
    public string StepId => "PLUGIN_NAMEStep";

    public Task Run(BuildOrder buildOrder, IPipelineService pipelineService)
    {
        pipelineService.LogInfo($"Hello World! from {StepId}");
        pipelineService.LogInfo(buildOrder.ArtifactPath);
        return Task.CompletedTask;
    }

    
}