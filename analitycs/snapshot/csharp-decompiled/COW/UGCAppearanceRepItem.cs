using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAppearanceRepItem
{
	public const int PROP_ID_DIFFUSECOLOR = -125000;

	public const int PROP_ID_RIMCOLOR = -125001;

	public const int PROP_ID_DIFFUSETEXTURE = -125002;

	public const int PROP_ID_RIMTEXTURE = -125003;

	public const int PROP_ID_DIFFUSEALPHA = -125004;

	public const int PROP_ID_RIMALPHA = -125005;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnDiffuseColorChangeEvent;

	public Action<int> OnRimColorChangeEvent;

	public Action<string> OnDiffuseTextureChangeEvent;

	public Action<string> OnRimTextureChangeEvent;

	private int _003CDiffuseColor_003Ek__BackingField;

	private int _003CRimColor_003Ek__BackingField;

	private string _003CDiffuseTexture_003Ek__BackingField;

	private string _003CRimTexture_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int DiffuseColor
	{
		get
		{
			return _003CDiffuseColor_003Ek__BackingField;
		}
		private set
		{
			_003CDiffuseColor_003Ek__BackingField = value;
		}
	}

	public int RimColor
	{
		get
		{
			return _003CRimColor_003Ek__BackingField;
		}
		private set
		{
			_003CRimColor_003Ek__BackingField = value;
		}
	}

	public string DiffuseTexture
	{
		get
		{
			return _003CDiffuseTexture_003Ek__BackingField;
		}
		private set
		{
			_003CDiffuseTexture_003Ek__BackingField = value;
		}
	}

	public string RimTexture
	{
		get
		{
			return _003CRimTexture_003Ek__BackingField;
		}
		private set
		{
			_003CRimTexture_003Ek__BackingField = value;
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

	public UGCAppearanceRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
