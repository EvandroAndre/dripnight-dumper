using UnityEngine;

public class UGCPrettySprite3DSize : MonoBehaviour
{
	protected Transform m_trans;

	public float LockDistance;

	public float LogicScale;

	public float AdjustMinDistance;

	public float AdjustMaxDistance;

	public Transform TrackObject;

	public string TrackEntityID;

	public Vector3 OffsetPosition;

	private float Pixel2Scale;

	public float DistanceScalePerMeter;

	public UISprite m_sprite;

	protected UILabel m_label;

	public float m_9SpritePixelSize;

	public float m_max9SpriteSize;

	public float m_lockSpriteSize;

	public bool m_isAlwaysInScreen;

	public bool isUpdateSize;

	private Vector3 m_finalScale;

	private float m_distanceToCamera;

	private Vector3 m_curScreenPos;

	private float m_finalPixelWidth;

	private float m_finalPixelHeight;

	private Vector3 m_finalScreenPos;

	private Vector3 m_debugViewportPos;

	public float m_alwaysInScreenPadding;

	public bool Is9Sprite => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetLabel(UILabel label)
	{
	}

	private void UpdateSize()
	{
	}

	protected virtual void UpdatePosition()
	{
	}

	private void UpdatePositionIfAlwaysInScreen()
	{
	}
}
