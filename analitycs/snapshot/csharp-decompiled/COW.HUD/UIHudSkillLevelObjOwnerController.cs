using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudSkillLevelObjOwnerController : UIBaseController
{
	private UIHudSkillLevelObjOwnerView m_View;

	private UIModelGroup m_ModelGroup;

	private Transform m_SelfTransform;

	private Camera m_WorldCamera;

	private Camera m_UICamera;

	private Transform m_BindedTransform;

	private Vector3 m_BindedOffset;

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

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public override void OnRecyle()
	{
	}

	internal void Bind(Transform transform, Vector3 offset, Player player)
	{
	}

	internal void Unbind()
	{
	}

	private void UpdateTeamIndex(Player player)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	private void InitCamera()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdatePosition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}
}
