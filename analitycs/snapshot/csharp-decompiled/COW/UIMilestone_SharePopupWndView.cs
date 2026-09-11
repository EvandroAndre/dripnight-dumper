using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_SharePopupWndView : UIBaseView
{
	public UINetworkTextureExt Background;

	public UINetworkTextureExt SelectedDiTex1;

	public UINetworkTextureExt SelectedKuangTex1;

	public UINetworkTextureExt UnSelectedDiTex1;

	public UINetworkTextureExt Title1;

	public UINetworkTextureExt SelectedDiTex2;

	public UINetworkTextureExt SelectedKuangTex2;

	public UINetworkTextureExt UnSelectedDiTex2;

	public UINetworkTextureExt Title2;

	public UINetworkTextureExt SelectedDiTex3;

	public UINetworkTextureExt SelectedKuangTex3;

	public UINetworkTextureExt UnSelectedDiTex3;

	public UINetworkTextureExt Title3;

	public UIButton BtnClose;

	public GameObject CloseBtnSprite;

	public UINetworkTexture CloseBtnTexture;

	public UINetworkTexture BtnShareTexture;

	public UINetworkTextureExt GiftIcon;

	public UILabel GiftContentLabel;

	public GameObject main;

	public Transform DefaultItemPosition;

	public Transform ShareIconContainer;

	public UIButton BtnShare;

	public GameObject ShareGiftGo;

	public UINetworkTextureExt GiftBg;

	public UILabel BtnShareLabel;

	public UINetworkTextureExt ArrowIcon;

	public UIGrid TabGroup;

	public UIButton Tab1;

	public GameObject Tab1SelectedGo;

	public GameObject Tab1UnSelectedGo;

	public UIButton Tab2;

	public GameObject Tab2SelectedGo;

	public GameObject Tab2UnSelectedGo;

	public UIButton Tab3;

	public GameObject Tab3SelectedGo;

	public GameObject Tab3UnSelectedGo;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
