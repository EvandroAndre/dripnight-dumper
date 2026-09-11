using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditTemplateMapItemView : UIBaseView
{
	public GameObject LockState;

	public UISprite SlotIcon;

	public UILabel UpdateTime;

	public UINetworkTexture CdnSlotIcon;

	public GameObject GameMap;

	public UILabel NameText;

	public UIButton Btn;

	public UISprite SpecialStateMask;

	public UILabel LockTxt;

	public UISprite WarningIcon;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite HotIcon;

	public UISprite IconItemSpite;

	public UITexture GameMapBg;

	public UIGrid TagContainer;

	public UILabel modeName;

	public GameObject HotContainer;

	public UITable RightTable;

	public Transform LikeContainer;

	public GameObject NewUpdateTip;

	public GameObject OfflineTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
