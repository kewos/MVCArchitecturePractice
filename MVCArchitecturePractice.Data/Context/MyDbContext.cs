using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using MVCArchitecturePractice.Core;
using MVCArchitecturePractice.Data.Contrast.Context;

namespace MVCArchitecturePractice.Data.Context
{
    /// <summary>
    /// EntityFramework DBContext
    /// </summary>
    public class MyDbContext : DbContext, IDbContext
    {
        /// <summary>
        /// 透過反射取得全部Mapping
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mappings = Assembly.GetExecutingAssembly().GetInheritedTypes(typeof(EntityTypeConfiguration<>));
            foreach (var mapping in mappings)
            {
                dynamic configurationInstance = Activator.CreateInstance(mapping);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
    }
}
