using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMeshRenderRepItem
{
	public const int PROP_ID_MESHID = -185000;

	public const int PROP_ID_MATERIALS = -185001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnMeshIDChangeEvent;

	public Action<List<object>> OnMaterialsChangeEvent;

	private string _003CMeshID_003Ek__BackingField;

	private List<object> _003CMaterials_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string MeshID
	{
		get
		{
			return _003CMeshID_003Ek__BackingField;
		}
		private set
		{
			_003CMeshID_003Ek__BackingField = value;
		}
	}

	public List<object> Materials
	{
		get
		{
			return _003CMaterials_003Ek__BackingField;
		}
		private set
		{
			_003CMaterials_003Ek__BackingField = value;
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

	public UGCMeshRenderRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
