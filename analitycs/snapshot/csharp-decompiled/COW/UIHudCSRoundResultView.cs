using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSRoundResultView : UIBaseView
{
	public UISprite wolf;

	public GameObject LeftTeam;

	public GameObject RightTeam;

	public GameObject winSprite;

	public GameObject loseSprite;

	public UILabel roundInfo;

	public GameObject coinsContainer;

	public UILabel coins;

	public UIGrid bonusGrid;

	public GameObject bonusItem;

	public UILabel LabelReason;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
