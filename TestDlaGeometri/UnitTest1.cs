using Geometria;

namespace TestDlaGeometri
{
    public class UnitTest1
    {
        [Fact]
        public void TestPole()
        {
            var kolo = new Ko³o();
            kolo.Promieñ = 1;

            Assert.Equal(3.14, kolo.Pole(),0.01);

        }
        [Fact]
        public void TestPromieñ()
        {
            var kolo = new Ko³o();
            Assert.Throws<ArgumentOutOfRangeException>(() => kolo.Promieñ = -1);
        }
    }
}