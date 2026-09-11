using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudLobbySocialPrivilegeSubBtnController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIHudLobbySocialPrivilegeSubBtnController _003C_003E4__this;

		public UIHudLobbySocialPrivilegeManager privilegePropMgr;

		public uint dataId;

		internal void _003CApplyRemainTimeCountdown_003Eb__0()
		{
		}

		internal void _003CApplyRemainTimeCountdown_003Eb__1()
		{
		}
	}

	private UIHudLobbySocialPrivilegeSubBtnView m_View;

	private LobbySocialPropType m_SlotType;

	private uint m_DataId;

	private UIHudLobbySocialPrivilegeManager m_PrivilegePropMgr;

	private Action m_OnPrivilegeItemCountdownFinished;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(LobbySocialPropType slotType, string iconSprite, int count, uint dataId, UIHudLobbySocialPrivilegeManager privilegePropMgr, Action onPrivilegeItemCountdownFinished = null)
	{
	}

	public void ClearCountdownFinishedCallback(List<uint> expiredItemIds)
	{
	}

	private void ApplyRemainTimeCountdown(uint dataId, UIHudLobbySocialPrivilegeManager privilegePropMgr)
	{
	}

	private void OnBtnClick()
	{
	}

	public void LogClick(string posfix)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
