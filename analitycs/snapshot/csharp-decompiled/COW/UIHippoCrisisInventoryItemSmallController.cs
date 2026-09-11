using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisInventoryItemSmallController : UIBaseController
{
	private UIHippoCrisisInventoryItemSmallView m_View;

	private IHippoCrisisBackPackItemUIData m_Data;

	private HippoCrisisStoreItemData m_CurStoreData;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private HENEHAGJCLI m_ItemData;

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

	public void SetViewData(IHippoCrisisBackPackItemUIData data)
	{
	}

	public void SetViewData(HippoCrisisStoreItemData data)
	{
	}

	private void RefreshItemView()
	{
	}

	public void SetWeaponAttachmentViewData(IHippoCrisisBackPackItemUIData data, GIANNEDDMLL attachmentType)
	{
	}

	public void SetMainWeaponAttachmentDefaultView(GIANNEDDMLL attachmentType)
	{
	}

	public void SetEquipmentAttachmentDefaultView()
	{
	}

	public void SetEmptyDefaultView()
	{
	}

	public void SetEmptySlotDefaultView(EHippoCrisisEquipmentSlot eSlot)
	{
	}

	private void ResetView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
