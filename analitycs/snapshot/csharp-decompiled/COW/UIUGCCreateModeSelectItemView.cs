using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCreateModeSelectItemView : UIBaseView
{
	public UIButton UIUGCCreateModeSelectItem;

	public GameObject TagContainer;

	public UINetworkTexture CDNIcon;

	public GameObject SelectedBg;

	public GameObject HotIcon;

	public GameObject UnselectedBg;

	public GameObject NewIcon;

	public Transform UGCOptionalContainer;

	public GameObject DownloadBG;

	public GameObject LevelLimit;

	public UILabel level;

	public GameObject MapIcon;

	public UILabel TemplateTxt;

	public UILabel ModeNameTxt;

	public UILabel TemplateName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
