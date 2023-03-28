using BuildPlugins.PLUGIN_NAME;
using NSubstitute;
using NUnit.Framework;
using TactilePipeline;
using TactilePipeline.Builders;

namespace UnitTests;

public class PLUGIN_NAMEStepShould
{
    [Test]
    public async Task Say_hello_world()
    {
        // Arrange
        var pipelineServiceMock = Substitute.For<IPipelineService>();
        var step = new PLUGIN_NAMEStep();
        var buildOrder = new BuildOrderBuilder().Build();
        
        // Act
        await step.Run(buildOrder, pipelineServiceMock);

        // Assert
        pipelineServiceMock
            .Received(1)
            .LogInfo(Arg.Is<string>(message => message.Equals($"Hello World! from {step.StepId}")));
    }
}