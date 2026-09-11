using System.Collections.Generic;
using COW;
using UnityEngine;

public class UGCTimelineTickHeader : MonoBehaviour
{
	public Transform ticksContainer;

	public GameObject tickPrefab;

	public UISprite timelineBackground;

	public float minScale;

	public float maxScale;

	public float zoomSpeed;

	private List<GameObject> tickObjects;

	public UGCTimelineScrollView trackContainer;

	public float visibleBuffer;

	public float startPos;

	private TimeScaleHandler timeScaleHandler;

	private float lastScrollX;

	private int lastViewportWidth;

	public float GetBestTickInterval => 0f;

	public float CurrentTime => 0f;

	public float TimeToPixel(float time)
	{
		return 0f;
	}

	public float PixelToTime(float pixelX)
	{
		return 0f;
	}

	public void SetTickWidth(float duration)
	{
	}

	public void ForceUpdatePos()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void HandleMouseZoom()
	{
	}

	private GameObject GetPooledTick(int index)
	{
		return null;
	}

	private int GetViewportWidth()
	{
		return 0;
	}

	private float GetScrollX()
	{
		return 0f;
	}

	private void GetViewportLocalXRange(out float left, out float right)
	{
		left = default(float);
		right = default(float);
	}

	private void UpdateVisibleTicks()
	{
	}

	private void DeactivateUnusedTicks(int startIndex)
	{
	}

	private void GenerateTicks()
	{
	}

	private float GetCurrentX(float currentX)
	{
		return 0f;
	}
}
