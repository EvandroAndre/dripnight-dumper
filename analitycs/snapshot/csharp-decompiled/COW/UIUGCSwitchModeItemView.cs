using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCSwitchModeItemView : UIBaseView
{
	public UIButton UIUGCSwitchModeItem;

	public GameObject TagContainer;

	public UINetworkTexture CDNIcon;

	public UISprite Icon;

	public UILabel NameTxt;

	public GameObject SelectedBg;

	public GameObject HotIcon;

	public GameObject UnselectedBg;

	public GameObject NewIcon;

	public Transform UGCOptionalContainer;

	public GameObject DownloadBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
