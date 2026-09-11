using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_MatchMakingWaitingController : UIBaseController
{
	private UIHUDUGC_MatchMakingWaitingView m_View;

	private float m_Time;

	public Action OnCancel;

	private UIModelCustomRoom m_ModelRoom;

	private UIGroupWaitingDropItem m_DragDropItem;

	private bool m_StopMatchmakingOnUIDestroy;

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

	public void ShowCancelBtn(object[] data)
	{
	}

	public void InitDrag()
	{
	}

	private Vector2 GetBound()
	{
		return default(Vector2);
	}

	public void SetPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
