using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_ExchangeStoreView : UIBaseView
{
	public UINetworkTexture StoreBGCDN;

	public UINetworkTexture StoreTitleCDN;

	public UIButton BtnRule;

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

	public UINetworkTexture ClassicLock;

	public GameObject LockSpecial;

	public UINetworkTexture SpecialLock;

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

	public Object contentAni;

	public UIButton BtnCloseDefault;

	public UISprite IconDate;

	public UILabel ClassicUnSelectLabel;

	public UILabel SpecialUnSelectLabel;

	public UINetworkTexture TextureSpecialBubble;

	public UILabel SpecialStoreOpenDateLabel;

	public Transform TokenItemTrans;

	public UINetworkTexture CDNIconClose;

	public GameObject IconClose;

	public UINetworkTexture ClassicSelectBG;

	public UINetworkTexture ClassicUnselectBG;

	public UINetworkTexture SpecialSelectBG;

	public UINetworkTexture SpecialUnselectBG;

	public UILabel Label;

	public UINetworkTexture Arrow;

	public UICountDownLabel LabelDate;

	public UINetworkTexture TextureCheckBg;

	public UINetworkTexture TextureCheck;

	public UISprite SpriteCheck;

	public UISprite SpriteCheckBg;

	public Animation Animation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
