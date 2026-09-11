using System;
using System.Collections.Generic;
using UnityEngine;
using WorldStreamer;

namespace COW.GamePlay;

public class SceneGraphicsQuality : MonoBehaviour
{
	public bool enableShadow;

	public bool useUnityShadowForSecondary;

	public bool useUnityDefaultFog;

	public float shadowDistance;

	public static MNMBLBKENMK currentQuality;

	private static int BHHMAJCMCPL;

	private static int LIFFNGJOKDL;

	public static int DeviceWidth;

	public static int DeviceHeight;

	private static readonly int NDALDKKPFOL;

	private static readonly int JHJMFDAPFMH;

	private static readonly int AJGCNMHECKF;

	private static readonly int FEGHIMKPFMH;

	public static float m_resolutionResetScale;

	public static EInGameFilterSetting lutEffectFilter;

	public static OGKDLMHLAOB shadowType;

	private static bool MBCCGGGICPK;

	private static bool NHAAHMBOPGN;

	public static bool needReduceResLow;

	private static ShadowResolution KCHPAPIGAHG;

	private static bool GBJMHCDBCFK;

	private static float DFAKJEIIOEL;

	private static Light HHFFFNAJAGM;

	private static Dictionary<Streamer, int> IHCBCIGMHCF;

	public static Light GPAPMJHOBEE => null;

	public static int ENJMPLPHHEK => 0;

	public static int EIENLFAEPGK => 0;

	public static bool HHKGFBBPAJE => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void ShrinkStreamerRange(int[] DGJLKNMKKGA, bool NKGJIJFKPIH = false)
	{
	}

	public static float GetLevelContainerStreamerRangeScale()
	{
		return 0f;
	}

	public static void SetLevelContainerStreamerRangeScale(float GLPLIHEECAP)
	{
	}

	public static void ResetShrinkStreamerRange(bool NKGJIJFKPIH = false)
	{
	}

	public static void ClearStreamerRangeCache()
	{
	}

	private static void MHIEOHIEBBF(Streamer KJFMIJFMLON, int DFKJIKFKKDH, bool NKGJIJFKPIH = false)
	{
	}

	public static void SetShadowType(OGKDLMHLAOB CCNBNLAPJFM, bool KDBCBPJFBNN = true, float JCNHHEMFKAG = -1f)
	{
	}

	public static void SetGlobalShaderLod()
	{
	}

	public static void SetGraphicsQuality(Type DPLGBMAFBJI)
	{
	}

	public static void ResetGraphicsQuality()
	{
	}

	public static void ResetScreenSize(bool DGGCEFGNIKF = false)
	{
	}

	public static int GetDesignWidth()
	{
		return 0;
	}

	public static int GetDesignHeight()
	{
		return 0;
	}

	public static bool IsLobbyHDRecipeEnabled()
	{
		return false;
	}

	public static void SetResolutionRegionEnable(bool HCLGHJNEFIC)
	{
	}

	public static bool GetResolutionRegionEnable()
	{
		return false;
	}

	public static void SetShouldReduceResolution(bool PCEMDIKJLPH)
	{
	}

	public static bool NeedReduceResolution()
	{
		return false;
	}

	public static bool IsQualityGreaterEqualThanRef(MNMBLBKENMK HNMCKLOGBMC)
	{
		return false;
	}

	public static int GetDefaultGlobalMaximumLOD()
	{
		return 0;
	}

	public static int GetGlobalShaderLOD()
	{
		return 0;
	}

	public static void SetGraphicsQualityForSocialLobby()
	{
	}

	public static void ResetGraphicsQualityForSocialLobby()
	{
	}

	public static void ResetLowMemoryAsyncUploadBufferSize()
	{
	}
}
