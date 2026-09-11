using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudHippoCrisisEquipmentItemAttachController : UIHudHippoCrisisEquipmentBaseController
{
	private UIHudHippoCrisisEquipmentItemAttachView m_View;

	private HENEHAGJCLI m_ItemData;

	private DJLDPFMKPIH m_EquipmentAttachType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(EHippoCrisisEquipmentSlot slot, IHippoCrisisBackPackItemUIData data, EDragReleaseResponseAreaType areaType)
	{
	}

	public void RefreshUI()
	{
	}

	public void SetAttachSlotType(DJLDPFMKPIH eEquipmentAttachmentType)
	{
	}

	public override void OnClickBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(EHippoCrisisEquipmentSlot P0, IHippoCrisisBackPackItemUIData P1, EDragReleaseResponseAreaType P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickBtn()
	{
	}
}
