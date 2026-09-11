using GCommon;
using UnityEngine;

namespace COW;

public class UIRelationshipRewardItemView : UIBaseView
{
	public GameObject AwardItemSmallLockState;

	public GameObject Cloth;

	public UILabel NeedRankLabel;

	public GameObject AwardItemReceiveState;

	public GameObject AwardItemCanReceiveState;

	public UIButton GainRewardBtn;

	public GameObject AwardItemBigLockState;

	public Transform DetailTipPos;

	public GameObject AwardItemContainer;

	public GameObject AwardShareSkillsContainer;

	public GameObject AwardShareSkillsLockState;

	public GameObject AwardShareSkillsCanReceiveState;

	public GameObject AwardShareSkillsAlreadyReceiveState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
