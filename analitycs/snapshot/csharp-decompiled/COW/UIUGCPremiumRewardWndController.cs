using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCPremiumRewardWndController : UIPopupWindowController, IEasyList
{
	public enum SourceFrom
	{
		UGC_Premium,
		Collaboration
	}

	private UIUGCPremiumRewardWndView m_View;

	private SourceFrom m_SourceFrom;

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

	public void SetData(string title, string desc, List<UGCPremiumBenefitData> benefitDatas)
	{
	}

	public void SetData(List<WorkShopCollaborationResources> datas)
	{
	}

	private void OnClickMask()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
