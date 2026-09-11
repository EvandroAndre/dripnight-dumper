using GCommon;
using UnityEngine;

namespace COW;

public class UIHudScoutStateView : UIBaseView
{
	public UILabel LabelHP;

	public UISprite HPBar;

	public InGameHPDamageEffect HPDamage;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
