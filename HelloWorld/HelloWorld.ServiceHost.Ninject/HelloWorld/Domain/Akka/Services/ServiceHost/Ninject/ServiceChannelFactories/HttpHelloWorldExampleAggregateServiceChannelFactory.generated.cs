﻿//------------------------------------------------------------------------------
// <auto-generated>
// 	This code was generated by a tool
// 	Changes to this file will be lost if the code is regenerated.
// AggregateServiceChannelFactoryTemplate.t4
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion

using Cqrs.Domain;
using HelloWorld.Domain.Akka.Events;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Services;
using HelloWorld.Domain.Akka.Services;

namespace HelloWorld.Domain.Akka.Services.ServiceHost.Ninject.ServiceChannelFactories
{
	/// <summary>
	/// A <see cref="ServiceChannelFactory{TService}"/> for using  <see cref="IHelloWorldExampleService.CreateHelloWorldExample"/> via WCF
	/// </summary>
	public partial class HttpHelloWorldExampleServiceChannelFactory : ServiceChannelFactory<IHelloWorldExampleService>
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="HttpHelloWorldExampleServiceChannelFactory"/> class with the default endpoint configuration name of HttpHelloWorldExampleService.
		/// </summary>
		public HttpHelloWorldExampleServiceChannelFactory()
			: this("HttpHelloWorldExampleService")
		{
		}

		/// <summary>
		/// Instantiates a new instance of the <see cref="HttpHelloWorldExampleServiceChannelFactory" /> class with a specified endpoint configuration name.
		/// </summary>
		/// <param name="endpointConfigurationName">The configuration name used for the endpoint.</param>
		public HttpHelloWorldExampleServiceChannelFactory(string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
		}

		protected override void RegisterDataContracts()
		{
			RegisterAggregateServiceDataContracts();
			RegisterServiceDataContracts();
		}

		partial void RegisterServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts()
		{
	
			HelloWorldExampleServiceSayHelloWorldParametersResolver.RegisterDataContracts();
			HelloWorldExampleServiceReplyToHelloWorldParametersResolver.RegisterDataContracts();
			HelloWorldExampleServiceEndConversationParametersResolver.RegisterDataContracts();
		}
	}
}
