using System;
using System.Collections.Generic;
using AnimationOrTween;
using UMA;
using UnityEngine;

namespace COW.Graphics;

public class UMATweenProperty : MonoBehaviour
{
	[Serializable]
	public class Target
	{
		public Renderer renderer;

		protected Material mMat;

		protected TweenPropertyAlpha[] mPropsAlpha;

		public int propertyIndex;

		public string propertyName;

		private int m_PropertyID;

		public TweenPropertyAlpha tweenPropertyAlpha;

		public string ShaderName;

		public string TextureName;

		public string TexPropertyName;

		public int MaterialIndex;

		public int MaxMaterialIndex;

		public bool DataInitialized;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int PropertyID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float finalAlpha
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}
	}

	private enum ChangeStatus
	{
		BeforeChange,
		Change,
		AfterChange
	}

	public enum Method
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		BounceIn,
		BounceOut
	}

	public enum Style
	{
		Once,
		Loop,
		PingPong,
		OnceEverytimeOnEnable,
		LoopResetOnEnable,
		OnceAlwaysEnable,
		PingPongResetOnEnable
	}

	public List<Target> targets;

	public int propType;

	public float fromFloat;

	public float toFloat;

	public int vec4Idx;

	public Gradient fromToColor;

	public bool colorHDR;

	public bool changeAlpha;

	public bool UseForUMA;

	public bool IsTriggeredByPrefab;

	public bool influencedByUI;

	protected UIRect uiParent;

	public bool typeError;

	public bool ShowEffectsBetweenChange;

	public GameObject EffectsRootBeforeChange;

	public GameObject EffectsRootAfterChange;

	public List<GameObject> EffectsBeforeChange;

	public List<GameObject> EffectsAfterChange;

	public bool ShowEffectExitChange;

	private bool m_LoopWithRestart;

	private float m_TinyFactor;

	private UMAData m_umaData;

	private ChangeStatus m_StatusBeforeChange;

	private int m_MainTexID;

	private bool m_IsFromUIMaleAvatar;

	private static List<Material> staticMats;

	private static Dictionary<int, string> nameCache;

	public Method method;

	public Style style;

	public AnimationCurve animationCurve;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	private bool mStarted;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	public float valueFloat
	{
		private get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float valueVector
	{
		private get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color valueColor
	{
		private get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float amountPerDelta => 0f;

	public float tweenFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Direction direction => Direction.Toggle;

	private void Awake()
	{
	}

	private static string GetCachedName(int instanceID)
	{
		return null;
	}

	private static void StoreName(int instanceID, string name)
	{
	}

	public static void ClearNameCache()
	{
	}

	private static string GetShaderNameAndTryStore(Shader shader)
	{
		return null;
	}

	private static string GetTextureNameAndTryStore(Texture texture)
	{
		return null;
	}

	public void SetMaterialByTexAndShaderName(int index)
	{
	}

	public void FindRender(int index)
	{
	}

	protected float GetUIFinalAlpha()
	{
		return 0f;
	}

	protected void OnUpdate(float factor, bool isFinished)
	{
	}

	public void UpdateUMAData()
	{
	}

	public void SaveUMAData(string ShaderName, string TextureName, string propertyName)
	{
	}

	public void CleanUMAData()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private bool IsFromUIMaleAvatar()
	{
		return false;
	}

	private void ShowEffects(bool beforeChange)
	{
	}

	private void HideEffects(bool beforeChange)
	{
	}

	public Renderer FindRenderInUMA(GameObject go)
	{
		return null;
	}

	public void UpdateEffectList(bool beforeChange)
	{
	}

	protected virtual void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Sample(float factor, bool isFinished)
	{
	}

	private float BounceLogic(float val)
	{
		return 0f;
	}

	public void PlayForward()
	{
	}

	public void PlayReverse()
	{
	}

	public void ResetDuraing()
	{
	}

	public void Play(bool forward)
	{
	}

	public void ResetToBeginning()
	{
	}

	public void ResetToForwardBeginning()
	{
	}

	public void ResetToReverseBeginning()
	{
	}

	public void SetToEnd()
	{
	}

	public void Toggle()
	{
	}

	private void ChangeEffect(float value)
	{
	}

	private void UpdateAnimByUMAEvent(UMAData umaData)
	{
	}
}
