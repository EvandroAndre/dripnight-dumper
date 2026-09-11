using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarLeaderboardMemberView : UIBaseView
{
	public GameObject Rank1Sprite;

	public UINetworkTexture HeadTexture;

	public UILabel UserNameLabel;

	public UILabel ScoreLabel;

	public GameObject Rank2Sprite;

	public GameObject Rank3Sprite;

	public GameObject EmptyContainer;

	public GameObject InfoContainer;

	public UISprite HeadSprite;

	public UIButton MainButton;

	public GameObject ClanWarScore;

	public GameObject ClanActiveScore;

	public UILabel ActiveScoreLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
