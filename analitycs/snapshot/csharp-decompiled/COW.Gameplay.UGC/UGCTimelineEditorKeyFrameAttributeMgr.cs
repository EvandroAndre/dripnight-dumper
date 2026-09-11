using System.Collections.Generic;
using COW.GamePlay;
using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorKeyFrameAttributeMgr
{
	private Dictionary<string, NPDBPIJFAHH> m_TimelineArgumentConfigs;

	private Dictionary<string, EJNANMFIPFN> m_TimelineEntityAttributeConfigs;

	private Dictionary<string, Dictionary<long, ItemEditAttributeUIData_V2>> m_TimelineArgumentHideUIConfigs;

	public void Clear()
	{
	}

	public void LoadDataFromJsonData()
	{
	}

	private void LoadDataFromJsonData(JsonData jObjRoot)
	{
	}

	private NPDBPIJFAHH CreateTimelineAttributeConfig(string entityType, string locKey, Dictionary<long, ItemEditAttributeUIData_V2> attributeConfigItems, Dictionary<long, List<ItemEditAttributeUIData_V2>> relatedItems)
	{
		return null;
	}

	private void LoadAttributesProcess(string entityType, JsonData jAttributeObj, ref Dictionary<long, ItemEditAttributeUIData_V2> uiDataDic, ref Dictionary<long, List<ItemEditAttributeUIData_V2>> uiRelatedDataDic, ref Dictionary<long, ItemEditAttributeUIData_V2> hideConfig)
	{
	}

	public EJNANMFIPFN AddTimelineItemAttribute(string entityType, Dictionary<long, ItemEditAttributeUIData_V2> attributeConfigItems, Dictionary<long, List<ItemEditAttributeUIData_V2>> relatedItems)
	{
		return null;
	}

	public bool TryGetTimelineAttributeUIDataList(string entityType, out EJNANMFIPFN config)
	{
		config = null;
		return false;
	}

	public bool TryGetTimelineArgumentUIDataList(string clipName, out NPDBPIJFAHH config)
	{
		config = null;
		return false;
	}

	public bool TryGetTimelineArgumentHideUIDataList(string clipName, out Dictionary<long, ItemEditAttributeUIData_V2> map)
	{
		map = null;
		return false;
	}

	private void _003CLoadDataFromJsonData_003Eb__4_0(uint tid, bool ret, Object ffRes)
	{
	}
}
