using Moq;
using Moq.AutoMock;

namespace Weighter.Tests.Base;

public class UnitTestBase<T> where T : class
{
    public UnitTestBase()
    {
        Mocker = new AutoMocker(MockBehavior.Default, DefaultValue.Mock);
        Sut = Mocker.CreateInstance<T>();
        SutMock = new Mock<T>();
    }
        
    public AutoMocker Mocker { get; }
    public T Sut { get; }
    public Mock<T> SutMock { get; }
}