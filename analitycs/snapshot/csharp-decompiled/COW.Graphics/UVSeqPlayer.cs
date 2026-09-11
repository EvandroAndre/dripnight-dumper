using System;
using System.Collections.Generic;
using UMA;
using UnityEngine;

namespace COW.Graphics;

public class UVSeqPlayer : MonoBehaviour
{
	public enum PlayType
	{
		Normal,
		Shuffle,
		TimeIncrement,
		TriggerOnceWithoutReset,
		LoobyLoop,
		PingPong,
		TriggerOnceWithReset,
		LoobyLoopReset,
		PingPongReset
	}

	[Serializable]
	public class Interval
	{
		public int a;

		public int b;

		public Interval(int x, int y)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Interval> _003C_003E9__51_0;

		internal int _003CCount_003Eb__51_0(Interval x, Interval y)
		{
			return 0;
		}
	}

	public int[] columnRow;

	public float playVelocity;

	public float durationTime;

	private int m_OneDurationFrameCount;

	private bool m_PingPongForward;

	public float startIndex;

	public bool useInterval;

	public List<Interval> intervals;

	public List<string> propertyNames;

	public List<Vector2> propertyScale;

	public bool useForUMA;

	public string shaderName;

	public string textureName;

	public string texPropertyName;

	public bool DataInitialized;

	public int MaterialIndex;

	public int MaxMaterialIndex;

	public bool IsTriggeredByPrefab;

	public bool changePropertyInGame;

	public int propertyIndex;

	public string propertyName;

	public int propType;

	public float newFloat;

	public int vec4Idx;

	public Color newColor;

	private int m_index;

	private float m_intervalDuration;

	public PlayType m_playType;

	private Renderer m_renderer;

	private Material m_material;

	private UMAData m_umaData;

	private float m_frameCount;

	private int m_count;

	private float m_shuffleCounter;

	private List<int> m_valid;

	private const float ONEFRAMETIME = 0.033f;

	private const float MAXTIMESUM = 100000f;

	private float m_timeRecord;

	private bool m_playedOnce;

	private static Dictionary<int, string> nameCache;

	private static List<Material> staticMats;

	public PlayType playType
	{
		get
		{
			return PlayType.Normal;
		}
		set
		{
		}
	}

	public Material SelectedMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetToOrigin()
	{
	}

	public int Count()
	{
		return 0;
	}

	private void CalcTilingAndOffset()
	{
	}

	public void SaveUMAData(string ShaderName, string TextureName, string propertyName)
	{
	}

	public void CleanUMAData()
	{
	}

	private void FindRender()
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

	public void SetMaterialByTexAndShaderName()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetAll()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateAnimByUMAEvent(UMAData umaData)
	{
	}

	private void SetMatAndChangeIngameProperty()
	{
	}
}
