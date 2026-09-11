using GCommon;
using UnityEngine;

namespace COW;

public class UILegendClothVaultColorController : UIBaseController
{
	private UILegendClothVaultColorView m_View;

	private int m_LegendLevel;

	private Color m_Color;

	private bool m_Unlock;

	private bool m_Armed;

	private bool m_IsInInvotory;

	private bool m_IsTypeBig;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(LegendClothData data, bool isInInvotory, bool unLock)
	{
	}

	private void SetUnlock(bool canClick)
	{
	}

	private void OnClickBtnPick()
	{
	}

	private void OnColorPick(object[] data)
	{
	}

	private void OnSlotPick(object[] data)
	{
	}

	private void RefreshSelectType(int level)
	{
	}

	private void ChangeSlotArmState(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
