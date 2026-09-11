using UnityEngine;

public class CSRoundDragonLine : MonoBehaviour
{
	private int Step;

	private CSRoundDragonParams dragonParams;

	public Transform FocusAPos;

	public Transform FocusBPos;

	public float Radius;

	public float Height;

	public float SpeedStraight;

	public float SpeedArc;

	public bool IsGizmoShow;

	public void OnDrawGizmos()
	{
	}
}
