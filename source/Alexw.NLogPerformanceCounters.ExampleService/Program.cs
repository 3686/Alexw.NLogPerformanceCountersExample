using Topshelf;

namespace Alexw.NLogPerformanceCounters.ExampleService
{
    public class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>                                 
            {
                x.Service<Service>(s =>                        
                {
                    s.ConstructUsing(name => new Service());     
                    s.WhenStarted(tc => tc.Start());              
                    s.WhenStopped(tc => tc.Stop());               
                });
                x.RunAsLocalSystem();                            

                x.SetDescription("Ex Topshelf Host");        
                x.SetDisplayName("Stuff");                       
                x.SetServiceName("Stuff");                       
            });                                                  
        }
    }
}