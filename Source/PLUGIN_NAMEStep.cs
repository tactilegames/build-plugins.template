using TactilePipeline;

namespace BuildPlugins.PLUGIN_NAME;

/// <summary>
/// This file contains the simplest step you can create.
/// If you want to know more about Options or Outputs you can go to: https://tactileentertainment.atlassian.net/wiki/spaces/GPD/pages/1291583694/Build+Plugin+Step+Class#Build-Plugin-Step-Classes-with-Requirements
/// </summary>
public class PLUGIN_NAMEStep : IStep
{
    public string StepId => "PLUGIN_NAMEStep";

    public async Task Run(IPipelineService pipelineService)
    {
        pipelineService.LogInfo($"Hello World! from {StepId}");
    }
    
}