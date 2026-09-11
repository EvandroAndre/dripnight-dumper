using System.Collections.Generic;

namespace InterApp;

public static class OpenedWithParamsProcessor
{
	public enum EnumProcessStatus
	{
		None,
		Queued,
		Done
	}

	public interface ISpontaneousMessageHandler
	{
		void OnSpontaneousMessage(Dictionary<string, string> msg, bool isSilent);
	}

	private static EnumProcessStatus _ProcessStatus;

	private static List<OpenedWithParamsDelegate> _Delegates;

	private static List<ISpontaneousMessageHandler> _SpontaneousMessageHandlers;

	public static EnumProcessStatus ProcessStatus
	{
		get
		{
			return EnumProcessStatus.None;
		}
		private set
		{
		}
	}

	public static List<OpenedWithParamsDelegate> Delegates => null;

	public static void AddDelegate(OpenedWithParamsDelegate d)
	{
	}

	public static bool HasDelegate(OpenedWithParamsDelegate d)
	{
		return false;
	}

	public static void RemoveDelegate(OpenedWithParamsDelegate d)
	{
	}

	public static OpenedWithParamsDelegate.OpenedWithParams Process(Dictionary<string, string> parameters)
	{
		return null;
	}

	public static void Processed(OpenedWithParamsDelegate.OpenedWithParams openedWithParams)
	{
	}

	public static void OnProcessingQueued()
	{
	}

	public static void OnProcessingDone()
	{
	}

	public static void RegisterSpontaneousMessageHandler(ISpontaneousMessageHandler handler)
	{
	}

	public static void UnregisterSpontaneousMessageHandler(ISpontaneousMessageHandler handler)
	{
	}

	public static void TriggerSpontaneousMessage(Dictionary<string, string> msg, bool isSilent)
	{
	}
}
