using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCRoomListItemView : UIBaseView
{
	public UIButton UIButtonUIUGCRoomListItem;

	public UIWidget UIWidgetUIUGCRoomListItem;

	public TweenPosition TweenPositionUIUGCRoomListItem;

	public TweenAlpha TweenAlphaUIUGCRoomListItem;

	public UILabel MapName;

	public UISprite Map;

	public UITable RoomStats;

	public GameObject Lock;

	public GameObject Emulator;

	public UILabel Status;

	public UILabel Players;

	public UILabel ModeName;

	public Animation InAnim;

	public GameObject SelectedBg;

	public UILabel Name;

	public GameObject InGameMask;

	public UISprite Icon;

	public UINetworkTexture CDNMap;

	public GameObject NotifyUpdateTip;

	public GameObject AdvRoomBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
