﻿//------------------------------------------------------------------------------
// <auto-generated>
// 	This code was generated by a tool
// 	Changes to this file will be lost if the code is regenerated.
// AggregateServiceHostFactoryTemplate.t4
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
using Cqrs.Ninject.ServiceHost;
using HelloWorld.Domain.Akka.Services;

namespace HelloWorld.Domain.Akka.Services.ServiceHost.Ninject.ServiceHostFactories
{
	/// <summary>
	/// A <see cref="NinjectWcfServiceHostFactory{TServiceType}"/> for using  <see cref="IHelloWorldExampleService"/> via WCF
	/// </summary>
	[GeneratedCode("CQRS UML Code Generator", "1.601.932")]
	public partial class HelloWorldExampleServiceHostFactory : NinjectWcfServiceHostFactory<IHelloWorldExampleService>
	{
	}

}
