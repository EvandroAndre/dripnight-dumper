using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicPVS;

public class Indexer
{
	private SerializeData m_SerializeData;

	private float m_InvPortalSize;

	private List<int> m_TempIndices;

	private int m_CurBakerPortalIndex;

	public bool IsValid => false;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void SetSerializeData(SerializeData serializeData)
	{
	}

	public bool QueryPortalIndices(Vector3 boundsCenter, float boundsSize, int maxYCount, Bounds aabbBounds, ref List<int> indices, float minGrundHeight = float.MinValue, float maxGrundHeight = float.MinValue)
	{
		return false;
	}

	public bool QueryPortalIndex(Vector3 boundsCenter, float boundsSize, int maxYCount, Vector3 position, out int index, float grundHeight = float.MinValue)
	{
		index = default(int);
		return false;
	}

	public bool QueryPortalCenter(Vector3 boundsCenter, float boundsSize, Vector3 position, out Vector3 portalCenter)
	{
		portalCenter = default(Vector3);
		return false;
	}

	public bool QueryGroundHeight(Vector3 portalCenter, out float groundHeight)
	{
		groundHeight = default(float);
		return false;
	}

	public bool QueryPortalVisibilities(int bakerPortalIndex, int targetPortalIndex)
	{
		return false;
	}

	public bool UpdateCameraPosition(Vector3 cameraPosition)
	{
		return false;
	}

	public bool QueryVisible(Vector3 targetPosition)
	{
		return false;
	}

	public bool QueryVisible(Bounds aabbBounds, float ignoreGroundHeight = 0f)
	{
		return false;
	}
}
