using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCTutorialTaskHintView : UIBaseView
{
	public UILabel TaskHintLabel;

	public UIPanel UIHudUGCTutorialTaskHint;

	public UIGroupWaitingDropItem DragDropItem;

	public BoxCollider DragDropItemCollider;

	public GameObject UIEffect;

	public UISprite TextBG;

	public UIButton BGMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
