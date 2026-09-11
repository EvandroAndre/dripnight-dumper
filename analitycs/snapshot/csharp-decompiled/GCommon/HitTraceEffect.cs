using UnityEngine;

namespace GCommon;

internal class HitTraceEffect : ReusableObject
{
	private float DelayDestoryTime;

	private float m_StartTime;

	private Renderer m_Renderer;

	private Material m_material;

	private float m_BlendFactor;

	private void Start()
	{
	}

	public override void Prepare()
	{
	}

	protected override void DoRecycle()
	{
	}

	private void Update()
	{
	}
}
