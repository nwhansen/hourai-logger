using System;
using System.Collections.Generic;
using System.Text;
using Hourai.Logging.API;
using Hourai.Logging.Implementation;
using Hourai.Logging.Interfaces;

namespace Hourai.Logging {
	public static class LoggerFactory {

		/// <summary>
		/// Represents the provider that we have discovered. If we have not discovered one, we will use return our NoOp factory (just like SLFJ)
		/// </summary>
		private readonly static ILoggerFactory factory;

		/// <summary>
		/// Initializes the logging framework. Eventually this may need to solve multi-threaded situations 
		/// </summary>
		static LoggerFactory() {
			ILoggerFactory discovered = null;
			//Initialize our service locator
			LoggerServiceLocator serviceLocator = new LoggerServiceLocator();
			Type discoveredFactory = serviceLocator.Search();
			var constructor = discoveredFactory.GetConstructor(Type.EmptyTypes);
			try {
				//Invoke the provider's constructor (It must have one or we default to blank)
				var provider = (ILoggerFactoryProvider)constructor.Invoke(new object[0]);
				discovered = provider.GetLoggerFactory();
			} catch (Exception) { } //We are a logger framework dying isn't allowed 
			factory = discovered ?? new NoOpLoggerFactory();
		}

		public static ILogger GetLogger(Type type) {
			return factory.GetLogger(type);
		}

		public static ILogger GetLogger(string name) {
			return factory.GetLogger(name);
		}

		public static ILogger GetRootLogger() {
			return factory.RootLogger;
		}
	}
}
