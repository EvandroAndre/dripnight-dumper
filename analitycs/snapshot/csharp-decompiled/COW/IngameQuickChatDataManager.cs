using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class IngameQuickChatDataManager : SingletonModule<IngameQuickChatDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IngameQuickChatData> _003C_003E9__15_0;

		internal int _003CInitIngameQuickChatData_003Eb__15_0(IngameQuickChatData a, IngameQuickChatData b)
		{
			return 0;
		}
	}

	private List<IngameQuickChatData> m_SortedAllBasicData;

	private Dictionary<uint, IngameQuickChatData> m_BasicDataItemIdMap;

	private Dictionary<uint, List<IngameQuickChatItemData>> m_CustomizationDataGroupIdMap;

	private Dictionary<uint, uint> m_CustomizationDataGroupPriorityMap;

	private Dictionary<uint, IngameQuickChatItemData> m_CustomizationDataItemIdMap;

	private Dictionary<uint, IngameQuickChatItemData> m_NewCustomizationDataItemIdMap;

	private bool m_SoundSettingTabRed;

	private HashSet<uint> m_FakeMsgIdsSet;

	private const int FixedListMsgNum = 12;

	private const int FixedRouletteMsgNum = 8;

	private bool m_IsProcessInGameQuickChatItemDesc;

	private bool m_IsRequestBackpack;

	private CSVAsyncDataMap<int, PraiseKeyData> m_PraiseKeyDataDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void InitIngameQuickChatData()
	{
	}

	public void GetDefaultEquippedMsgList(List<uint> result, EQuickChatCategory category, bool getListMsg)
	{
	}

	public IngameQuickChatData GetBasicMsgData(uint id)
	{
		return null;
	}

	public Dictionary<uint, List<uint>> GetBasicMsgDataDict(EQuickChatCategory category)
	{
		return null;
	}

	public void ProcessInGameQuickChatItemDesc(List<InGameQuickChatItemDesc> inGameQuickChatItemDescs)
	{
	}

	public void UpdateIngameQuickChatItemData()
	{
	}

	public List<IngameQuickChatItemData> GetCustomizationDataListByGroupId(uint groupId)
	{
		return null;
	}

	public EQuickChatPriority GetCustomizationGroupStateByGroupId(uint groupId)
	{
		return (EQuickChatPriority)0;
	}

	public List<uint> GetCustomizationDataGroupIdList(bool needSort = true)
	{
		return null;
	}

	private int SortCustomizationDataGroupId(uint a, uint b)
	{
		return 0;
	}

	private int GetQuickChatQualityPriorityByItemQualityType(int itemQualityType)
	{
		return 0;
	}

	public IngameQuickChatItemData GetCustomizationDataByItemId(uint itemId)
	{
		return null;
	}

	public void OnBackpackChanged(List<Item> items)
	{
	}

	public Color GetQuickChatSplitItemQualityBgColor(int quality)
	{
		return default(Color);
	}

	public bool GetItemIsShowRedTip(uint itemId)
	{
		return false;
	}

	public void SetItemRedTip(uint itemId)
	{
	}

	public bool GetCustomizationTabItemIsShowRedTip(uint groupId)
	{
		return false;
	}

	public bool GetCustomizationTabIsShowRedTip()
	{
		return false;
	}

	public bool GetSoundSettingTabIsShowRedTip()
	{
		return false;
	}

	public void SetSoundSettingTabRedTipKey()
	{
	}

	private bool CheckFakeIdCanUse(uint id)
	{
		return false;
	}

	public uint GetFakeMsgId()
	{
		return 0u;
	}

	public void ClearFakeMsgList()
	{
	}

	public bool CheckMsgIdIsFakeId(uint msgId)
	{
		return false;
	}

	public PraiseKeyData GetPraiseKeyData()
	{
		return null;
	}
}
