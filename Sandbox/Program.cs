using BuildPlugins.PLUGIN_NAME;
using Sandbox;

public class Program
{
    public static async Task Main()
    {
        var pipelineService = new SandboxPipelineServiceFactory().Create();
        var myStep = new PLUGIN_NAMEStep();
        await myStep.Run(pipelineService);
    }

}