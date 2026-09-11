using UnityEngine;

namespace FF_TA;

public class GlobalLightSetting : MonoBehaviour
{
	public enum AmbientType
	{
		Environment_On,
		Character_Off,
		UnityAmbient
	}

	public float _RefStrength;

	public Color _ShadowColor;

	public float _OutLineWidth;

	public float _DistanceFix;

	public Color _OutLineColor;

	public float _LightScale;

	public float _LightmapScale;

	public bool _AutoCharacterAmbinet;

	public bool _AmbientSH;

	public AmbientType _AmbientType;

	public bool _PropMode;

	public float _bakeyShadow;

	public Color _AmbientColor;

	public float _LightScaleLow;

	public float _AoScale;

	public bool _Optimize;

	public bool _OptimizeOnlyUltra;

	public bool _OptimizeOnlyLow;

	public bool _OptimizeOnlyLowest;

	public float _fogCover;

	public float _sunPow;

	public float _sunIntencity;

	public Color _sunColor;

	public float _sunDistance;

	public Color characterAmbinet;

	public Vector4 _custom_SHAr;

	public Vector4 _custom_SHAg;

	public Vector4 _custom_SHAb;

	public Vector4 _custom_SHBr;

	public Vector4 _custom_SHBg;

	public Vector4 _custom_SHBb;

	public Vector4 _custom_SHC;

	private int m_custom_ambientSHID;

	private int m_custom_ShadowColorID;

	private int m_custom_OutLineColorID;

	private int m_custom_Ref_OutW_LiS_LimapSID;

	private int m_custom_SHArID;

	private int m_custom_SHAgID;

	private int m_custom_SHAbID;

	private int m_custom_SHBrID;

	private int m_custom_SHBgID;

	private int m_custom_SHBbID;

	private int m_custom_SHCID;

	private int m_custom_AmbientColorID;

	private int m_custom_LightScaleLowID;

	private int m_custom_BakedShadowScale;

	private int m_custom_fogCoverID;

	private int m_custom_sunColID;

	private int m_custom_sunIntencityID;

	private int m_custom_sunPowID;

	private int m_custom_sunStartEndID;

	private int m_custom_AoScaleID;

	public float BakeyShadow => 0f;

	private void Start()
	{
	}

	private void SetCharacterAmbint()
	{
	}

	private void HideLight()
	{
	}

	private void SetGloalLight()
	{
	}

	private void SetOptimize()
	{
	}

	private void OnDisable()
	{
	}
}
