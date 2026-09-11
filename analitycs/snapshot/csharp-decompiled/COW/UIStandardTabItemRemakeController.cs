using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabItemRemakeController : UIStandardTabItemController
{
	protected UIStandardTabItemRemakeView m_RemakeView;

	private static Color m_ColorLightGrey;

	private static Color m_ColorDark;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetNewTipsActive(bool active)
	{
	}

	protected override void PlayDoubleExpAnim()
	{
	}

	protected override UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	protected override void UpdateExtraSubTabView(bool value)
	{
	}

	public UIWidget GetButtonWidget()
	{
		return null;
	}

	public void SetDoubleExpState(bool show)
	{
	}

	public override void CheckTagState()
	{
	}

	public override void SetCountDownContainer()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private bool ShowCountDownCon()
	{
		return false;
	}

	public void SetRemakeSubTabItemRedPointIgnoreBounds(bool isIgnore)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_CheckTagState()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayDoubleExpAnim()
	{
	}

	public UIStandardSubTabItemController _003C_003EiFixBaseProxy_CreateSubTabItem(Transform P0, bool P1)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_UpdateExtraSubTabView(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetCountDownContainer()
	{
	}
}
