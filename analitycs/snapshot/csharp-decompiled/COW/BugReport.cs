using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public static class BugReport
{
	private interface IBugReporter
	{
		bool IsInited { get; }

		void Init();

		void SetUnityLogTypes(int logTypes);

		void OverrideUnityLogTypes(int logTypes);

		void SetUserId(string userId);

		void SetKeyValue(string key, string value);

		void Record(string msg);

		void Report(string src, string msg, string stacktrace);

		void Report(Exception exception);
	}

	private class Crashlytics : IBugReporter
	{
		private int _ReportCount;

		private int UnityLogTypes;

		private int OverrideLogTypes;

		public static bool Enabled => false;

		public bool IsInited => false;

		public void Init()
		{
		}

		private void OnApplicationLogMessageReceived(string logString, string stacktrace, LogType type)
		{
		}

		public void SetUnityLogTypes(int logTypes)
		{
		}

		public void OverrideUnityLogTypes(int logTypes)
		{
		}

		public void SetUserId(string userId)
		{
		}

		public void SetKeyValue(string key, string value)
		{
		}

		public void Record(string msg)
		{
		}

		public void Report(string src, string msg, string stacktrace)
		{
		}

		public void Report(Exception exception)
		{
		}

		private void _003CInit_003Eb__5_0()
		{
		}
	}

	private static bool _003CIsInited_003Ek__BackingField;

	private static List<IBugReporter> _Impls;

	public static bool Enabled => false;

	public static bool IsInited
	{
		get
		{
			return _003CIsInited_003Ek__BackingField;
		}
		private set
		{
			_003CIsInited_003Ek__BackingField = value;
		}
	}

	public static void Init()
	{
	}

	public static void SetUnityLogTypes(int logTypes)
	{
	}

	public static void OverrideUnityLogTypes(int logTypes)
	{
	}

	public static void SetUserId(string userId)
	{
	}

	public static void SetKeyValue(string key, string value, string time = "")
	{
	}

	public static void Log(string msg)
	{
	}

	public static void Report(string source, string msg, string stacktrace)
	{
	}

	public static void Report(Exception exception)
	{
	}
}
