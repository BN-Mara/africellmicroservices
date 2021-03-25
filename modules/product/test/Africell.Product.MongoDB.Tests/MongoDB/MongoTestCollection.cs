using Xunit;

namespace Africell.Product.MongoDB
{
    [CollectionDefinition(Name)]
    public class MongoTestCollection : ICollectionFixture<MongoDbFixture>
    {
        public const string Name = "MongoDB Collection";
    }
}