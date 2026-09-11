using System.Collections.Generic;
using GCommon;
using TsiU;
using message;

namespace COW.Gameplay.UGC;

public class ResourceEditorBuildinRes_AC : TSingleton<ResourceEditorBuildinRes_AC>
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public JBDFMDFACGC acData;

		public byte[] data;

		public OLEDMLOHNFH resItem;

		internal void _003CGetOrAddSharedACDataFromManager_003Eb__0(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private Dictionary<uint, JBDFMDFACGC> m_id2AcData;

	private Dictionary<string, JBDFMDFACGC> m_resuuid2AcData;

	private List<CSVBaseData> m_cacheTableDataList;

	private static string S_Idle;

	private void validateACTable()
	{
	}

	private KFMNNDOIMBG getOrAddState(JBDFMDFACGC ac, WorkshopNPCACGenarate acData)
	{
		return null;
	}

	private JBDFMDFACGC buildAC(uint typeOrPetID)
	{
		return null;
	}

	public float GetAnimationClipLength(string resName)
	{
		return 0f;
	}

	public JBDFMDFACGC GetNPCAnimtionControllerData(uint typeOrPetID)
	{
		return null;
	}

	public JBDFMDFACGC CreateNewNPCACDataReplaceIdle(uint typeOrPetID, string idleClipUUID, float clipLength)
	{
		return null;
	}

	public string GetOrAddSharedACDataFromManager(uint typeOrPetID, string idleClipUUID, bool forceUpdate = true)
	{
		return null;
	}
}
