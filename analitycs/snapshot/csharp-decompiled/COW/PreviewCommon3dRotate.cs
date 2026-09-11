using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class PreviewCommon3dRotate : MonoBehaviour
{
	public Vector3 CollectionRotation;

	public Vector3 MallRotation;

	public Vector3 GachaRotation;

	public Vector3 EpRotation;

	private bool m_Inited;

	private Dictionary<int, Vector3> m_PreviewCommon3dRotateDic;

	public Dictionary<int, Vector3> PreviewCommon3dRotateDic => null;
}
