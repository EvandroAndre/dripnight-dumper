using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class LTransform : LComponent
{
	private Transform m_CachedTransform;

	private bool parentDirty;

	private Transform parentTransform;

	private bool childDirty;

	private List<Transform> childTransform;

	private List<bool> worldPoss;

	private bool localpositionDirty;

	private Vector3 localposition;

	private bool positionDirty;

	private Vector3 position;

	private bool forwardDirty;

	private Vector3 forward;

	private bool rightDirty;

	private Vector3 right;

	private bool upDirty;

	private Vector3 up;

	private bool localrotationDirty;

	private Quaternion localrotation;

	private bool rotationDirty;

	private Quaternion rotation;

	private bool localScaleDirty;

	public Vector3 localScale;

	public Transform CachedTransform => null;

	public Transform parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<Transform> ChildTransform => null;

	public Vector3 localPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Forward
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Right
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Up
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion localRotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 lossyScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public override void OnRelease()
	{
	}

	public void Init(Transform transform)
	{
	}

	public void SetChildTransform(Transform trans, bool worldPos)
	{
	}

	public void OnRecyle()
	{
	}
}
