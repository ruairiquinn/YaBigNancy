using Nancy;

namespace YaBigNancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(Nancy.Conventions.NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            // Check out how to create a convention for view location
            nancyConventions.ViewLocationConventions.Add((viewName, model, context) => 
                string.Concat(context.ModuleName, "/views/", viewName));
        }
    }
}