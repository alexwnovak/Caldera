using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Caldera.Core.UnitTest
{
   [TestClass]
   public class ClientSubsystemTest
   {
      [TestInitialize]
      public void Initialize()
      {
         Dependency.CreateUnityContainer();
      }

      [TestMethod]
      public void Foo()
      {
         // Setup



         // Test

         var clientSubsystem = new ClientSubsystem();

         clientSubsystem.Start();

      }
   }
}
