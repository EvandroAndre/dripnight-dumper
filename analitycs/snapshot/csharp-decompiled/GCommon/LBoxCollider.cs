using UnityEngine;

namespace GCommon;

public class LBoxCollider : LCollider
{
	private BoxCollider mCollider;

	public Vector3 m_center;

	public Vector3 m_size;

	public bool m_enable;

	public BoxCollider CachedCollider => null;

	public Vector3 center
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 size
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void OnRelease()
	{
	}

	public void Init(BoxCollider collider)
	{
	}

	public void InitCollider(BoxCollider collider)
	{
	}

	public bool Contains(Collider collider)
	{
		return false;
	}

	public void Recyle()
	{
	}
}
