using GCommon;
using UnityEngine;

namespace COW;

public class PropertyData
{
	public ResourceID m_PropIDRight;

	public ResourceID m_PropIDLeft;

	public ResourceID m_PropIDRoot;

	public ResourceID m_PropIDHead;

	public Vector3 m_PropLeftScale;

	public PropertyData()
	{
	}

	public PropertyData(ResourceID pLeft, ResourceID pRight, ResourceID pRoot, ResourceID pHead, Vector3 pLeftScale = default(Vector3))
	{
	}

	public bool Valid()
	{
		return false;
	}
}
