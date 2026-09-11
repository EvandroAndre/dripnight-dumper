using UnityEngine;

public class DrawArrow : MonoBehaviour
{
	public Transform m_Transform;

	public float m_Length;

	public Color m_Color;

	public Transform[] m_Target;

	private void Reset()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public static void ForGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}
}
