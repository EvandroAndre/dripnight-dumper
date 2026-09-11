using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudHippoCrisisEquipmentItemController : UIHudHippoCrisisEquipmentBaseController
{
	private UIHudHippoCrisisEquipmentItemView m_View;

	private HENEHAGJCLI m_ItemData;

	private UIHudHippoCrisisEquipmentItemAttachController m_AttachController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(EHippoCrisisEquipmentSlot slotType, IHippoCrisisBackPackItemUIData data, EDragReleaseResponseAreaType areaType)
	{
	}

	private void SetDataAttachment()
	{
	}

	public void RefreshUI()
	{
	}

	private void RefreshDurability()
	{
	}

	public UIWidget GetDragWidget()
	{
		return null;
	}

	public void RefreshAttachBreathVFX(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(EHippoCrisisEquipmentSlot P0, IHippoCrisisBackPackItemUIData P1, EDragReleaseResponseAreaType P2)
	{
	}
}
