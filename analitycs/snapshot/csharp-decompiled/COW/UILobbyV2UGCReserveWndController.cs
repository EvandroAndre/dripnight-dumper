using GCommon;
using UnityEngine;

namespace COW;

internal class UILobbyV2UGCReserveWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UILobbyV2UGCReserveWndView m_View;

	private UIModelTeamReserve m_ModelTeamReserve;

	private ulong m_AccountID;

	protected UIModelSceneEdit m_ModelSceneEdit;

	private SceneEditSlotInfo m_SlotInfo;

	private string m_WorkshopCode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnReserveBtnClick()
	{
	}

	private void OnWorkshopDetailClick()
	{
	}

	public void SetReserveDefaultBtnState()
	{
	}

	public void SetViewData(ulong accountID, string workshopCode)
	{
	}

	public void SetReserveStatus()
	{
	}

	public void SetPosition(Vector3 itemPos)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
