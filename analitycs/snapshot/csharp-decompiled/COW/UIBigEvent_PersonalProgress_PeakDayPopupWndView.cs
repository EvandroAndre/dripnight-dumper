using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgress_PeakDayPopupWndView : UIBaseView
{
	public UILabel LabelTitle;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UILabel LabelDesc;

	public UIGrid GridAwardContainer;

	public GameObject GoClaim;

	public GameObject LabelCantClaim;

	public UIButton BtnClaim;

	public GameObject GoClaimed;

	public GameObject GoExpired;

	public UINetworkTexture TextureBg;

	public UINetworkTexture TextureTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
