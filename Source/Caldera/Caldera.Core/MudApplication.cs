namespace Caldera.Core
{
   public class MudApplication
   {
      public void Run( string[] arguments )
      {
         var clientSubsystem = new ClientSubsystem();
         clientSubsystem.Start();
      }
   }
}
