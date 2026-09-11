using UnityEngine;

namespace GCommon;

public class TransformNode : ITransformNode
{
	private Transform _003Ctransform_003Ek__BackingField;

	public Transform transform
	{
		get
		{
			return _003Ctransform_003Ek__BackingField;
		}
		private set
		{
			_003Ctransform_003Ek__BackingField = value;
		}
	}

	public TransformNode(Transform n)
	{
	}
}
