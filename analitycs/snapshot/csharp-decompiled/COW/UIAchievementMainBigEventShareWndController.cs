using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAchievementMainBigEventShareWndController : UIAchievementMainBigEventCollectionWndController
{
	public Vector3 MAIN_SHARE_SCALE;

	public Vector3 MAIN_SHARE_POS;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(List<AchievementEntryInfo> data, EBigEventCollectionWndType type, string typeKey, uint completedNum, uint allNum)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override void AfterPopupGlassBgReady()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_AfterPopupGlassBgReady()
	{
	}
}
