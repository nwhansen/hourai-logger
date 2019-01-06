using System;
using System.Collections.Generic;
using System.Text;
using Hourai.Logging.API;

namespace Hourai.Logging.Implementation {
	/// <summary>
	/// This searches the a logger implementation via reflection - Currently only searches the "existing" domain
	/// </summary>
	public class LoggerServiceLocator {

		public Type Search() {
			//Search our current domain first (if they have already loaded for example, or they have a testing one)
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (var assembly in assemblies) {
				var exportedTypes = assembly.GetExportedTypes();
				foreach (var type in exportedTypes) {
					if (type.IsClass && type.GetInterface("ILoggerFactoryProvider") != null) {
						return type;
					}
				}
			}
			//TODO: DLL Loading, this can be a bit tricky from a safety side so we need to allow this to be disabled via some sort of setting before implementing it.
			// This will allow for the desired drop in functionality that SLFJ provides. but for now its a small price to "load" the logger
			return null;
		}

	}
}
