using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIBooyahPassPrivilegeWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum EPrivilegeWndType
	{
		ShowPrivilege,
		ActivePrivilege,
		GainPrivilege
	}

	private enum EActivePrivilegeStep
	{
		First,
		Second
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint curBpEventId;

		internal bool _003CCheckLastSeasonBpGrade_003Eb__0(BasicEPInfo x)
		{
			return false;
		}
	}

	private UIBooyahPassPrivilegeWndView m_View;

	private EPrivilegeWndType m_WndType;

	private EActivePrivilegeStep m_StepType;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIModelProfile m_ModelProfile;

	private List<UIBooyahPassImportantRewardMaxController> m_ItemCtrlList;

	private CommonRewardWindowStyleBaseController m_StyleBaseCtrl;

	private ulong m_AccountID;

	private BasicEPInfo m_LastSeapnsonEpInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefereshBgView()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(EPrivilegeWndType type)
	{
	}

	private void RefreshShowPrivilege()
	{
	}

	private void RefreshActivePrigilege()
	{
	}

	private void RefreshFirstStepView()
	{
	}

	private bool CheckLastSeasonBpGrade()
	{
		return false;
	}

	private void RefreshGainPrivilege()
	{
	}

	private void OnSkipMaskBtnClick()
	{
	}

	private void OnOkayBtnClick()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
