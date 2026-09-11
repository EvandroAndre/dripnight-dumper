using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleCommonView : UIBaseView
{
	public Transform IconPos;

	public UISprite BG;

	public UILabel RegionLabel;

	public UILabel NameLabel;

	public UIButton LeaderBoardTitleCommonBtn;

	public BoxCollider LeaderBoardTitleBoxCollider;

	public Animation AnimLeaderboardTitle;

	public GameObject LeaderboardTitle;

	public VFXCreateHelper UIFXPos;

	public GameObject BooyahBountyRoot;

	public GameObject TitleCommon;

	public UILabel TitleCommonLabel;

	public UIEffectSprite TitleCommonBg;

	public Transform TitlecommonVFXPos;

	public GameObject LeaderBoardAndCommonTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
