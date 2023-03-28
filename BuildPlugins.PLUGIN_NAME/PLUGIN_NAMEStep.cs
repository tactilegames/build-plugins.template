using System.Threading.Tasks;
using TactilePipeline;

namespace BuildPlugins.PLUGIN_NAME;

public class PLUGIN_NAMEStep : IStep
{
    public string StepId => "PLUGIN_NAMEStep";

    public async Task Run(BuildOrder buildOrder, IPipelineService pipelineService)
    {
        pipelineService.LogInfo($"Hello World! from {StepId}");
        pipelineService.LogInfo(buildOrder.ArtifactPath);
    }
    
}