using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudHippoCrisisWeaponSlotItemController : UIHudHippoCrisisEquipmentBaseController
{
	private UIHudHippoCrisisWeaponSlotItemView m_View;

	private GIANNEDDMLL m_WeaponAttachType;

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

	public override void OnClickBtn()
	{
	}

	public void RefreshUI()
	{
	}

	public void SetAttachSlot(int attachSlotType)
	{
	}

	public void RefreshEmptyIcon()
	{
	}

	public void RefreshLevel()
	{
	}

	public void EnableClick(bool enable)
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
