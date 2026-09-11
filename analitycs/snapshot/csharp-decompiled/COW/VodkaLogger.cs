using System;
using System.Collections.Generic;

namespace COW;

public static class VodkaLogger
{
	private static VodkaLogLevel _currentLevel;

	private static readonly List<string> _buffer;

	private const int MaxBufferSize = 500;

	private const string Tag = "[VodkaLog] ";

	private static Func<DateTime> GetDateTimeNowFunc;

	public static VodkaLogLevel CurrentLevel
	{
		get
		{
			return VodkaLogLevel.None;
		}
		set
		{
		}
	}

	public static int BufferCount => 0;

	public static void RegisterDateNowFunc(Func<DateTime> func)
	{
	}

	public static string GetBufferedLogs()
	{
		return null;
	}

	public static void ClearBuffer()
	{
	}

	private static void Log(VodkaLogLevel level, string message)
	{
	}

	public static void Fatal(string message)
	{
	}

	public static void Error(string message)
	{
	}

	public static void Warning(string message)
	{
	}

	public static void Debug(string message)
	{
	}

	public static void Info(string message)
	{
	}
}
