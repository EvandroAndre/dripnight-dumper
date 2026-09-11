using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonYearRewardItemView : UIBaseView
{
	public Animation DelayShowAnim;

	public GameObject RewardName;

	public VFXCreateHelper UIFXBigReward;

	public UIButton ClaimBtn;

	public Transform ItemTransform;

	public UILabel HeroicCntLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
