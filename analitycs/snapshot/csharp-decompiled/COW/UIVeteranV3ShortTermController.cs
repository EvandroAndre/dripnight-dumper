using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIVeteranV3ShortTermController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIVeteranV3ShortTermView m_View;

	private UIModelVeteran m_ModelVeteran;

	private List<Transform> m_ListRewardItemPos;

	private ClientVeteranTaskDesc m_MissionDesc;

	private uint m_DelayCallClose;

	private readonly List<UIVeteranV3ShortTermRewardItemController> m_ShortTermAwardCtrlList;

	private int m_CurRewardIndex;

	private const string VETERAN_PLAYERPREFS_PRIVILEGE_SHORTTERM = "VeteranPrivilegeShortTerm_{0}";

	private const int SHORTTERM_RAWARD_NUM = 4;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void OnPrivilegeClick()
	{
	}

	private void OnGotoClick()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void HideUI()
	{
	}

	private void ShowUI()
	{
	}

	private void PrepareCtrl()
	{
	}

	private void RefreshDailyRewardAndTask(int index)
	{
	}

	private void RefreshCurArrowIcon(int index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshCountTime()
	{
	}

	private void CloseWnd()
	{
	}

	private void CLosePopWnd()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
