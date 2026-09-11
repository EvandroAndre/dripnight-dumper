using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIProfileRecentVisitorPopWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum EVisitorTabType
	{
		None,
		eProfileVisit,
		eSpectatVisit
	}

	private EVisitorTabType m_CurTabType;

	private UIProfileRecentVisitorPopWndView m_View;

	private UIModelProfile m_ModelProfile;

	private CSGetInteractionRecordRes m_InteractionInfo;

	private const uint MAX_SHOWVISITOR = 9999u;

	private List<CSGetVisitorsRes.VisitorRecord> m_RecentVisitorRecord;

	private UIPopWndStandardDrawerTabRemakeController m_TabCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override string Rule()
	{
		return null;
	}

	private void InitToggles()
	{
	}

	private void RefreshVisitorNumView()
	{
	}

	private void OnSelectProfileVisit()
	{
	}

	private void OnSelectSpectatVisit()
	{
	}

	private void RefreshPorfileView()
	{
	}

	private void RefreshSpectatView()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public Transform GetBriefboxPosition()
	{
		return null;
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

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
