
namespace Hourai.Logging.Model {
	/// <summary>
	/// An enumeration of LogLevels - Values inspired by salt stack log level values (offers "in-between for logger implementations)
	/// </summary>
	public enum LogLevel {
		/// <summary>
		/// Log everything (this is in case there is new options below trace)
		/// </summary>
		All = 0,
		/// <summary>
		/// Log Trace level and above
		/// </summary>
		Trace = 5,
		/// <summary>
		/// Log Debug Level and above
		/// </summary>
		Debug = 10,
		/// <summary>
		/// Log Info and above
		/// </summary>
		Info = 20,
		/// <summary>
		/// Log Warning and above
		/// </summary>
		Warning = 30,
		/// <summary>
		/// Log Error and above
		/// </summary>
		Error = 40,
		/// <summary>
		/// Log Nothing
		/// </summary>
		Off = 1000
	}
}
