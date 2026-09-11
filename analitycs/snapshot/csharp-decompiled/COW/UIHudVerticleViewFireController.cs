using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudVerticleViewFireController : UIHudButtonBaseController
{
	private UIHudVerticleFireView m_View;

	private float m_DragRectSize;

	private float m_DragRadis;

	private float m_IconScale;

	private float m_BtnScale;

	private Camera m_Camera;

	private Transform m_CacheTrans;

	private Transform m_SpriteTrans;

	private Vector3 m_DefaultPos;

	public Vector3 Direction;

	public bool IsUsing;

	private VerticleViewPlayer m_Player;

	public float dist;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	public void OnUpdate()
	{
	}

	public float GetDragRatio()
	{
		return 0f;
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void OnAddLocalPlayer(object[] data)
	{
	}

	private void OnFireClick()
	{
	}

	public void ShowFireTutorial()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
