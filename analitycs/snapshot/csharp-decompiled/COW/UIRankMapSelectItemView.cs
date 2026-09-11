using GCommon;
using UnityEngine;

namespace COW;

public class UIRankMapSelectItemView : UIBaseView
{
	public UIButton DragItem;

	public UISprite bg;

	public UISprite ModeSprite;

	public UINetworkTexture NetworkTexture;

	public GameObject DownloadRoot;

	public UICheckboxButton SelectButton;

	public GameObject Empty;

	public GameObject Selected;

	public UILabel MapName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
