using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudVehicleChipDeviceItem : UIBaseController, UITable2.IUITable2Item
{
	private UIHudVehicleChipDeviceItemView m_View;

	protected UIItem m_Item;

	private bool m_CurUseState;

	private float m_LastClickTime;

	private bool m_BtnMaskEnable;

	private uint m_AsyncLoadUIAtlasTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnClickUseBtn()
	{
	}

	private void Update()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void SendVehicleChipEnableChangeMsg()
	{
	}

	private void OnItemToggleChanged()
	{
	}

	public void SetUIData(UIItem item)
	{
	}

	private void RefreshStateShow()
	{
	}

	private void ChangeSprite(ResourceID resIcon)
	{
	}

	public virtual NAELPAAELNO GetItem()
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
