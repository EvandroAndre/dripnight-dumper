using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInGameShopV2POIMissionController : UIHudPOIMissionInfoBaseController
{
	private UIHudInGameShopV2POIMissionView m_View;

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

	public override void SetData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData()
	{
	}
}
