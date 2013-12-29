using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caldera.Core.UnitTest
{
   [TestClass]
   public class MudApplicationTest
   {
      [TestInitialize]
      public void Initialize()
      {
         Dependency.CreateUnityContainer();
      }

      [TestMethod]
      public void Run_()
      {
         var mudApplication = new MudApplication();

         mudApplication.Run( null );
      }
   }
}
