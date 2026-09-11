using UnityEngine;

public class LightNode_Shadow : PlanarShadowNode
{
	public delegate void LightNodeActiveChanged(LightNode_Shadow node, bool active);

	public Light m_light;

	public LightNodeActiveChanged OnLightNodeChanged;

	public Light light
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

	protected override void OnDestroy()
	{
	}
}
