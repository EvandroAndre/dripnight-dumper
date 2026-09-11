using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDHGEliteHPController : UIBaseController
{
	private UIHUDHGEliteHPView m_View;

	private BHGGAEEHJCO m_BindId;

	private Camera m_FollowCamera;

	private Camera m_UICamera;

	private Vector3 m_LastNamePos;

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

	protected override void OnUIOpen()
	{
	}

	private void InitCamera()
	{
	}

	public void BindAI(BHGGAEEHJCO aiId)
	{
	}

	public void UpdateHp(uint curHP, uint maxHP)
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdatePos()
	{
	}

	private Vector3 GetAIRefPos(NetworkAIPawn ai)
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
