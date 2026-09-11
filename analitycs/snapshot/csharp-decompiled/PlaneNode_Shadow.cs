using UnityEngine;

public class PlaneNode_Shadow : PlanarShadowNode
{
	public delegate void PlaneStateChanged(PlaneNode_Shadow node, bool active);

	private Transform m_transform;

	public Renderer shadowPlaneRender;

	private float altitude;

	private float curError;

	public PlaneStateChanged OnPlaneNodeChanged;

	public Transform shadowPlaneTrans
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

	private void LateUpdate()
	{
	}

	protected override void OnDestroy()
	{
	}
}
