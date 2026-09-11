using GCommon;
using UnityEngine;

namespace COW;

internal class UINewPlayerV3SignAwardItemController : UIBaseController
{
	private UIStandardItemMAXBController m_SignAwardItemMAXCtrl;

	private UINewPlayerV3SignAwardItemView m_View;

	private Color HIGH_LIGHT_BG;

	private Color SIGN_BG;

	private Color BIGREWARD_BG;

	private Vector3 STANDARDITEM_MAX_RESIZE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(BaseItemInfo item)
	{
	}

	private void SetItemMaxData(BaseItemInfo item)
	{
	}

	public void SetClaimedState(bool isShow)
	{
	}

	public void SetHighLightState(bool isShow)
	{
	}

	public void SetBgState(bool canClaim, bool isSignAward)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
