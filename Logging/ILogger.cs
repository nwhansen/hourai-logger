using System;
using Hourai.Logging.Model;

namespace Hourai.Logging {
	/// <summary>
	/// Represents a context specific logger
	/// </summary>
	public interface ILogger {

		#region Public Properties

		/// <summary>
		/// If Logging at Error Level is enabled
		/// </summary>
		bool IsErrorEnabled { get; }

		/// <summary>
		/// If the Logging at Warning is Enabled
		/// </summary>
		bool IsWarningEnabled { get; }

		/// <summary>
		/// If the Logging at Info is Enabled
		/// </summary>
		bool IsInfoEnabled { get; }

		/// <summary>
		/// If debugging is enabled for the context
		/// </summary>
		bool IsDebugEnabled { get; }

		/// <summary>
		/// If the Logging at Info is Enabled
		/// </summary>
		bool IsTraceEnabled { get; }

		#endregion

		/// <summary>
		/// Updates this specific logger context depending on the backend logging framework this may cascade
		/// </summary>
		/// <param name="level">The level to log at</param>
		void SetLogLevel(LogLevel level);

		#region Error

		/// <summary>
		/// Writes the given log message at Error level
		/// </summary>
		/// <param name="message">The message to log</param>
		void Error(string message);

		/// <summary>
		/// Writes the given formatted log message and exception to the log at Error level
		/// </summary>
		/// <param name="format">A String.Format format message</param>
		/// <param name="param">A singular param for the string format</param>
		/// <param name="ex">The Exception to log</param>
		void Error(string format, string param, Exception ex);

		/// <summary>
		/// Writes the given log message and exception to the log at Error level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		/// <param name="ex">The exception to log</param>
		void Error(string message, Exception ex);

		/// <summary>
		/// Writes the given formatted log message to the log at Error level
		/// </summary>
		/// <param name="format">The format string</param>
		/// <param name="parameters">The parameters for the format string, if the last item is type Exception it will be converted parsed as a normal exception</param>
		void Error(string format, params object[] parameters);


		#endregion

		#region Warning

		/// <summary>
		/// Writes the given log message to the log at Warning level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		void Warning(string message);

		/// <summary>
		/// Writes the given formatted log message and exception to the log at Warning level
		/// </summary>
		/// <param name="format">A String.Format format message</param>
		/// <param name="param">A singular param for the string format</param>
		/// <param name="ex">The Exception to log</param>
		void Warning(string format, string param, Exception ex);

		/// <summary>
		/// Writes the given log message and exception to the log at Warning level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		/// <param name="ex">The exception to log</param>
		void Warning(string message, Exception ex);

		/// <summary>
		/// Writes the formatted log message to the log at Warning level
		/// </summary>
		/// <param name="format">The format string</param>
		/// <param name="parameters">The parameters for the format string, if the last item is type Exception it will be converted parsed as a normal exception</param>
		void Warning(string format, params object[] parameters);

		#endregion

		#region Info

		/// <summary>
		/// Writes the given log message to the log at Info level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		void Info(string message);

		/// <summary>
		/// Writes the given formatted log message and exception to the log at Info level
		/// </summary>
		/// <param name="format">A String.Format format message</param>
		/// <param name="param">A singular param for the string format</param>
		/// <param name="ex">The Exception to log</param>
		void Info(string format, string param, Exception ex);

		/// <summary>
		/// Writes the given log message and exception to the log at Info level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		/// <param name="ex">The exception to log</param>
		void Info(string message, Exception ex);

		/// <summary>
		/// Writes the formatted log message to the log at Info level
		/// </summary>
		/// <param name="format">The format string</param>
		/// <param name="parameters">The parameters for the format string, if the last item is type Exception it will be converted parsed as a normal exception</param>
		void Info(string format, params object[] parameters);

		#endregion

		#region Debug

		/// <summary>
		/// Writes the given log message to the log at Debug level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		void Debug(string message);

		/// <summary>
		/// Writes the given formatted log message and exception to the log at Debug level
		/// </summary>
		/// <param name="format">A String.Format format message</param>
		/// <param name="param">A singular param for the string format</param>
		/// <param name="ex">The Exception to log</param>
		void Debug(string format, string param, Exception ex);

		/// <summary>
		/// Writes the given log message and exception to the log at Debug level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		/// <param name="ex">The exception to log</param>
		void Debug(string message, Exception ex);

		/// <summary>
		/// Writes the formatted log message to the log at Debug level
		/// </summary>
		/// <param name="format">The format string</param>
		/// <param name="parameters">The parameters for the format string, if the last item is type Exception it will be converted parsed as a normal exception</param>
		void Debug(string format, params object[] parameters);

		#endregion

		#region Trace

		/// <summary>
		/// Writes the given log message to the log at Trace level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		void Trace(string message);

		/// <summary>
		/// Writes the given formatted log message and exception to the log at Trace level
		/// </summary>
		/// <param name="format">A String.Format format message</param>
		/// <param name="param">A singular param for the string format</param>
		/// <param name="ex">The Exception to log</param>
		void Trace(string format, string param, Exception ex);

		/// <summary>
		/// Writes the given log message and exception to the log at Trace level
		/// </summary>
		/// <param name="message">The unformatted message to write</param>
		/// <param name="ex">The exception to log</param>
		void Trace(string message, Exception ex);

		/// <summary>
		/// Writes the formatted log message to the log at Trace level
		/// </summary>
		/// <param name="format">The format string</param>
		/// <param name="parameters">The parameters for the format string, if the last item is type Exception it will be converted parsed as a normal exception</param>
		void Trace(string format, params object[] parameters);

		#endregion

	}
}
