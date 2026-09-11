using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2MatchStatusItemView : UIBaseView
{
	public GameObject New;

	public UILabel Rank;

	public UILabel Players;

	public UILabel Kill;

	public UILabel Time;

	public UILabel Points;

	public GameObject RankCS;

	public UILabel RankCSLabel;

	public UISprite RankCSSprite;

	public GameObject RankCSWin;

	public GameObject RankCSFail;

	public GameObject ScoreObj;

	public GameObject QuitClanLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
