using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSeafoodLittleGirlGameController : UIBaseController
{
	private UIHudSeafoodLittleGirlGameView m_View;

	private GameObject m_warningHud;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void ResetState()
	{
	}

	private void OnEnterLittleGirl()
	{
	}

	private void OnExitLittleGirl()
	{
	}

	private void OnLittleGirlStateChange(object[] datas)
	{
	}

	private void OnLittleGirlDetectStateChange(object[] datas)
	{
	}

	private void UpdateLittleGirlState(LevelSeafoodLittleGirl littleGirl, bool realChangeState = false)
	{
	}

	private void PlayReadTextAudio()
	{
	}

	private void LateUpdate()
	{
	}

	private GameObject PoolGetResetRes(ResourceID resId, Transform targetParent = null)
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void HideWarning()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
