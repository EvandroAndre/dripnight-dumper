using GCommon;
using UnityEngine;

namespace COW;

public class UI2dItemView : UIBaseView
{
	public GameObject ui2dparent;

	public UIPanel ui2dparentpanel;

	public UIWidget ItemViewContainer;

	public BaseItemView BaseItemInfo;

	public Transform stone;

	public UISprite ItemViewIcon;

	public Transform BannerItemView;

	public Transform HeadPicItemView;

	public Transform MusicItemView;

	public Transform BattleCardView;

	public Transform PhotoGroupTemplateView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
