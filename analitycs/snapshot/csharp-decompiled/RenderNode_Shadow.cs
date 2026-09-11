using UnityEngine;
using UnityEngine.Rendering;

public class RenderNode_Shadow : PlanarShadowNode
{
	public delegate void RenderNodeActiveChanged(RenderNode_Shadow node, bool active);

	private Renderer m_Renderer;

	public CommandBuffer commandBuffer;

	private ShadowCastingMode shadowCastingMode;

	public RenderNodeActiveChanged OnRenderNodeChanged;

	public int subMeshCnt;

	public Renderer Render
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnEnableDisable(bool isActive)
	{
	}

	private void Init()
	{
	}

	private void LateUpdate()
	{
	}

	protected override void OnDestroy()
	{
	}
}
