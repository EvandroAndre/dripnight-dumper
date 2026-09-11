using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class MapPatchInfo
{
	public int Version;

	private int _003CStreamPatchLightmapNum_003Ek__BackingField;

	private int _003CNotInStreamerLightmapNum_003Ek__BackingField;

	private NotInStreamerLightmaps _003CNotInStreamerLm_003Ek__BackingField;

	private List<NotInStreamerData> _003CNotInStreamerObjToModify_003Ek__BackingField;

	private List<NonstreamData> _003CAddedNonstreamObj_003Ek__BackingField;

	private List<string> _003CRemovedNonstreamObj_003Ek__BackingField;

	public int StreamPatchLightmapNum
	{
		get
		{
			return _003CStreamPatchLightmapNum_003Ek__BackingField;
		}
		private set
		{
			_003CStreamPatchLightmapNum_003Ek__BackingField = value;
		}
	}

	public int NotInStreamerLightmapNum
	{
		get
		{
			return _003CNotInStreamerLightmapNum_003Ek__BackingField;
		}
		private set
		{
			_003CNotInStreamerLightmapNum_003Ek__BackingField = value;
		}
	}

	public NotInStreamerLightmaps NotInStreamerLm
	{
		get
		{
			return _003CNotInStreamerLm_003Ek__BackingField;
		}
		private set
		{
			_003CNotInStreamerLm_003Ek__BackingField = value;
		}
	}

	public List<NotInStreamerData> NotInStreamerObjToModify
	{
		get
		{
			return _003CNotInStreamerObjToModify_003Ek__BackingField;
		}
		private set
		{
			_003CNotInStreamerObjToModify_003Ek__BackingField = value;
		}
	}

	public List<NonstreamData> AddedNonstreamObj
	{
		get
		{
			return _003CAddedNonstreamObj_003Ek__BackingField;
		}
		private set
		{
			_003CAddedNonstreamObj_003Ek__BackingField = value;
		}
	}

	public List<string> RemovedNonstreamObj
	{
		get
		{
			return _003CRemovedNonstreamObj_003Ek__BackingField;
		}
		private set
		{
			_003CRemovedNonstreamObj_003Ek__BackingField = value;
		}
	}

	public void Deserialize(string bytePath, AssetBundle abScene = null)
	{
	}
}
