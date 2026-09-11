using GCommon;
using UnityEngine;

namespace COW;

public class UIAnnouncementGetRewardView : UIBaseView
{
	public UISprite BG;

	public UILabel RewardTitle;

	public UIGrid AwardGrid;

	public UIButton OKBtn;

	public UILabel BtnLabel;

	public UILabel TransferItemHint;

	public UIButton FastEquipBtn;

	public GameObject CenterPosGO;

	public UIButton GoToSharePreViewBtn;

	public Animator ShareIconAnimator;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
