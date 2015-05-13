using NServiceBus;
using NServiceBus.Persistence;

namespace RobPearson.NServiceBusSpike.ECommerce.Infrastructure
{
    public class ConfigurePersistence : INeedInitialization
    {
        public void Customize(BusConfiguration config)
        {
            config.UsePersistence<RavenDBPersistence>();
        }
    }
}