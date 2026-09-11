using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCWalletHudRepItem
{
	public const int PROP_ID_BINDMONEYENTITY = -96000;

	public const int PROP_ID_OFFSET = -96001;

	public const int PROP_ID_SCALE = -96002;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBindMoneyEntityChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<Vector3> OnScaleChangeEvent;

	private string _003CBindMoneyEntity_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private Vector3 _003CScale_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string BindMoneyEntity
	{
		get
		{
			return _003CBindMoneyEntity_003Ek__BackingField;
		}
		private set
		{
			_003CBindMoneyEntity_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public Vector3 Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
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

	public UGCWalletHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
