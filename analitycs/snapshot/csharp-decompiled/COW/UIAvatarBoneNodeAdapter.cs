using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarBoneNodeAdapter
{
	public class TransformNode : ITransformNode
	{
		private Transform _003Ctransform_003Ek__BackingField;

		private List<Transform> m_rawChildren;

		public Transform transform
		{
			get
			{
				return _003Ctransform_003Ek__BackingField;
			}
			set
			{
				_003Ctransform_003Ek__BackingField = value;
			}
		}

		public void CacheRawChild()
		{
		}

		public void SwapChildren(Transform targetNode)
		{
		}
	}

	private Dictionary<string, TransformNode> m_BoneNodeDic;

	private Transform m_boneRoot;

	private TransformNode m_emptyNode;

	private bool m_inited;

	public void Init(Transform root)
	{
	}

	public void Clear()
	{
	}

	public TransformNode GetBoneNode(string nodeName)
	{
		return null;
	}

	public void SwapBoneNodes(Transform newBoneRoot)
	{
	}

	public void OnModelUpdated()
	{
	}
}
