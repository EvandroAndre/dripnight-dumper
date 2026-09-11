using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBasicCameraRepItem
{
	public const int PROP_ID_CAMERAPROJECTIONMODE = -449000;

	public const int PROP_ID_FOV = -449001;

	public const int PROP_ID_ORTHOGRAPHICSIZE = -449002;

	public const int PROP_ID_CULLINGMASK = -449003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCameraProjectionModeChangeEvent;

	public Action<float> OnFovChangeEvent;

	public Action<float> OnOrthographicSizeChangeEvent;

	public Action<int> OnCullingMaskChangeEvent;

	private int _003CCameraProjectionMode_003Ek__BackingField;

	private float _003CFov_003Ek__BackingField;

	private float _003COrthographicSize_003Ek__BackingField;

	private int _003CCullingMask_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int CameraProjectionMode
	{
		get
		{
			return _003CCameraProjectionMode_003Ek__BackingField;
		}
		private set
		{
			_003CCameraProjectionMode_003Ek__BackingField = value;
		}
	}

	public float Fov
	{
		get
		{
			return _003CFov_003Ek__BackingField;
		}
		private set
		{
			_003CFov_003Ek__BackingField = value;
		}
	}

	public float OrthographicSize
	{
		get
		{
			return _003COrthographicSize_003Ek__BackingField;
		}
		private set
		{
			_003COrthographicSize_003Ek__BackingField = value;
		}
	}

	public int CullingMask
	{
		get
		{
			return _003CCullingMask_003Ek__BackingField;
		}
		private set
		{
			_003CCullingMask_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCBasicCameraRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
