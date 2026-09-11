using UnityEngine;

namespace GCommon;

public class FPSCounter : MonoBehaviour
{
	public static FPSCounter instance;

	private const float fpsMeasurePeriod = 0.5f;

	private int m_FpsAccumulator;

	private float m_FpsNextPeriod;

	private int m_CurrentFps;

	private float m_LeftPeriod;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public int GetCurrentFPS()
	{
		return 0;
	}

	public void OnApplicationPause(bool paused)
	{
	}
}
