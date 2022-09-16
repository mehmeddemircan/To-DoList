using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.Utilities.Interceptors;
using To_DoList.Business.Abstract;
using To_DoList.Business.Concrete;
using To_DoList.DataAccess.Abstract;
using To_DoList.DataAccess.Concrete.EntityFramework;

namespace To_DoList.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MissionManager>().As<IMissionService>(); 
            builder.RegisterType<MissionRepository>().As<IMissionRepository>();


            builder.RegisterType<GroupManager>().As<IGroupService>();
            builder.RegisterType<GroupRepository>().As<IGroupRepository>();


            builder.RegisterType<ThemeManager>().As<IThemeService>();
            builder.RegisterType<ThemeRepository>().As<IThemeRepository>();


            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<ColorRepository>().As<IColorRepository>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }


}
