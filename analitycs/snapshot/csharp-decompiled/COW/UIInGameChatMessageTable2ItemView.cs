using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatMessageTable2ItemView : UIBaseView
{
	public UIEffectSprite HeadPicLeft;

	public UILabel NameLabelLeft;

	public UILabel SendTimeLabelLeft;

	public UILabel ContentLeft;

	public UIEffectSprite HeadPicRight;

	public UILabel NameLabelRight;

	public UILabel SendTimeLabelRight;

	public UILabel ContentRight;

	public UIButton BannerLeft;

	public UIButton BannerRight;

	public GameObject LeftLayout;

	public GameObject RightLayout;

	public Transform TipsTrans;

	public GameObject Container;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
