using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUnifiedMapSlot1View : UIBaseView
{
	public UIButton BtnClick;

	public UINetworkTexture CdnSlotIcon;

	public UITexture GameMapBg;

	public UILabel GameModeLabel;

	public UILabel MapNameLabel;

	public GameObject HotIndicator;

	public GameObject Kol;

	public UINetworkTextureExt KolAuthorIcon;

	public UILabel KolAuthorName;

	public UITexture GameBitOutLineMap;

	public UITexture GameBitMap;

	public UISprite IconItemSprite;

	public UISprite GameModeBg;

	public Transform Container;

	public UILabel PlayTime;

	public GameObject BottomContainer;

	public UIPanel MapContainer;

	public GameObject MapIcon;

	public GameObject LockState;

	public UILabel LockTxt;

	public UISprite WarningIcon;

	public GameObject OfflineTag;

	public Animation MapRoot;

	public UISprite Top;

	public GameObject DefaultAuthorIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
