using System;
using NServiceBus;
using RobPearson.NServiceBusSpike.Internal.Commands.Sales;


namespace RobPearson.NServiceBusSpike.Sales
{
    public partial class SubmitOrderHandler
    {
		
        partial void HandleImplementation(SubmitOrder message)
        {
            // TODO: SubmitOrderHandler: Add code to handle the SubmitOrder message.
            Console.WriteLine("Sales received " + message.GetType().Name);
        }

    }
}
