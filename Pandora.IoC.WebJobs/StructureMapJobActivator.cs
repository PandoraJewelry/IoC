using Microsoft.Azure.WebJobs.Host;
using StructureMap;
using System;

namespace Pandora.IoC.WebJobs
{
    public class StructureMapJobActivator : IJobActivator
    {
        #region fields
        private IContainer _container;
        #endregion

        public StructureMapJobActivator(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            _container = container;
        }

        public T CreateInstance<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}
