using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSMissionPopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UINinthSYSMissionPopupWndView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelNinthSYS m_UIModelNinthSYS;

	private List<UIModelNinthSYS.INinthSYSMissionData> m_MissionDataList;

	private bool m_HasTokenInfo;

	private bool m_Instantiated;

	private Vector2 ITEM_SIZE;

	private Vector2 ITEM_SIZE_SPECIAL;

	private readonly int SPECIAL_TYPE;

	private readonly int NORMAL_TYPE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnClickClose()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void LogClick(string posfix)
	{
	}

	private void CaculateAllClaimedBtnStateAndDailyLimit()
	{
	}

	private void OnClickAllClaimedBtn()
	{
	}

	private void InitTable2Template()
	{
	}

	private void InitMissionView()
	{
	}

	private void ReloadMissionView()
	{
	}

	private void RefreshMissionView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__20_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__20_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
