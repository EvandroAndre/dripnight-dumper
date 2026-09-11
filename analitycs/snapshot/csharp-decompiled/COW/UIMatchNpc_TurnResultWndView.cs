using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_TurnResultWndView : UIBaseView
{
	public UINetworkTexture BgTexture;

	public UINetworkTexture Title;

	public GameObject ResultContent;

	public UILabel GainNum;

	public UILabel PlayerGainNum;

	public UILabel NpcGainNum;

	public GameObject WinExtraProcessDescLabel;

	public UILabel WinEtraNum;

	public UILabel LoseTips;

	public UIButton OkBtn;

	public UINetworkTexture OkBtnBg;

	public UILabel PlayerGainDescLabel;

	public UILabel NpcGainDescLabel;

	public UINetworkTexture PlayerBg;

	public UILabel PlayerName;

	public UILabel PlayerScore;

	public UINetworkTexture NpcBg;

	public UILabel NpcName;

	public UILabel NpcScore;

	public UIButton Infoicon;

	public UILabel WinTips;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UINetworkTexture TextureBtnClose;

	public UINetworkTexture PlayerTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
