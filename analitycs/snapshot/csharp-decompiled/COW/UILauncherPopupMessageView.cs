using GCommon;
using UnityEngine;

namespace COW;

public class UILauncherPopupMessageView : UIBaseView
{
	public UIPanel MainWidget;

	public UIPanel FullScreenRect;

	public GameObject VersionNode;

	public GameObject CDNList;

	public UIScrollView CDNScrollView;

	public UIPanel CDNScrollViewPanel;

	public UINetworkTexture CdnTextureInstance;

	public UIGrid CDNGrid;

	public UIGrid DotGrid;

	public UIWidget WebView;

	public UINetworkTexture BillboardCDNBG;

	public UIButton BtnPatchNote;

	public UILabel BtnPatchLabel;

	public GameObject BtnOKGO;

	public UIButton BtnOK;

	public UILabel BtnOKLabel;

	public GameObject MaxHint;

	public GameObject UpdateLabel;

	public UILabel UpdateInfo;

	public GameObject TextInfo;

	public UILabel Info;

	public UILabel Title;

	public GameObject MaintenancePic;

	public GameObject ErrorPic;

	public GameObject UpdatePic;

	public UIButton TxtInfoOkBtn;

	public UILabel TxtInfoOkLabel;

	public UIButton BtnCompatibleLogin;

	public GameObject OfflinePlayPic;

	public GameObject OfflineTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
