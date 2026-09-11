using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIRoomParamsInRoomItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIRoomParamsInRoomItemView m_View;

	private KDPGIMNMLFE m_ParamData;

	private static readonly int OverFlowWidth;

	private string m_TipsString;

	private Vector3 m_ValuePos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(KDPGIMNMLFE data)
	{
	}

	private void OnMoreBtnClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshUI()
	{
	}

	public void RefreshLocKey()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
