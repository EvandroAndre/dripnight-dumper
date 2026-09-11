using System;
using GCommon;
using message;

namespace COW;

public class UIQueryJoinTeammateSocialTipsBoxController : UIHighPingTipsBoxController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__6_1;

		internal void _003COnUIInit_003Eb__6_1()
		{
		}
	}

	public static bool NeedShowOnGroupJoinSuccess;

	public static NIKKALKPIBO NeedShowOnGroupJoinSuccess_GameMode;

	public static ulong NeedShowOnGroupJoinSuccess_AccountId;

	public static string NeedShowOnGroupJoinSuccess_NickName;

	private bool DontShowToDay;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override float GetHighPingCountDownTime()
	{
		return 0f;
	}

	private void _003COnUIInit_003Eb__6_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public float _003C_003EiFixBaseProxy_GetHighPingCountDownTime()
	{
		return 0f;
	}
}
