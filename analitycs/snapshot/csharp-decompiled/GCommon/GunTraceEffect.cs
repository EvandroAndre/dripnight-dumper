using UnityEngine;

namespace GCommon;

internal class GunTraceEffect : ReusableObject
{
	public float DelayDestoryTime;

	public float Speed;

	public float SpeedFactor;

	public bool IsFPPEff;

	private float m_StartTime;

	private Renderer m_Renderer;

	private float m_BlendFactor;

	private Material m_material;

	private LineRenderer m_LineRenderer;

	private Color m_OriginalStartColor;

	private Color m_OriginalEndColor;

	private bool m_OriginalColorSaved;

	private void Start()
	{
	}

	public override void Prepare()
	{
	}

	private void Update()
	{
	}
}
