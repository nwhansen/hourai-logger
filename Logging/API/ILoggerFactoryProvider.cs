using Hourai.Logging.Interfaces;

namespace Hourai.Logging.API {
	/// <summary>
	/// Defines a service which is used to provide the logging framework. This must be implemented by the logging implementor
	/// </summary>
	public interface ILoggerFactoryProvider {

		/// <summary>
		/// Return the logger factory to be used by the logger factory
		/// </summary>
		/// <returns>The logger factory</returns>
		ILoggerFactory GetLoggerFactory();

	}
}
