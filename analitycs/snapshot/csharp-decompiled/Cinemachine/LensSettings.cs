using System;
using UnityEngine;

namespace Cinemachine;

[Serializable]
public struct LensSettings
{
	public static LensSettings Default;

	public float FieldOfView = 0f;

	public float OrthographicSize = 0f;

	public float NearClipPlane = 0f;

	public float FarClipPlane = 0f;

	public float Dutch = 0f;

	private bool _003COrthographic_003Ek__BackingField = false;

	private bool _003CIsPhysicalCamera_003Ek__BackingField = false;

	private Vector2 _003CSensorSize_003Ek__BackingField = default(Vector2);

	public Vector2 LensShift = default(Vector2);

	public bool Orthographic
	{
		get
		{
			return _003COrthographic_003Ek__BackingField;
		}
		set
		{
			_003COrthographic_003Ek__BackingField = value;
		}
	}

	public bool IsPhysicalCamera
	{
		get
		{
			return _003CIsPhysicalCamera_003Ek__BackingField;
		}
		set
		{
			_003CIsPhysicalCamera_003Ek__BackingField = value;
		}
	}

	public Vector2 SensorSize
	{
		get
		{
			return _003CSensorSize_003Ek__BackingField;
		}
		set
		{
			_003CSensorSize_003Ek__BackingField = value;
		}
	}

	public float Aspect => 0f;

	public static LensSettings FromCamera(Camera fromCamera)
	{
		return default(LensSettings);
	}

	public void SnapshotCameraReadOnlyProperties(Camera camera)
	{
	}

	public void SnapshotCameraReadOnlyProperties(ref LensSettings lens)
	{
	}

	public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch)
	{
	}

	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
	{
		return default(LensSettings);
	}

	public void Validate()
	{
	}
}
