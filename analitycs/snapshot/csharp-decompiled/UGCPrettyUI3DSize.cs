using UnityEngine;

public class UGCPrettyUI3DSize : MonoBehaviour
{
	public float LockDistance;

	public float LogicScale;

	public float AdjustMinDistance;

	public float AdjustMaxDistance;

	public Transform TrackObject;

	public string TrackEntityID;

	public Vector3 OffsetPosition;

	private float Pixel2Scale;

	public float DistanceScalePerMeter;

	public float m_9SpritePixelSize;

	public float m_max9SpriteSize;

	public float m_lockSpriteSize;

	public bool isUpdateSize;

	protected Vector3 m_originalWorldPos;

	private Vector3 m_finalScale;

	private float m_distanceToCamera;

	protected Vector3 m_outScreen;

	private void Update()
	{
	}

	public void SetOriginaPos(Vector3 ogPos)
	{
	}

	private void OnDestroy()
	{
	}

	public void BindEntityID(string value)
	{
	}

	private void OnGameObjectAdd(GameObject obj)
	{
	}

	protected void UpdatePosition()
	{
	}

	private void UpdateSize()
	{
	}
}
