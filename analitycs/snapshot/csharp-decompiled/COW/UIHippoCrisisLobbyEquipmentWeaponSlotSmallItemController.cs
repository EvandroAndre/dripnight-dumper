using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisLobbyEquipmentWeaponSlotSmallItemController : UIBaseController
{
	private UIHippoCrisisLobbyEquipmentWeaponSlotSmallItemView m_View;

	private HENEHAGJCLI m_ItemData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Refresh(IHippoCrisisBackPackItemUIData data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
