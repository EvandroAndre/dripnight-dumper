using GCommon;
using UnityEngine;

namespace COW;

public class UIBRRankIconView : UIBaseView
{
	public UISprite BRRankIconSprite;

	public Transform BRRankIconUIFXContainer;

	public GameObject BRStarContainer;

	public GameObject BRGrandMasterRankContainer;

	public UILabel RankLabel;

	public UISprite RankLabelBG;

	public UILabel BRRankScoreLabel;

	public GameObject star;

	public GameObject star2;

	public GameObject star3;

	public GameObject star4;

	public GameObject star5;

	public Transform BRRankIconContainer;

	public Transform BRRankIconWithoutStarTransform;

	public Transform GrandMasterBRRankIconTransform;

	public GameObject CrossMatchModeSpriteContainer;

	public Transform CrossMatchModeUIFXContainer;

	public UISprite LeftSprite;

	public UISprite RightSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
