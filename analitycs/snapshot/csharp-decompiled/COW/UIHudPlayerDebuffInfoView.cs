using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerDebuffInfoView : UIBaseView
{
	public UIEventListener PressBtn;

	public UISprite BG;

	public UITable DebuffTable;

	public UIHudPlayerDebuffItem DebuffItem;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
