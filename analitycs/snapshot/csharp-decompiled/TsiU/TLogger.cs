using System.Collections.Generic;

namespace TsiU;

public class TLogger : TStaticHelperBase<TLogger>
{
	public enum LOGGER_CHANNEL
	{
		DEFAULT,
		WARNING,
		INFO,
		TODO,
		ERROR,
		DEBUG,
		PROFILE,
		NUM
	}

	public enum LOGGER_REDIRECTION
	{
		CONSOLE,
		STRING,
		FILE
	}

	private bool[] _enabledChannel;

	private List<TILoggerListener> _listeners;

	public static void DEBUG(string msg)
	{
	}

	public static void WARNING(string msg)
	{
	}

	public static void INFO(string msg)
	{
	}

	public static void TODO(string msg)
	{
	}

	public static void ERROR(string msg)
	{
	}

	public static void PROFILE(string msg)
	{
	}

	protected override void onInit()
	{
	}

	public void EnableChannel(LOGGER_CHANNEL channel, bool isEnabled)
	{
	}

	public void AddLogListener(TILoggerListener listener)
	{
	}

	public void Log(string msg, LOGGER_CHANNEL channel, bool simpleMode)
	{
	}
}
