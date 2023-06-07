using System.Threading.Tasks;
using TactilePipeline;
using TactilePipeline.Values;

namespace BuildPlugins.PLUGIN_NAME;

// Example of a step without options.
public class PLUGIN_NAMEStep : IStep
{
    public string StepId => "PLUGIN_NAMEStep";

    public async Task Run(IPipelineService pipelineService)
    {
        pipelineService.LogInfo($"Hello World! from {StepId}");
    }
    
}

// Example of using a step with options.
public class ExampleOptions : Options
{
    [PipelineValue("MESSAGE", "A Message to display in the console")]
    public string Message { get; set; }
}

public class PLUGIN_NAMEWithOptionsStep : IStep<ExampleOptions>
{
    public string StepId => "ExampleWithOptionsStep";
    
    public async Task Run(ExampleOptions options, IPipelineService pipelineService)
    {
        pipelineService.LogInfo($"Displaying Message from {StepId}: {options.Message}");
    }
}