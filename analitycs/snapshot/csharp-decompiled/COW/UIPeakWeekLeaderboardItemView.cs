using GCommon;
using UnityEngine;

namespace COW;

public class UIPeakWeekLeaderboardItemView : UIBaseView
{
	public GameObject rightScore;

	public UILabel rightRank;

	public UILabel rightScoreLabel;

	public GameObject leftScore;

	public UILabel leftRank;

	public UILabel leftScoreLabel;

	public GameObject upScore;

	public UILabel upScoreLabel;

	public GameObject FirstRank;

	public GameObject SecondRank;

	public GameObject ThirdRank;

	public Transform InfoPos;

	public GameObject PlayerInfo;

	public UIButton headbtnRight;

	public UIButton headbtnLeft;

	public UINetworkTexture HeadIconRight;

	public UIEffectSprite HeadSpriteRight;

	public GameObject FakeSpriteRight;

	public UILabel PlayerNameRight;

	public UINetworkTexture HeadIconLeft;

	public UIEffectSprite HeadSpriteLeft;

	public GameObject FakeSpriteLeft;

	public UILabel PlayerNameLeft;

	public UIButton PlayerCheckBtn;

	public GameObject myself_left;

	public GameObject myself_Right;

	public UILabel upScoreLabel_second;

	public UILabel upScoreLabel_third;

	public GameObject selfInleaderboard;

	public GameObject default_Right;

	public GameObject default_left;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
