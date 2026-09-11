using UnityEngine;

public class UICustomMeshCollider : MonoBehaviour
{
	public string MeshName;

	public Mesh MeshRef;

	public bool SectorShape;

	public float Radius;

	public float InnerRadius;

	public float AngleDegree;

	public uint Segments;

	public float AngleStart;

	public float OffsetX;

	public float OffsetY;

	public uint Size;

	public Pos[] Vertices;

	private MeshCollider m_Collider;

	private Mesh m_Mesh;

	public Mesh MMesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}
}
