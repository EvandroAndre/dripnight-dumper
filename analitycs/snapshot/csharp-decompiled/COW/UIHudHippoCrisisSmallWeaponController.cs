using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudHippoCrisisSmallWeaponController : UIHudHippoCrisisEquipmentBaseController
{
	private UIHudHippoCrisisSmallWeaponView m_View;

	private AGACNOCEEFP m_WeaponConfigData;

	private HENEHAGJCLI m_ItemData;

	private EDragReleaseResponseAreaType m_areaType;

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

	private void RefreshAmmoLabel()
	{
	}

	public void RefreshUI()
	{
	}

	internal UIWidget GetDragWidget()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(EHippoCrisisEquipmentSlot P0, IHippoCrisisBackPackItemUIData P1, EDragReleaseResponseAreaType P2)
	{
	}
}
