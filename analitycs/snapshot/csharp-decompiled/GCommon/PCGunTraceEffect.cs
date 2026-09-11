using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

internal class PCGunTraceEffect : ReusableObject
{
	public float GunTraceLength;

	public float GunTraceSpeed;

	public float SniperGunTraceSpeed;

	public float GunSmokeFadeTime;

	public float SniperGunSmokeFadeTime;

	public float Mobile1PSniperGunSmokeFadeTime;

	public LineRenderer TraceRenderer;

	public LineRenderer SmokeRender;

	public List<LineRenderer> ExtraSmokeRenders;

	public bool IsNeedCheckDistance;

	private float m_TraceFlyTime;

	private float m_StartTime;

	private float m_BlendFactor;

	private Material m_TraceMat;

	private Material m_SmokeMat;

	private Color m_SmokeStartColor;

	private List<Material> m_ExtraSmokeMats;

	private List<Color> m_ExtraSmokeStartColors;

	private Vector3 m_StartPos;

	private Vector3 m_Speed;

	private float m_GunTraceAllShowTime;

	private float m_GunSmokeFadeTime;

	private float m_GunTraceSpeed;

	private bool m_HasCustomColor;

	private Color m_CustomTraceColor;

	private Color m_OriginalTraceStartColor;

	private Color m_OriginalTraceEndColor;

	private bool m_OriginalColorSaved;

	private bool m_UseSmokeConfig;

	private float m_ConfigSmokeLength;

	private void Start()
	{
	}

	public void SetTraceColor(Color color)
	{
	}

	public override void Prepare()
	{
	}

	public void StartSimulate(Vector3 start, Vector3 end, bool isSniper, bool mobile1P, bool useSmokeConfig = false, float smokeLength = 0f, float smokeDuration = 0f)
	{
	}

	private void Update()
	{
	}

	private Vector3 GetSmokeEndPosition(Vector3 smokeEndPos)
	{
		return default(Vector3);
	}

	private void InitExtraSmokeRenders()
	{
	}

	private void SetExtraSmokeRendersEnabled(bool enabled)
	{
	}

	private void ResetExtraSmokeColors()
	{
	}

	private void FadeExtraSmokeColors(float time)
	{
	}

	private void ResetExtraSmokeRendersPosition()
	{
	}

	private void SetExtraSmokeRendersPosition(Vector3 pos0, Vector3 pos1)
	{
	}
}
