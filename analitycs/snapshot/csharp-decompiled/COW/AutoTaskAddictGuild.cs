using System;

namespace COW;

public class AutoTaskAddictGuild : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__2_2;

		internal void _003CDo_003Eb__2_2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public UIModelAntiAddiction modelAntiAddtion;

		public AutoTaskAddictGuild _003C_003E4__this;

		internal void _003CDo_003Eb__0()
		{
		}

		internal void _003CDo_003Eb__1()
		{
		}
	}

	private UISecondConfirmContoller m_UISecondConfirmController;

	private UIPopupMessageBoxController m_UIPopupMessageBoxController;

	public override bool Do()
	{
		return false;
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
