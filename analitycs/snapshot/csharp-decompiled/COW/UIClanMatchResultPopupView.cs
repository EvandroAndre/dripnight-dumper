using GCommon;
using UnityEngine;

namespace COW;

public class UIClanMatchResultPopupView : UIBaseView
{
	public UIButton BtnConfirm;

	public GameObject Content;

	public UILabel OtherClanName;

	public UISprite ClanAvatar;

	public UICenterTargetHelper CenterHelper;

	public UISprite NationIcon;

	public UILabel ClanName;

	public UILabel TotalScAdd;

	public UILabel KillNumAdd;

	public UILabel DamageNumAdd;

	public UILabel RankScAdd;

	public UILabel BattleScAdd;

	public UILabel ServivedLabel;

	public UILabel SurviveTimeAdd;

	public GameObject SeasonIcon;

	public GameObject OtherIcons;

	public GameObject ThirdPartyIcon;

	public UINetworkTexture NetworkTexture;

	public UILabel ModeName;

	public GameObject CarbinRetreat;

	public UILabel CarbinRetreatPointLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
