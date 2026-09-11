using System;
using proto;

namespace COW;

internal class AutoTaskBigEventAutoEntry : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<BigEventEntryDesc> _003C_003E9__6_0;

		internal bool _003CCheckPreDownloadCDNUrlIsDownloaded_003Eb__6_0(BigEventEntryDesc x)
		{
			return false;
		}
	}

	public static string PrefAutoTaskBigEventAutoEntry;

	private UIABigEventLobbyEnterWndControler m_PopupWnd;

	private const uint MAIN_ENTRY_DESC_INDEX = 1u;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public static bool NeedAutoTask()
	{
		return false;
	}

	public override bool Do()
	{
		return false;
	}

	private bool CheckPreDownloadCDNUrlIsDownloaded()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
