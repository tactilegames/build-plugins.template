using System.Threading.Tasks;
using TactilePipeline;

namespace BuildPlugins.PLUGIN_NAME;

public class PLUGIN_NAMEStep : IStep
{
    public string StepId => "PLUGIN_NAMEStep";

    public async Task Run(BuildOrder buildOrder, IPipelineService pipelineService, IBuildResult buildResult)
    {
        pipelineService.LogInfo($"Hello World! from {StepId}");
    }
    
}