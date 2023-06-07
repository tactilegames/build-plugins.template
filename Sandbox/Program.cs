using System.Threading.Tasks;
using BuildPlugins.PLUGIN_NAME;
using Sandbox;
using TactilePipeline;

public class Program
{
    public static async Task Main()
    {
        var pipelineService = new SandboxPipelineServiceFactory().Create();
        
        await RunStepWithoutOptions(pipelineService);
        await RunStepWithOptions(pipelineService);
    }
    
    private static async Task RunStepWithoutOptions(IPipelineService pipelineService)
    {
        var myStep = new PLUGIN_NAMEStep();

        await myStep.Run(pipelineService);
    }
    
    private static async Task RunStepWithOptions(IPipelineService pipelineService)
    {
        var myStepWithOptions = new PLUGIN_NAMEWithOptionsStep();
        var options = new ExampleOptions
        {
            Message = "Hello World!"
        };

        await myStepWithOptions.Run(options, pipelineService);
    }
}