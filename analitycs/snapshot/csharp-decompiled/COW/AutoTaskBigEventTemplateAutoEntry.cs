using System;
using System.Collections.Generic;
using proto;

namespace COW;

internal class AutoTaskBigEventTemplateAutoEntry : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CustomEventEntryDesc> _003C_003E9__7_0;

		internal bool _003CCheckPreDownloadCDNUrlIsDownloaded_003Eb__7_0(CustomEventEntryDesc x)
		{
			return false;
		}
	}

	public static string PrefAutoTaskBigEventTemplateAutoEntry;

	private UIBigEventLobbyEnterWndControler m_PopupWnd;

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

	private void OpenBigEventLobbyEnterWnd(uint useType, List<CustomEventEntryDesc> entryDesc)
	{
	}

	private bool CheckPreDownloadCDNUrlIsDownloaded(List<CustomEventEntryDesc> entryDesc)
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
