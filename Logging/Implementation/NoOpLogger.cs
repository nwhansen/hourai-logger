using System;
using System.Collections.Generic;
using System.Text;
using Hourai.Logging.Interfaces;
using Hourai.Logging.Model;

namespace Hourai.Logging.Implementation {
	/// <summary>
	/// A logger for 
	/// </summary>
	public class NoOpLoggerFactory : ILoggerFactory {
		private readonly NoOpLogger GlobalLogger = new NoOpLogger();

		public ILogger RootLogger => GlobalLogger;

		/// <summary>
		/// A logger that does nothing... the best worst kind
		/// </summary>
		private class NoOpLogger : ILogger {
			public bool IsErrorEnabled => false;

			public bool IsWarningEnabled => false;

			public bool IsInfoEnabled => false;

			public bool IsDebugEnabled => false;

			public bool IsTraceEnabled => false;

			public void Debug(string message) {
			}

			public void Debug(string format, string param, Exception ex) {
			}

			public void Debug(string message, Exception ex) {
			}

			public void Debug(string format, params object[] parameters) {
			}

			public void Error(string message) {
			}

			public void Error(string format, string param, Exception ex) {
			}

			public void Error(string message, Exception ex) {
			}

			public void Error(string format, params object[] parameters) {
			}

			public void Info(string message) {
			}

			public void Info(string format, string param, Exception ex) {
			}

			public void Info(string message, Exception ex) {
			}

			public void Info(string format, params object[] parameters) {
			}

			public void SetLogLevel(LogLevel level) {
			}

			public void Trace(string message) {
			}

			public void Trace(string format, string param, Exception ex) {
			}

			public void Trace(string message, Exception ex) {
			}

			public void Trace(string format, params object[] parameters) {
			}

			public void Warning(string message) {
			}

			public void Warning(string format, string param, Exception ex) {
			}

			public void Warning(string message, Exception ex) {
			}

			public void Warning(string format, params object[] parameters) {
			}
		}

		public ILogger GetLogger(Type type) {
			return GlobalLogger;
		}

		public ILogger GetLogger(string name) {
			return GlobalLogger;
		}
	}
}
