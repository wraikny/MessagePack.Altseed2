using MessagePack.Resolvers;
using Xunit;

namespace MessagePack.Altseed2.Tests.Utils
{
    
    public class ResolverFixture
    {
        public ResolverFixture()
        {
            var resolver = CompositeResolver.Create(
                Altseed2Resolver.Instance,
                StandardResolver.Instance
            );

            var options = MessagePackSerializerOptions.Standard.WithResolver(resolver);

            MessagePackSerializer.DefaultOptions = options;
        }
    }

    [CollectionDefinition("ResolverCollection")]
    public class ResolverCollection : ICollectionFixture<ResolverFixture>
    {

    }
}
