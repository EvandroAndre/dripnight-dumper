using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPOIMissionInfoController : UIHudPOIMissionInfoBaseController
{
	private UIHudPOIMissionInfoView m_View;

	private bool m_RequestAcceptMission;

	private uint m_DelayHideID;

	protected override UILabel MissionLabel => null;

	protected override GameObject Available => null;

	protected override GameObject Unavailable => null;

	protected override UILabel UnavailableLabel => null;

	protected override UIButton BtnAccept => null;

	protected override GameObject Countdown => null;

	protected override UILabel TimeLabel => null;

	protected override GameObject ProgressTag => null;

	protected override UILabel ProgressLabel => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	protected override void OnBtnAcceptClick()
	{
	}

	protected override void OnPOIMissionOwnerChanged()
	{
	}

	public override void SetData()
	{
	}

	private void DelayHide()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CDelayHide_003Eb__27_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnAcceptClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPOIMissionOwnerChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
