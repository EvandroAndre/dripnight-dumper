using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureRewardItemController : UIBaseController
{
	public enum EBigAwardBGVFXType
	{
		False,
		True
	}

	private UIPaymentSquadTreasureRewardItemView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private UIStandardItemMAXBController m_BubbleItemCtrl;

	private SquadTreasureAwardDesc m_AwardDesc;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private GameObject m_VFXObj;

	private ResourceID m_VFXResId;

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

	public void SetViewData(SquadTreasureAwardDesc awardDesc, int index)
	{
	}

	public void UpdateRewardProgress(uint progress)
	{
	}

	public void UpdateRewardTeamNumberVFX(uint progress)
	{
	}

	private void OnBtnClaimClick()
	{
	}

	private void OnBtnItemClick()
	{
	}

	private void RefreshBubble()
	{
	}

	private void RefreshBigAwardBubbleVFX()
	{
	}

	private void RefreshBigAwardBGVFX()
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	private void ChangeVFXObjActive(bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
