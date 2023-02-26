using Autofac;

namespace DependencyInjectAndOptionPatter.AutoFac.Configuration
{
    public class RegisterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmailService>().As<IMessageService>();

            // Other Lifetime
            // Transient
            //builder.RegisterType<EmployeeService>().As<IEmployeeService>()
            //    .InstancePerDependency();

            //// Scoped
            builder.RegisterType<SmsService>().As<IMessageService>()
                .InstancePerLifetimeScope();


            //// Singleton
            //builder.RegisterType<EmployeeService>().As<IEmployeeService>()
            //    .SingleInstance();

        }
    }
}
