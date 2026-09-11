using System;
using GCommon;

namespace COW;

public class UIRoomMatchMakingWaitingController : UIBaseController, IUIModelDataChangeObserver
{
	private UIRoomMatchMakingWaitingView m_View;

	private float m_Time;

	private int m_TimeoutS;

	private Action m_OnTimeout;

	public Action OnCancel;

	private UIModelCustomRoom m_ModelRoom;

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

	private void Update()
	{
	}

	protected void OnBtnCancel()
	{
	}

	private void OnBtnBackToRoom()
	{
	}

	private void InitBackRoomBtn()
	{
	}

	public void SetCancelBtnEnable(bool enable)
	{
	}

	public void SetTimeout(int timeout, Action callback)
	{
	}

	public void RefreshUI()
	{
	}

	public void ShowCancelBtn(object[] data)
	{
	}

	public void ShowBackRoomBtn(object[] data)
	{
	}

	public void CloseBackRoomBtn(object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
