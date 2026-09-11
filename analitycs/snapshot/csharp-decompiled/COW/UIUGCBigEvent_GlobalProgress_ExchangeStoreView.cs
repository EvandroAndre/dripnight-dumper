using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCBigEvent_GlobalProgress_ExchangeStoreView : UIBaseView
{
	public UINetworkTexture StoreBGCDN;

	public UINetworkTexture StoreTitleCDN;

	public UIButton BtnRule;

	public UILabel LabelDate;

	public UIButton BtnClose;

	public GameObject ToggleClassic;

	public GameObject ToggleSpecial;

	public UIToggleButton ToggleBtnClassic;

	public UINetworkTexture ToggleClassicBGCDN;

	public UITexture ToggleClassicBG;

	public UINetworkTexture ToggleSpecialBGCDN;

	public UITexture ToggleSpecialBG;

	public UIToggleButton ToggleBtnSpecial;

	public GameObject LockClassic;

	public GameObject LockSpecial;

	public UIScrollView ScrollView;

	public UIEasyList EasyList;

	public UIButton RedTipsOnOffBtn;

	public GameObject Select;

	public GameObject LeftContainer;

	public UINetworkTexture ToggleClassicLogoCDN;

	public UINetworkTexture ToggleSpecialLogoCDN;

	public UILabel ClassicSelectLabel;

	public UILabel SpecialSelectLabel;

	public GameObject defaultView;

	public GameObject content;

	public UIButton BtnCloseDefault;

	public UISprite IconDate;

	public UILabel ClassicUnSelectLabel;

	public UILabel SpecialUnSelectLabel;

	public UINetworkTexture TextureSpecialBubble;

	public UILabel SpecialStoreOpenDateLabel;

	public Transform TokenItemTrans;

	public UINetworkTexture CDNIconClose;

	public GameObject IconClose;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
