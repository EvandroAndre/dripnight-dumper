using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditTransformGizmoController : UIBaseController
{
	private UIHudSceneEditTransformGizmoView m_View;

	private Camera m_Camera;

	private SceneEditAgent agent;

	public Camera GameCamera => null;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowGizmo()
	{
	}

	public void LateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
