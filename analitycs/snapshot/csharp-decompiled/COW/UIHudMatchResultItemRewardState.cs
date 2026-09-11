using System;
using System.Collections.Generic;

namespace COW;

public class UIHudMatchResultItemRewardState : UIHudMatchResultStateBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__4_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__4_1;

		internal CommonRewardItemInfo _003COnEnter_003Eb__4_0(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003COnEnter_003Eb__4_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private List<BaseItemInfo> m_DebrisList;

	private List<BaseItemInfo> m_CommonList;

	public UIHudMatchResultItemRewardState(UIHudMatchResultStateMachine machine)
		: base(null, EUIHudMatchResultState.None)
	{
	}

	protected override bool OnCheck()
	{
		return false;
	}

	protected override bool OnEnter()
	{
		return false;
	}

	protected override void OnFinish()
	{
	}

	protected override void OnExit()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnExit()
	{
	}
}
