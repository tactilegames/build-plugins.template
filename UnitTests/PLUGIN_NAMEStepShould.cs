using BuildPlugins.PLUGIN_NAME;
using NSubstitute;
using NUnit.Framework;
using TactilePipeline;

namespace UnitTests;

public class PLUGIN_NAMEStepShould
{
    [Test]
    public async Task Say_hello_world()
    {
        // Arrange
        var pipelineServiceMock = Substitute.For<IPipelineService>();
        var step = new PLUGIN_NAMEStep();

        // Act
        await step.Run(pipelineServiceMock);

        // Assert
        pipelineServiceMock
            .Received(1)
            .LogInfo(Arg.Is<string>(message => message.Equals($"Hello World! from {step.StepId}")));
    }
}