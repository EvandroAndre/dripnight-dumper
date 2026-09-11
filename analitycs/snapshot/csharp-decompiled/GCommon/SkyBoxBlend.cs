using UnityEngine;

namespace GCommon;

public class SkyBoxBlend : MonoBehaviour
{
	private const string m_BlendKeyword = "SKY_BLEND";

	private static readonly int m_BlendPropertyID;

	private static readonly int m_CloudBlendPropertyID;

	public Color FogColor;

	public float FogStart;

	public float FogEnd;

	public float VolumeSize;

	public float LerpDis;

	public Material BlendMat;

	private bool m_Ready;

	private bool m_EnableKeyWord;

	private float m_FogDefaultStart;

	private float m_FogDefaultEnd;

	private Color m_FogDefaultColor;

	private Material m_DefaultSkyboxMaterial;

	private float m_SqrDistance;

	private float m_Lerp;

	private float m_SqrOutRadius;

	private float m_SqrVolumeSize;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void UpdateDefault()
	{
	}

	public void Stop()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
