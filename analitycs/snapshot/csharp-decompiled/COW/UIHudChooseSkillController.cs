using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillController : UIBaseController
{
	private UIHudChooseSkillView m_View;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private UIRoot m_UIRoot;

	private float m_EndTime;

	private bool m_SkillItemInited;

	private int m_CurrentPage;

	private List<UIHudChooseSkillPresetItemController> m_PresetCtrlList;

	private List<UIHudChooseSkillCustomItemController> m_CustomCtrlList;

	private UIHudChooseSkillActiveSkillItemController m_ActiveSkill1Ctrl;

	private UIHudChooseSkillActiveSkillItemController m_ActiveSkill2Ctrl;

	private List<UIHudChooseSkillPassiveSkillItemController> m_PassiveSkillCtrlList;

	private bool m_NeedChangePos;

	private DCGLAMHMJDE m_PopoverPos;

	private IJEECINPHFI m_CSMatch;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void InitData()
	{
	}

	private void ChoosePreset(uint presetId)
	{
	}

	private void ChooseCustom(uint skillId1, uint skillId2)
	{
	}

	private void RemovePassive(uint passiveSkillID)
	{
	}

	private void InitToggle()
	{
	}

	private void OnPresetToggleSelected()
	{
	}

	private void OnCustomToggleSelected()
	{
	}

	private void OnToggleSwitched(int pageIndex)
	{
	}

	private void InitSkillDisplay()
	{
	}

	private void ClosePopover()
	{
	}

	private void OpenPopover()
	{
	}

	private void SetPopoverContent(uint skillID)
	{
	}

	private void SetPopoverPos(Vector3 itemPos)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
