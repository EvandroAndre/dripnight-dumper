using UnityEngine;

namespace COW;

public class FootballShootLine : MonoBehaviour
{
	private LineRenderer m_LineRender;

	private const float interval = 0.2f;

	private const int pos_count = 75;

	private float sinOfShootAngleMin;

	private float tanOfShootAngleMin;

	private float sinOfHighShootAngleMin;

	private float tanOfHighShootAngleMin;

	private float sinOfShootAngleMax;

	private float tanOfShootAngleMax;

	private bool m_ShowFootballLine;

	protected bool ShowFootballLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void ClearLine()
	{
	}

	private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}

	private void OnShowFootballLineChanged()
	{
	}

	private void OnCrossFireChange(object[] data)
	{
	}
}
