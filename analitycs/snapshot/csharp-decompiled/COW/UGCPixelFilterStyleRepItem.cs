using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPixelFilterStyleRepItem
{
	public const int PROP_ID_PIXELISATION = -483000;

	public const int PROP_ID_COLOROFFSET = -483001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnPixelisationChangeEvent;

	public Action<int> OnColorOffsetChangeEvent;

	private float _003CPixelisation_003Ek__BackingField;

	private int _003CColorOffset_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Pixelisation
	{
		get
		{
			return _003CPixelisation_003Ek__BackingField;
		}
		private set
		{
			_003CPixelisation_003Ek__BackingField = value;
		}
	}

	public int ColorOffset
	{
		get
		{
			return _003CColorOffset_003Ek__BackingField;
		}
		private set
		{
			_003CColorOffset_003Ek__BackingField = value;
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

	public UGCPixelFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
