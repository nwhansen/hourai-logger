using System;

namespace Hourai.Logging.Interfaces {
	/// <summary>
	/// A Logger Factory
	/// </summary>
	public interface ILoggerFactory {

		/// <summary>
		/// Returns the "root" logger important for managing root log level if the logger implements cascading
		/// </summary>
		ILogger RootLogger { get; }

		/// <summary>
		/// Returns a logger for a given type
		/// </summary>
		/// <param name="type">The type of to get the logger</param>
		/// <returns>The Logger for the type</returns>
		ILogger GetLogger(Type type);

		/// <summary>
		/// Gets a logger with a given name
		/// </summary>
		/// <param name="name">The name of the Logger to retrieve</param>
		/// <returns>The logger with the given name</returns>
		ILogger GetLogger(string name);

	}
}
