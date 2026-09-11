using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSAbilityPointPopItemView : UIBaseView
{
	public UISprite DownHalfLine;

	public UISprite UpHalfLine;

	public GameObject ActiveState;

	public GameObject DeactiveState;

	public UISprite ActiveIcon;

	public UILabel ActiveDesc;

	public UISprite DeactiveIcon;

	public UILabel DeactiveDesc;

	public UISprite DeactiveBg;

	public UISprite ActiveBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
