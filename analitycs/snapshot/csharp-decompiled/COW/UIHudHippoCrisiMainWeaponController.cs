using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisiMainWeaponController : UIHudHippoCrisisEquipmentBaseController
{
	private UIHudHippoCrisiMainWeaponView m_View;

	private AGACNOCEEFP m_WeaponConfigData;

	private Dictionary<int, Transform> AttachmentPosDic;

	private Dictionary<int, UIHudHippoCrisisWeaponSlotItemController> AttachmentCtrlDic;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private EDragReleaseResponseAreaType m_AreaType;

	private HENEHAGJCLI m_ItemData;

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

	public void CreateSlotItemCtrls()
	{
	}

	public void RefreshUI()
	{
	}

	public UIWidget GetDragWidget()
	{
		return null;
	}

	public void RefreshAttachBreathVFX(IHippoCrisisBackPackItemUIData dragData, bool v)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(EHippoCrisisEquipmentSlot P0, IHippoCrisisBackPackItemUIData P1, EDragReleaseResponseAreaType P2)
	{
	}
}
