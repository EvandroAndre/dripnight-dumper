using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIUnBlockOtherHudScript : MonoBehaviour
{
	private struct DepthEntry
	{
		public int depth;

		public RaycastHit hit;

		public Vector3 point;

		public GameObject go;

		public bool IsVisible()
		{
			return false;
		}
	}

	public delegate void OnClickEvent(List<GameObject> hitObjects);

	public delegate void OnDragEvent(GameObject dragObject, Vector2 startPos);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__35_0;

		internal int _003CRaycast_003Eb__35_0(DepthEntry r1, DepthEntry r2)
		{
			return 0;
		}
	}

	private MouseOrTouch currentTouch;

	public int currentTouchID;

	private MouseOrTouch[] mMouse;

	public MouseOrTouch controller;

	public List<MouseOrTouch> activeTouches;

	private List<int> mTouchIDs;

	private float mNextRaycast;

	private List<GameObject> mRayHitObjects;

	private GameObject mRayHitObject;

	private GameObject fallThrough;

	private DepthEntry mHit;

	private BetterList<DepthEntry> mHits;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public OnClickEvent OnClick;

	public OnDragEvent OnDrag;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public void ProcessMouse()
	{
	}

	public void ProcessTouches()
	{
	}

	private void ProcessFakeTouches()
	{
	}

	public MouseOrTouch GetTouch(int id, bool createIfMissing)
	{
		return null;
	}

	public void RemoveTouch(int id)
	{
	}

	public void ProcessTouch(bool pressed, bool released, bool isMouse)
	{
	}

	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	public void Raycast(MouseOrTouch touch)
	{
	}

	public bool Raycast(Vector3 inPos, out GameObject hitObject)
	{
		hitObject = null;
		return false;
	}

	public bool Raycast(Vector3 inPos)
	{
		return false;
	}

	public void OnClickNotified()
	{
	}

	public void OnDragNotified()
	{
	}
}
