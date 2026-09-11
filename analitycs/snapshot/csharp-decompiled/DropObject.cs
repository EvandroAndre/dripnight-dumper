using GCommon;
using UnityEngine;

public class DropObject : MonoBehaviour
{
	private struct ShadowState
	{
		public Vector3 TargetPos;

		public Quaternion TargetRot;

		public Vector3 StartPos;

		public Quaternion StartRot;
	}

	public uint Guid;

	public GameObject model;

	public Transform shadow;

	private readonly float startScale;

	private readonly float endScale;

	private readonly float totalTime;

	private readonly float minSpeed;

	public readonly string ShadowName;

	private float curTime;

	private bool changeShadowScale;

	private Vector3 shadowPos;

	private ResourceID resID;

	private Vector3 position;

	private Quaternion rotation;

	private Vector3 scale;

	protected Vector3 m_LastVelocity;

	private bool landed;

	private ShadowState m_ShadowState;

	protected uint m_LastValidTickCount;

	private uint TargetTickCount;

	private uint SimTick;

	private GameObject m_AudioSource;

	private bool IsStatic;

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

	public void InitDropObject(uint id, ResourceID _resID, Vector3 _position, Quaternion _rotation, Vector3 _scale, Vector3 _speed)
	{
	}

	private void Clear()
	{
	}

	public void PlaySound(ResourceID resourceID)
	{
	}

	public void ShowModel(GameObject go)
	{
	}

	private void ShowShadow()
	{
	}

	public void Update()
	{
	}

	public void SyncPos(uint tickCount, Vector3 _position, Quaternion _rotation, Vector3 _speed)
	{
	}

	public void Destroy()
	{
	}
}
