using ClassLibrary1;
using ConsoleApp1;

namespace TestProject1
{
    public class RetornaUmClassTests
    {
        [Fact]
        public void Test1()
        {
            var obj = new RetornaUmClass();
            var result = obj.RetornaUm();
            Assert.True(result == 1);
        }

        [Fact]
        public void Test2()
        {
            Program.Main();
        }
    }
}