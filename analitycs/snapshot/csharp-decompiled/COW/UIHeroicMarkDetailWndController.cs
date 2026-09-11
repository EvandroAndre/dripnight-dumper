using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHeroicMarkDetailWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum TabType
	{
		BR,
		CS,
		CSPEAKTOURNAMENT
	}

	private UIHeroicMarkDetailWndView m_View;

	private UIModelProfile m_Model;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private string m_Tab;

	private ulong m_CacheAccountID;

	private bool isDataReady;

	private bool hasInitInfo;

	private bool m_IsUserSelf;

	private List<UIHeroicMarkItemCtrl> m_MarkItems;

	private uint cellCntPerLine;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnMoreDetailClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnSelectRule(object[] data)
	{
	}

	private void GotoTab()
	{
	}

	private void RefreshInfo()
	{
	}

	private void CreateTab()
	{
	}

	public void Init(ulong account_id, string tab)
	{
	}

	private void UpdateDesc(string tabType)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
