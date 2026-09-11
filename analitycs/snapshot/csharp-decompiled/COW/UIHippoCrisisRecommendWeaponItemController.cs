using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisRecommendWeaponItemController : UIBaseController
{
	private UIHippoCrisisRecommendWeaponItemView m_View;

	private AGACNOCEEFP m_WeaponConfigData;

	private Dictionary<int, Transform> AttachmentPosDic;

	private Dictionary<int, UIHudHippoCrisisWeaponSlotItemController> AttachmentCtrlDic;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private HENEHAGJCLI m_ItemData;

	private IHippoCrisisBackPackItemUIData m_Data;

	private HippoCrisisPreSetData m_PreSetData;

	private bool m_IsEmpty;

	private EHippoCrisisEquipmentSlot m_Slot;

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

	public void SetData(EHippoCrisisEquipmentSlot slot, IHippoCrisisBackPackItemUIData data)
	{
	}

	public void SetData(EHippoCrisisEquipmentSlot slot, HippoCrisisPreSetData data)
	{
	}

	public void CreateSlotItemCtrls()
	{
	}

	public void AddAttachment(List<IHippoCrisisBackPackItemUIData> attachments)
	{
	}

	public void RefreshUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
