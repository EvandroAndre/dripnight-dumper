using GCommon;
using UnityEngine;

namespace COW;

public class UINewKeyActionItemView : UIBaseView
{
	public UIWidget Widget;

	public UILabel KeyDescLabel;

	public GameObject CanNotModifyMask;

	public GameObject SelectedFrame;

	public UILabel KeyCodeLabel;

	public UISprite KeyCodeSprite;

	public UIButton KeyCodeButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
