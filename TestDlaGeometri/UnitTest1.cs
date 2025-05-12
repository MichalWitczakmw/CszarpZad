using Geometria;

namespace TestDlaGeometri
{
    public class UnitTest1
    {
        [Fact]
        public void TestPole()
        {
            var kolo = new Ko�o();
            kolo.Promie� = 1;

            Assert.Equal(3.14, kolo.Pole(),0.01);

        }
        [Fact]
        public void TestPromie�()
        {
            var kolo = new Ko�o();
            Assert.Throws<ArgumentOutOfRangeException>(() => kolo.Promie� = -1);
        }
    }
}