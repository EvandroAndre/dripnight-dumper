using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTriggerGrenadeController : UIBaseController
{
	private UIHudTriggerGrenadeView m_View;

	private float m_EndTime;

	private float m_ExplosionTime;

	private Vector3 m_pos;

	private ResourceID m_BeepSoundID;

	private AudioResource m_AudioSource;

	private KIDGFPLCBCP m_Grenade;

	private float m_LastRemainingTime;

	private float m_LastProgress;

	private bool m_EnterDangerTime;

	private bool m_UGCVisible;

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

	public void ResetVisibilityOnOpenHud()
	{
	}

	public override void SetUGCVisibility(bool v)
	{
	}

	private void OnBtnClick()
	{
	}

	public UIHudGrenadeCancelController OpenCancelHud()
	{
		return null;
	}

	private void OnGrenadeTrigger()
	{
	}

	private void OnChangeVisible(object[] param)
	{
	}

	private void Update()
	{
	}

	public float Progress()
	{
		return 0f;
	}

	private void ResetStatus()
	{
	}

	private void OnExecute()
	{
	}

	private void ApplyUGCVisibility()
	{
	}

	public void SetDefaultPos(Vector3 pos)
	{
	}

	private void OnReleaseGrenadeTutorialInForceTutorialGame()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUGCVisibility(bool P0)
	{
	}
}
