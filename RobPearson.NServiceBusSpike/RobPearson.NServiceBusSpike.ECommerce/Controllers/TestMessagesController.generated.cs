﻿

//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NServiceBus;

using RobPearson.NServiceBusSpike.Internal.Commands.Sales;


using RobPearson.NServiceBusSpike.Sales;
	

namespace RobPearson.NServiceBusSpike.ECommerce.Controllers
{
    public partial class TestMessagesController : Controller
    {
        //
        // GET: /TestMessages/

        public ActionResult Index()
        {
            return View();
        }

				
		public ISubmitOrderSender SubmitOrderSender { get; set; }
		
        // POST: /TestMessages/SendMessageSubmitOrder
          
        [HttpPost]
        public string SendMessageSubmitOrder(SubmitOrder SubmitOrder)
        {
            ConfigureSubmitOrder(SubmitOrder);
            SubmitOrderSender.Send(SubmitOrder);
			return "<p> SubmitOrder command sent</p>";
        }
		
	  


	  // Send Commands
    
        partial void ConfigureSubmitOrder(SubmitOrder message);
      
	 // Publish Events
        }
}
