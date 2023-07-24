using Bogus;
using Moq;
using Moq.AutoMock;

namespace Weighter.Tests.Base
{
    public class UnitTestBase<T> where T : class
    {
        public UnitTestBase()
        {
            Faker = new Faker();
            Mocker = new AutoMocker(MockBehavior.Default, DefaultValue.Mock);
            Sut = Mocker.CreateInstance<T>();
            SutMock = Mocker.GetMock<T>();
            SutMock.CallBase = true;
        }

        public T Sut { get; }
        public Mock<T> SutMock { get; }
        public AutoMocker Mocker { get; }
        public Faker Faker { get; }
    }
    
    public class UnitTestBase
    {
        public UnitTestBase()
        {
            Faker = new Faker();
            Mocker = new AutoMocker(MockBehavior.Default, DefaultValue.Mock);
        }
        
        public AutoMocker Mocker { get; }
        public Faker Faker { get; }
    }
}