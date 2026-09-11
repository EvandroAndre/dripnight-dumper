using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSDualActiveSkillPopWndController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__30_0;

		public static Action _003C_003E9__30_1;

		internal void _003CSetControllerCursorEvent_003Eb__30_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__30_1()
		{
		}
	}

	private UIHudCSDualActiveSkillPopWndView m_View;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private UIRoot m_UIRoot;

	private float m_EndTime;

	private bool m_NeedChangePos;

	private DCGLAMHMJDE m_PopoverPos;

	private bool m_SkillItemInited;

	private int m_SelectedNum;

	private UIHudChooseSkillSlotController m_ActiveSkill1Ctrl;

	private UIHudChooseSkillSlotController m_ActiveSkill2Ctrl;

	private List<UIHudChooseSkillCustomItemController> m_CustomCtrlList;

	private uint m_TipDelay;

	private int m_LastSelectedNum;

	private int m_CountDownDisplay;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetControlStatus(bool isEnable)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitSkillDisplay()
	{
	}

	private void InitData()
	{
	}

	private void CalculateHeightData()
	{
	}

	private void ChooseCustom()
	{
	}

	private void UpdateScroll()
	{
	}

	private void OpenPopover()
	{
	}

	private void ClosePopover()
	{
	}

	private void SetPopoverContent(uint skillID)
	{
	}

	private void SetPopoverPos(Vector3 itemPos)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void ShowTip()
	{
	}

	private void Update()
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	private void _003CShowTip_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
