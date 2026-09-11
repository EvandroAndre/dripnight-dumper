using AmplifyColor;
using COW.Graphics;
using UnityEngine;

public sealed class PostEffectProfile : ScriptableObject
{
	public int lowestMask;

	public int lowMask;

	public int ultraMask;

	public bool depthBlurEnable;

	public bool useImageDepthBlur;

	public float depthBlurStrength;

	public bool bloomEnable;

	public float ultraIntensity;

	public float ultraThreshold;

	public float ultraSoftKnee;

	public float ultraDiffusion;

	public Color BloomColor;

	public bool colorGradingEnable;

	public ColorGrading.FilterType filterType;

	public Quality QualityLevel;

	public Texture LutTexture;

	public bool UseAvatarLut;

	public Texture LutAvatarTexture;

	public bool ACESEnable;

	public ACES.Type ACESType;

	public Texture AcesLutTexture;

	public Texture LegacyLutTexture;

	public bool BRRimEnable;

	public Color RimColor;

	public bool FogEnable;

	public Color FogColorStart;

	public Color FogColorEnd;

	public Vector4 FogParam0;

	public Vector4 FogParam1;

	public Vector4 FogParam2;

	public Vector4 FogParam3;

	public Color DirectionFogColor;

	public Vector4 DirectionFogDir;

	public bool LinearToGammaEnable;

	public bool FastAOEnable;

	public float intensity;

	public float blurAmount;

	public float radius;

	public float area;

	public bool fastMode;

	public float diffThreshold;

	public Vector4 sampleData1;

	public Vector4 sampleData2;

	public Vector3 rayRotDegrees;

	public bool HDREnable;

	public float HDRTonemapExp;

	public bool FXAAEnable;

	public bool OutlineEnable;

	public float farClipPlane;

	public float width;

	public float brightness;

	public float brightnessWidth;

	public int blurIterations;

	public bool BlackWhiteEnable;

	public bool tint;

	public float maxInput;

	public float minInput;

	public bool DistortEnable;

	public Texture DistortTexture;

	public Vector4 DistortCtrl;

	public bool ugcFilterEnable;

	public UGCPhotoFilter.FilterType ugcFilterType;

	public UGCCommonSettings ugcCommon;

	public UGCComicSettings ugcComic;

	public UGCDrawingSettings ugcDrawing;

	public UGCPixelSettings ugcPixel;

	public UGCRGBSplitSettings ugcRgbSplit;

	public UGCGoldenAgeSettings ugcGoldenAge;

	public UGCCyberpunkSettings ugcCyberpunk;
}
