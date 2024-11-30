using ClassLibrary1;
namespace TestProject3
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int a = 2;
			int b = 4;
			Assert.AreEqual(6, Class1.Sum(a,b), "ошибка 1");
		}
		[TestMethod]
		public void TestMethod2()
		{
			int a = 3;
			int b = 5;
			Assert.AreEqual(8, Class1.Sum(a, b), "ошибка 2");
		}
		[TestMethod]
		public void TestMethod3()
		{
			int a = 5;
			int b = 5;
			Assert.AreEqual(10, Class1.Sum(a, b), "ошибка 3");
		}
		[TestMethod]
		public void TestMethod4()
		{
			int a = 6;
			int b = 7;
			Assert.AreEqual(13, Class1.Sum(a, b), "ошибка 4");
		}
	}
}