using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHighLightSettingItemView : UIBaseView
{
	public UILabel Time;

	public UISprite Icon;

	public UILabel Name;

	public UIButton Toggle;

	public GameObject unselected;

	public GameObject selected;

	public UIDragScrollView UIHudHighLightSettingItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
