using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudHippoCrisisEquipmentController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__16_0;

		internal bool _003CRefreshBottom_003Eb__16_0(uint x)
		{
			return false;
		}
	}

	private UIHudHippoCrisiMainWeaponController m_UIMainWeapon1;

	private UIHudHippoCrisiMainWeaponController m_UIMainWeapon2;

	private UIHudHippoCrisisSmallWeaponController m_SecondaryWeapon;

	private UIHudHippoCrisisSmallWeaponController m_MeleeWeapon;

	private UIHudHippoCrisisEquipmentItemController m_Backpack;

	private UIHudHippoCrisisEquipmentItemController m_SkillChip;

	private UIHudHippoCrisisEquipmentItemController m_Helmet;

	private UIHudHippoCrisisEquipmentItemController m_BodyArmor;

	private UIHudHippoCrisisEquipmentView m_View;

	private UIModelHippoCrisis m_modelHippoCrisis;

	private List<uint> m_ConditionList;

	private IHippoCrisisEquipmentBackpackData m_Data;

	private bool IsOpenFromPrestart;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshBottom()
	{
	}

	public void SetData(IHippoCrisisEquipmentBackpackData data)
	{
	}

	public void OnDragStart(IHippoCrisisBackPackItemUIData dragData)
	{
	}

	private void OnDragStart_Attach(IHippoCrisisBackPackItemUIData dragData)
	{
	}

	private void OpenChildUI()
	{
	}

	public UIWidget GetDragWidgetBySlot(EHippoCrisisDragWidgetType slot)
	{
		return null;
	}

	public void RefreshData(IHippoCrisisEquipmentBackpackData data)
	{
	}

	private void OnRepairClick()
	{
	}

	public void SetOpenFromPrestart()
	{
	}

	private void RefreshEmptyWarning()
	{
	}

	private void OnClickCostItem()
	{
	}

	private void RefreshTotalValueLimit()
	{
	}

	private void OnValueTipsClick()
	{
	}

	private void OnMissionTokenChanged()
	{
	}

	private void OnPreStartConditionGoto(uint conditionType)
	{
	}

	public void HideAllSelected()
	{
	}

	public void SetGuideMaskState(bool show)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
