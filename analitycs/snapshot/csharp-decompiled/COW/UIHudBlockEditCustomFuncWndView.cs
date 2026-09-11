using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditCustomFuncWndView : UIBaseView
{
	public UIGrid Grid;

	public UIButton BtnAddParam;

	public UIButton BtnAddReturnVal;

	public UILabel NoReturnValLabel;

	public UIHudBlockEditCustomFuncItemController FuncParamTemplate;

	public UIHudBlockEditCustomFuncItemController ReturnItem;

	public UIButton BtnApply;

	public UIHudBlockEditCustomFuncItemController FuncName;

	public GameObject NoParams;

	public UIToggle OFF;

	public UIToggle ON;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
