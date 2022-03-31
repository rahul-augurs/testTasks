
using Test_Task_Service;


namespace Test_Task
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRepository();

        }


        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
