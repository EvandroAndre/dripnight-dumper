using GCommon;
using UnityEngine;

namespace COW;

public class UILootBoxCustomWndView : UIBaseView
{
	public GameObject UILootBoxCustomWnd;

	public UILabel WndTitle;

	public UITexture TitleLabelCDN;

	public UITexture TitleBgCDN;

	public UISprite TitleBgNormal;

	public UILabel TipsLabel;

	public UIButton ClearButton;

	public UILabel Counter;

	public UIScrollView SelectedWordScrollView;

	public UIEasyList SelectedWordEasyList;

	public UIScrollView OptionalWordScrollView;

	public UIEasyList OptionalWordEasyList;

	public UIButton CloseBtn;

	public UIButton ComfirmBtn;

	public UINetworkTexture WndBg;

	public UISprite DefaultWndBg;

	public UINetworkTexture EnableBg;

	public GameObject ConfigBg;

	public GameObject DefaultBg;

	public UISprite DefaultEnableBg;

	public UIScrollView OptionalEmoteScrollView;

	public UIEasyList OptionalEmoteEasyList;

	public UILabel BtnText;

	public UISprite DefaultDisableBg;

	public UITexture DisableBg;

	public GameObject OptionalMixedContainer;

	public UIPanel UIPanelOptionalMixedScrollView;

	public UIScrollView UIScrollViewOptionalMixedScrollView;

	public UITable2 OptionalMixedTable2;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
