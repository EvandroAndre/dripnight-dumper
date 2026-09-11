using GCommon;
using UnityEngine;

namespace COW;

public class UISwitchScriptMenuView : UIBaseView
{
	public UILabel Title;

	public GameObject ScrollViewDownContainer;

	public UIButton OpenBtn;

	public UISprite BtnSprite;

	public UISprite BGDown;

	public UITable Table;

	public UIScrollView ScrollView;

	public GameObject FrameSelected;

	public UISprite IconSprite;

	public UINetworkTexture IconTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
