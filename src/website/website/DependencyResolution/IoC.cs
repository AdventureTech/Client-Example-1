using System.Data.Entity;
using StructureMap;
using website.DataAccess;

namespace website {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<DbContext>().HttpContextScoped().Use<GrainSystemDataContext>();
                            x.For(typeof(IRepository<>)).Use(typeof(EntityFrameworkRepository<>));
                        });
            return ObjectFactory.Container;
        }
    }
}