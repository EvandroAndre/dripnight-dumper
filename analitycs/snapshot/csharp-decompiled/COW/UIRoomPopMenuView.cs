using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomPopMenuView : UIBaseView
{
	public UIPanel WindowPanel;

	public UIButton Mask;

	public UIWidget Container;

	public UISprite PlayerInfoPanel;

	public UIEffectSprite Portrait;

	public GameObject FakeHead;

	public UIButton AddBtn;

	public GameObject NamePos;

	public UILabel Name;

	public UIGrid ItemGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
