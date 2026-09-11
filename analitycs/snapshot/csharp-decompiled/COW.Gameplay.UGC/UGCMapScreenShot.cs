using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCMapScreenShot : IDisposable
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public Vector3 averagePosition;

		internal int _003CDoScreenShot_003Eb__0(Transform a, Transform b)
		{
			return 0;
		}
	}

	private readonly List<Vector3> targetDegs;

	public Vector2Int[] boundIndexs;

	private readonly int ScreenShot_Width;

	private readonly int ScreenShot_Height;

	private readonly float UseCountPercent;

	private int mScreenShotIndex;

	private uint slotID;

	private GameObject newCameraObj;

	private int index;

	private Camera shotCamera;

	public UGCMapScreenShot(uint slotID)
	{
	}

	public void Dispose()
	{
	}

	public void Start()
	{
	}

	public bool CanPack()
	{
		return false;
	}

	public bool PackScreenShot(List<Transform> captureList, bool savePictures = false)
	{
		return false;
	}

	public bool ScreenShot(List<Transform> transforms, out List<byte[]> shotBytes)
	{
		shotBytes = null;
		return false;
	}

	public List<byte[]> PackScreenShot(Camera captureCamera, List<Transform> captureList, bool savePictures = false)
	{
		return null;
	}

	public byte[] DoScreenShot(Camera captureCamera, List<Transform> captureList, float targetXDeg, float targetYDeg, float sizeFactor, bool savePictures)
	{
		return null;
	}

	public Vector2Int FitToMaxSizeWithAspectRatio(Vector2 maxSize, Vector2 currentSize)
	{
		return default(Vector2Int);
	}
}
