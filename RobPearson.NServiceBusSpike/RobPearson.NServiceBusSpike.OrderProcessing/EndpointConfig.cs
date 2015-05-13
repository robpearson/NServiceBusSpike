using NServiceBus;
using NServiceBus.Persistence;

namespace RobPearson.NServiceBusSpike.OrderProcessing
{
    public partial class EndpointConfig    
    {
        public void Customize(BusConfiguration configuration)
        {
            // For production use, please select a durable persistence.
            // To use RavenDB, install-package NServiceBus.RavenDB and then use configuration.UsePersistence<RavenDBPersistence>();
            // To use SQLServer, install-package NServiceBus.NHibernate and then use configuration.UsePersistence<NHibernatePersistence>();
            configuration.UsePersistence<RavenDBPersistence>();
        }
    }
}
