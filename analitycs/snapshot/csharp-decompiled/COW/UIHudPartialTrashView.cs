using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPartialTrashView : UIBaseView
{
	public UISprite ItemIcon;

	public UILabel ItemName;

	public UIButton MinusBtn;

	public UIButton PlusBtn;

	public UILabel SelectCnt;

	public UILabel MaxCnt;

	public UIButton CancelBtn;

	public UIButton ComfirmBtn;

	public UISlider CntSlider;

	public UISprite BG;

	public UIWidget Upper;

	public UIWidget Downer;

	public UIWidget Center;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
