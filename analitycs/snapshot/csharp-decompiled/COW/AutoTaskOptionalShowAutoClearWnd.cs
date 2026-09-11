using System;

namespace COW;

public class AutoTaskOptionalShowAutoClearWnd : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__4_0;

		public static Action _003C_003E9__4_1;

		internal void _003CShowStorageTipWnd_003Eb__4_0()
		{
		}

		internal void _003CShowStorageTipWnd_003Eb__4_1()
		{
		}
	}

	public static string AutoTaskOptionalClearTipWndKey;

	private UISecondConfirmContoller m_UISecondConfirmController;

	public static long temp_RequireSize;

	public override bool Do()
	{
		return false;
	}

	private void ShowStorageTipWnd()
	{
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
