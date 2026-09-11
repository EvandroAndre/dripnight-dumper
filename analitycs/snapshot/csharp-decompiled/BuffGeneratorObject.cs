using UnityEngine;

public class BuffGeneratorObject : MonoBehaviour
{
	public uint Guid;

	public GameObject model;

	public GameObject countdownmodel;

	private Vector3 position;

	private Quaternion rotation;

	private Vector3 scale;

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

	public void InitObject(uint id, Vector3 _position, Quaternion _rotation, Vector3 _scale)
	{
	}

	public void ShowModel(GameObject go, GameObject countdownGo)
	{
	}

	public void SetStatus(bool enable, float refreshTime)
	{
	}
}
