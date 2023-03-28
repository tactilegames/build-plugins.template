using System.Threading.Tasks;
using BuildPlugins.PLUGIN_NAME;
using Sandbox;

public class Program
{
    public static async Task Main()
    {
        var myStep = new PLUGIN_NAMEStep();
        var buildOrder = new SandboxBuildOrderFactory().Create();
        var pipelineService = new SandboxPipelineServiceFactory().Create();

        await myStep.Run(buildOrder, pipelineService);
    }
}