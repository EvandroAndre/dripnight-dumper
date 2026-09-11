using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStyleDetailedAbilityView : UIBaseView
{
	public UILabel AbilityLevel;

	public GameObject FilledNodeIcon;

	public UISprite AbilityIcon;

	public UILabel AbilityDescription;

	public GameObject EmptyNodeIcon;

	public GameObject ActiveBg;

	public UISprite ActiveBgSprite;

	public GameObject UnActivebg;

	public UILabel AbilityDescriptionUnlock;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
