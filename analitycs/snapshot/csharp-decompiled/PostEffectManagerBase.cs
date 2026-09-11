using System;
using System.Collections.Generic;
using AmplifyColor;
using COW.Graphics;
using UnityEngine;

public class PostEffectManagerBase : MonoBehaviour
{
	public const int LutSize = 32;

	public const int LutWidth = 1024;

	public const int LutHeight = 32;

	private const int DepthCurveLutRange = 1024;

	public List<Camera> extraCameras;

	private PostEffectProfile m_profile;

	private PostEffectProfileOverrides m_profileOverrides;

	private Camera ownerCamera;

	private Texture2D defaultLut;

	public CustomEffectBase[] customEffect;

	private int enableEffectCount;

	private float m_cameraDepth;

	[NonSerialized]
	public float blendAmount;

	private RenderTexture m_colorRT;

	private RenderTexture m_depthRT;

	private string m_depthRTName;

	private RenderTexture m_activeRT;

	private RenderTexture m_replacementRT;

	private string sharedInstanceID;

	private bool silentError;

	private bool isInit;

	private bool skipDueToMSAA;

	private int m_RTWidth;

	private int m_RTHeight;

	[NonSerialized]
	public int RTWidth;

	[NonSerialized]
	public int RTHeight;

	[NonSerialized]
	public bool isLinear;

	private int m_enableMask;

	private int m_globalCtrlEnableMask;

	private bool m_changed;

	public PostEffectProfile Profile
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PostEffectProfileOverrides ProfileOverride => null;

	public Texture2D DefaultLut => null;

	public string SharedInstanceID => null;

	public RenderTexture ReplacementRT
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsActive => false;

	public Camera OwnerCamera => null;

	public void UpdateProfileData()
	{
	}

	public void NewSharedInstanceID()
	{
	}

	private void ReportNotSupported()
	{
	}

	private bool CheckSupport()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void EnablePostEffect()
	{
	}

	private void OnDisable()
	{
	}

	private void DisablePostEffect()
	{
	}

	private void Cleanup()
	{
	}

	private void CheckCamera()
	{
	}

	private void Init()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateEnableState()
	{
	}

	private Texture2D CreateDefaultLut()
	{
		return null;
	}

	private void UpdateEffectCount()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	public void ResetCameraDepth()
	{
	}

	private void RefreshData(object[] data)
	{
	}

	private int ValidateEnable(int mask)
	{
		return 0;
	}

	public bool IsEffectEnable(EffectType type)
	{
		return false;
	}

	public bool IsAnyEffectEnabled()
	{
		return false;
	}

	private bool NeedUseDepth()
	{
		return false;
	}

	private void CheckRenderTexture()
	{
	}

	public void SetEnable(EffectType type, bool enable)
	{
	}

	public void DisableDistortEffectOverride()
	{
	}

	public void GetDistortParam(out Vector4 ctrl, out Texture tex)
	{
		ctrl = default(Vector4);
		tex = null;
	}

	private bool IsOverrideDistortEffectEnable()
	{
		return false;
	}

	public void OverrideDistort(float overrideWeight, ref DistortOverrideSettings outerOverrideDistortSetting)
	{
	}

	public void OverrideBlackWhite(float overrideWeight, ref BlackWhiteOverrideSettings outerOverrideBlackWhiteSetting)
	{
	}

	public void DisableBlackWhiteEffectOverride()
	{
	}

	private bool IsOverrideBlackWhiteEffectEnable()
	{
		return false;
	}

	public void GetBlackWhiteParam(out bool outTint, out float outMinInput, out float outMaxInput)
	{
		outTint = default(bool);
		outMinInput = default(float);
		outMaxInput = default(float);
	}
}
