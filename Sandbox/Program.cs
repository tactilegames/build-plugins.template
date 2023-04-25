using System.Threading.Tasks;
using BuildPlugins.PLUGIN_NAME;
using Sandbox;

public class Program
{
    public static async Task Main()
    {
        var buildOrder = new SandboxBuildOrderFactory().Create();
        var pipelineService = new SandboxPipelineServiceFactory().Create();
        var buildResult = new SandboxBuildResultFactory().Create();
        var myStep = new PLUGIN_NAMEStep();

        await myStep.Run(buildOrder, pipelineService, buildResult);
    }
}