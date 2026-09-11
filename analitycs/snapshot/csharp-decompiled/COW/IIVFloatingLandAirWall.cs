using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class IIVFloatingLandAirWall : MonoBehaviour
{
	public List<IIVFloatingLandAirWallInfo> AirWallInfo;

	private MaterialPropertyBlock[] m_PropertyBlocks;

	private List<Material> m_MaterialList;

	private void Start()
	{
	}

	private void InitializePropertyBlocks()
	{
	}

	private void Update()
	{
	}

	private float DistanceToLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return 0f;
	}

	public void OnDrawGizmos()
	{
	}
}
