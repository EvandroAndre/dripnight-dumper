using System.Text;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisRevivePanelController : UIBaseController
{
	private enum EHippoCrisisReviveBtnState
	{
		CAN_REQUEST,
		IN_REQUEST_COOLDOWN,
		CAN_NOT_REQUEST
	}

	private static int REQUEST_REVIVE_COOL_DOWN_M_SEC;

	private static Color BG_ENABLE_COLOR;

	private static Color LABEL_ENABLE_COLOR;

	private static Color BG_DISABLE_COLOR;

	private static Color LABEL_DISABLE_COLOR;

	private static int PHASE_PREPARE_COUNT_DOWN_M_SEC;

	private UIHudHippoCrisisRevivePanelView m_View;

	private StringBuilder m_CoolDownStrBuilder;

	private int m_LastRequestClickTimeMS;

	private EHippoCrisisReviveBtnState m_CurReviveBtnState;

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

	private void OnQuitRevive(object[] data)
	{
	}

	private void RefreshState(bool isForce = false)
	{
	}

	private void RefreshCountDownLabel()
	{
	}

	private void OnPlayerReviveCountChanged(object[] data)
	{
	}

	private void OnRequestReviveClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
