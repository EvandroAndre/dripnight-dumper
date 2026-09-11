using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILadderLeaderBoardEnterWndController : UIPopupWindowController, IEasyList
{
	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeader;

	private UILadderLeaderBoardEnterWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void AddDelegate()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnDetailGoposBtnClick()
	{
	}

	private void SetShareUIVisiable(bool isScreenShot)
	{
	}

	public void ShowItemWithDifferentMode()
	{
	}

	private void ProcessGMTitle(List<UILadderLeaderBoardEnterWndItemData> itemDataList, out int gmBRNum, out int gmCSNum)
	{
		gmBRNum = default(int);
		gmCSNum = default(int);
	}

	private void ProcessNewRankTitle(List<UILadderLeaderBoardEnterWndItemData> itemDataList, int gmBRNum, int gmCSNum, out long startDateTimeStamp, out long endDateTimeStamp, out int rankingNums)
	{
		startDateTimeStamp = default(long);
		endDateTimeStamp = default(long);
		rankingNums = default(int);
	}

	private void ProcessNewPeakTitle(List<UILadderLeaderBoardEnterWndItemData> itemDataList, out long startDateTimeStamp, out long endDateTimeStamp, out int peakNums)
	{
		startDateTimeStamp = default(long);
		endDateTimeStamp = default(long);
		peakNums = default(int);
	}

	private void ProcessNewWeaponTitle(List<UILadderLeaderBoardEnterWndItemData> itemDataList, out long startDateTimeStamp, out long endDateTimeStamp, out int wpNums)
	{
		startDateTimeStamp = default(long);
		endDateTimeStamp = default(long);
		wpNums = default(int);
	}

	private void ProcessSplitTitle(List<UILadderLeaderBoardEnterWndItemData> itemDataList, int rankNums, int wpNums, int peakNums)
	{
	}

	private void InitView()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private int SortRuleGM(UILadderLeaderBoardEnterWndItemData itemA, UILadderLeaderBoardEnterWndItemData itemB)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
