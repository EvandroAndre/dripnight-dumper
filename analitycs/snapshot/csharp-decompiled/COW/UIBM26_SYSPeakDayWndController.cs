using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBM26_SYSPeakDayWndController : UIBigEventPeakDayWndBaseController
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Action action;

		internal void _003CPlayAnimationOut_003Eb__0()
		{
		}
	}

	private Animation m_MainAni;

	private uint m_DelayKeyID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void PlayAnimationIn()
	{
	}

	public override void CloseUI()
	{
	}

	private void PlayAnimationOut(Action action)
	{
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override string GetPeakDayExpiredKey()
	{
		return null;
	}

	public override string GetPeakDayLoginKey()
	{
		return null;
	}

	public override string GetPeakDayTitleKey()
	{
		return null;
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public override UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	private void _003CCloseUI_003Eb__5_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_CloseUI()
	{
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public string _003C_003EiFixBaseProxy_GetPeakDayExpiredKey()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPeakDayLoginKey()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPeakDayTitleKey()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public UIStandardItemMiniController _003C_003EiFixBaseProxy_GetItemController()
	{
		return null;
	}
}
