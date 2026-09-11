using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisLobbyTeamEquipInfoController : UIBaseController
{
	private UIHippoCrisisLobbyTeamEquipInfoView m_View;

	private HENEHAGJCLI m_ItemData;

	private uint m_Slot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetEquipSlot()
	{
		return 0u;
	}

	public void SetEquipSlotView(IHippoCrisisBackPackItemUIData data)
	{
	}

	public void SetEmptySlotView(EHippoCrisisEquipmentSlot slot)
	{
	}

	public string GetEmptySpriteBySlot(EHippoCrisisEquipmentSlot slot)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
