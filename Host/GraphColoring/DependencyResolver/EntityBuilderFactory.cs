using Infrastructure.Repository.NodeBuilder;
using Infrastructure.Repository.SolutionBuilder;
using Runner.IBuilder;
using SimpleInjector;

namespace GraphColoring.DependencyResolver
{
    public static class EntityBuilderFactory
    {
        public static void Bootstrap(Container container)
        {
            
            container.Register<IGraphColoringSolutionBuilder, GraphColoringSolutionBuilder>();
            container.Register<INodeBuilder, GraphColoringNodeBuilder>();
        }
    }
}