using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleLevelDetailTipsPopupView : UIBaseView
{
	public Transform ContentRoot;

	public UITable ContentTable;

	public UILabel BuildNameText;

	public UILabel LevelText;

	public UILabel BuildDescText;

	public UIGrid DetailedAbilities;

	public UISprite ConnectLineShadow;

	public UISprite ConnectLineColor;

	public UISprite BG;

	public GameObject ClickMask;

	public GameObject TutorialContentRoot;

	public UISprite SpriteCircle;

	public UISprite AnchoredSpriteCircle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
