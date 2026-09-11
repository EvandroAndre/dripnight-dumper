using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudLoadoutSupportBuffItemController : UIBaseController
{
	private UIHudLoadoutSupportBuffItemView m_View;

	private LoadoutSupportBuffData m_Data;

	private bool m_IsEquiped;

	private bool m_IsChoosed;

	private bool m_IsEquipedByTeammate;

	private UIHudLoadoutSupportController m_ParentCtrl;

	public bool IsEquipedByTeammate => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void Show()
	{
	}

	public void InitData(LoadoutSupportBuffData data)
	{
	}

	public uint GetDataId()
	{
		return 0u;
	}

	private void OnLoadoutSupportSlotStateAllModified(uint playerID)
	{
	}

	private void OnLoadoutSupportSlotCacheBuffChanged(uint slotIndex)
	{
	}

	private void RefreshSelectedState()
	{
	}

	private void RefreshTeammateSelectedState()
	{
	}

	private void OnBtnBuffItemClick()
	{
	}

	public void SetEquipedState(bool isEquiped)
	{
	}

	public void SetChooseState(bool isChoose)
	{
	}

	private void SetTeammateActivationState(Player player)
	{
	}

	private void RefreshEquipedState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
