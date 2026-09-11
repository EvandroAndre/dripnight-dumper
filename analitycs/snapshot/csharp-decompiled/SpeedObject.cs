using GCommon;
using UnityEngine;

public class SpeedObject : MonoBehaviour
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

	private ResourceID resID;

	private Vector3 position;

	private Quaternion rotation;

	private Vector3 scale;

	protected Vector3 m_LastVelocity;

	private ShadowState m_ShadowState;

	protected uint m_LastValidTickCount;

	private uint TargetTickCount;

	private uint SimTick;

	private GameObject m_AudioSource;

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

	public void Update()
	{
	}
}
