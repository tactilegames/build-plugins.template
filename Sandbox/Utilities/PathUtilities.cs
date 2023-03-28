using System.Reflection;

namespace Sandbox;

public static class PathUtilities
{
    public static string GetRootPath()
    {
        var assemblyLocation = Assembly.GetExecutingAssembly().Location;
        var assemblyPath = Path.GetDirectoryName(assemblyLocation);
        var projectRoot = Directory.GetParent(assemblyPath).Parent.Parent.FullName;
        return projectRoot;
    }
}