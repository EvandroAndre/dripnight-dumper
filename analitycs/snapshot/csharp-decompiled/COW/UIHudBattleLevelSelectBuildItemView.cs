using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelSelectBuildItemView : UIBaseView
{
	public UISprite BuildAvatarIcon;

	public UISprite BuildIcon;

	public UILabel BuildNameText;

	public GameObject PlayerIcon_1P;

	public GameObject PlayerIcon_3P;

	public Transform Content;

	public GameObject SelectedGroup;

	public GameObject SelectedVFX;

	public UIButton SelectClickBtn;

	public UIGrid SelectedPlayers;

	public UISprite ConnectLineShadow;

	public UISprite ConnectLineColor;

	public UIGrid BriefAbilities;

	public UIWidget BriefAbilitiesWidget;

	public UIGrid DetailedAbilities;

	public UIWidget DetailedAbilitiesWidget;

	public Transform BuildStyleBgRoot;

	public Animation CenterAnim;

	public GameObject BattleLevelDesc;

	public GameObject EightInfiniteEffectDesc;

	public UILabel EffectDesc;

	public UILabel EffectName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
