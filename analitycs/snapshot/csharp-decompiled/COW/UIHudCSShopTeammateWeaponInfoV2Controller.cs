using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudCSShopTeammateWeaponInfoV2Controller : UIBaseController
{
	private UIHudCSShopTeammateWeaponInfoV2View m_View;

	private Dictionary<BHGGAEEHJCO, UIHudCSShopTeammateWeaponInfoItemV2Controller> m_Teammates;

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void InitTeammate()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnAddPlayer(GEvent param)
	{
	}

	private void CreateChildItem(Player teammatePlayer)
	{
	}

	public int GetMainPanelDepth()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
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
