using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultSpecialBonusItemView : UIBaseView
{
	public UISprite BonusIcon;

	public UILabel BonusText;

	public GameObject ExtraStarUIFX;

	public GameObject NormalStyleContainer;

	public GameObject BattlePointsRankUpgradeContainer;

	public UILabel BattlePointsRankUpgradeLabel;

	public GameObject WinNoStarContainer;

	public UILabel ToxicBehaviorLabel;

	public UILabel ToxicPunishmentLabelOne;

	public UILabel ToxicPunishmentLabelTwo;

	public GameObject TipsBtnContainer;

	public UIButton TipsBtn;

	public Transform TipsBtnTransform;

	public UISprite LoserMvpIcon;

	public GameObject KingScoreUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
