using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDWolfKillActionController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public GameObject flyEffect;

		public Vector3 targetPos;

		internal void _003CPlayKillEffect_003Eb__0()
		{
		}
	}

	private UIHUDWolfKillActionView m_View;

	private BHGGAEEHJCO m_TargetID;

	private bool m_IsInCD;

	private float m_CDEndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateValid()
	{
	}

	private void ChooseNewTarget()
	{
	}

	private bool IsPlayerValidTarget(Player player)
	{
		return false;
	}

	private bool CheckInKillRange(Vector3 targetPos)
	{
		return false;
	}

	private void UpdateCD()
	{
	}

	private void StopCD()
	{
	}

	private void OnActionEnable(bool isEnable)
	{
	}

	private void Kill()
	{
	}

	private void PlayKillEffect(Vector3 beginPos, Vector3 targetPos)
	{
	}

	private void OnKillCd(object[] data)
	{
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
