using UnityEngine;

namespace COW;

public class EffectsScreenFit : MonoBehaviour
{
	private enum EffectsAnchorType
	{
		None,
		Top,
		Down,
		Left,
		Right
	}

	public ParticleSystem[] m_ParticleSystems;

	public MeshFilter[] m_MeshFilters;

	public Camera cam;

	public bool IsScaleXY;

	public UIRoot UIRoot;

	public Transform Top;

	public Transform Down;

	public Transform Left;

	public Transform Right;

	public bool StartFitOnAwake;

	private float DEFAULT_WIDTH;

	private float DEFAULT_HEIGHT;

	private float m_HeightRatio;

	private float m_WidthRatio;

	private Vector3 m_LossyScale;

	private float m_ScreenWidth;

	private float m_ScreenHeight;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void StartFit()
	{
	}

	private void SetFourSidesPos()
	{
	}

	private void SetParticle()
	{
	}

	private void SetMesh()
	{
	}

	private void ChangeShapeScale(ParticleSystem particleSystem, float newScaleX = 0f, float newScaleY = 0f)
	{
	}

	private void ChangePos(Transform transform, float newX = 0f, float newY = 0f)
	{
	}

	private void ChangePosByAnchorType(Transform transform, EffectsAnchorType effectsAnchorType = EffectsAnchorType.None)
	{
	}

	private void ProcessScreenSizeWithNotch(out float screenWidth, out float screenHeight)
	{
		screenWidth = default(float);
		screenHeight = default(float);
	}
}
