using UnityEngine;

namespace COW;

public class EscortVehicleTrackLine : MonoBehaviour
{
	private bool m_showLaunchLine;

	public LineRenderer m_LineRender;

	private const float interval = 0.2f;

	private const int pos_count = 60;

	public Transform[] m_Positions;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DrawLine()
	{
	}
}
