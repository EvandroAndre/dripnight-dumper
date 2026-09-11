using GCommon;
using UnityEngine;

namespace COW;

public class UINewPlayerV3SignItemView : UIBaseView
{
	public Transform ItemSignCon;

	public UIButton SignClaimBtn;

	public GameObject LockTitle;

	public GameObject UnlockTitle;

	public UILabel LockDayLabel;

	public UILabel UnlockDayLabel;

	public GameObject ItemBigRewardCon;

	public UIButton BigRewardClaimBtn;

	public GameObject RewardLoop;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
