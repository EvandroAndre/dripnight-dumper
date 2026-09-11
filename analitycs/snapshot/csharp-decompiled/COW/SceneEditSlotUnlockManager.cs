using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneEditSlotUnlockManager : SingletonModule<SceneEditSlotUnlockManager>
{
	private Dictionary<uint, SceneEditSlotUnlockConfigData> m_SlotUnlockDic;

	private uint m_MaxSlotID;

	protected override void OnInit()
	{
	}

	public uint GetMaxSlotCnt()
	{
		return 0u;
	}

	public SceneEditSlotUnlockConfigData GetSlotUnlcokDataBySlotID(uint slotID)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
