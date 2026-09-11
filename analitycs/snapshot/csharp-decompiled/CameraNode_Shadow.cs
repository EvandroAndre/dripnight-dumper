using UnityEngine;

public class CameraNode_Shadow : PlanarShadowNode
{
	public delegate void CameraStateChanged(CameraNode_Shadow node, bool active);

	private Camera m_camera;

	public CameraStateChanged OnCameraNodeChanged;

	public Camera camera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Init()
	{
	}

	protected override void OnEnableDisable(bool isActive)
	{
	}

	protected override void OnDestroy()
	{
	}
}
