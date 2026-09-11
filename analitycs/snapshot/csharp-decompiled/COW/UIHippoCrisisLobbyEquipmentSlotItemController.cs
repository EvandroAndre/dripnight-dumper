using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisLobbyEquipmentSlotItemController : UIBaseController
{
	private UIHippoCrisisLobbyEquipmentSlotItemView m_View;

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

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
