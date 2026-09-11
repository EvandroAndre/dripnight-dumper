using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUpdateLogView : UIBaseView
{
	public UITable Table;

	public UILabel Title;

	public UILabel Content;

	public UILabel WindowTitle;

	public UIButton BtnWeb;

	public UIButton BtnClose;

	public UINetworkTexture TextureBg;

	public UINetworkTexture CloseTexture;

	public GameObject CloseSprite;

	public UIScrollView ScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
