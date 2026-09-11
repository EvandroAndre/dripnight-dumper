using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelUGCMyWorks : UIBaseModel
{
	public const uint PropID_RequestSelectedSlotChanged = 1u;

	public const uint PropID_PublishCheckAutoOpenReady = 2u;

	private uint m_CurSelectedSlotId;

	private uint m_CurSelectedServerSlotId;

	private uint m_RequestSelectedSlotId;

	private uint m_RequestSelectedServerSlotId;

	private bool m_PendingPublishCheckAutoOpen;

	private HashSet<string> m_MapInvalidStateCheckedSet;

	private static string m_ServerMapLongShareCodeKey;

	private static string m_ServerMapInvalidStateKey;

	private static string m_ServerMapLastCheckStateKey;

	private HashSet<string> m_MapExpiringCheckedSet;

	private static string m_ServerMapExpiringKey;

	private static string m_ServerMapLastCheckUpdateTimeKey;

	public uint CurSelectedSlotId => 0u;

	public uint CurSelectedServerSlotId => 0u;

	public uint RequestSelectedSlotId => 0u;

	public uint RequestSelectedServerSlotId => 0u;

	public void RequestSelectedSlotProcessed()
	{
	}

	public void CacheSelectedSlot(SceneEditSlotInfo slotInfo)
	{
	}

	public void RequestSelectSlot(SceneEditSlotInfo slotInfo)
	{
	}

	public void RequestSelectSlot(uint slotId = 0u, uint serverSlotId = 0u)
	{
	}

	public void MarkPublishCheckAutoOpenReadyAfterCoverPhoto()
	{
	}

	public void ClearPendingPublishCheckAutoOpen()
	{
	}

	public bool TryGetPendingPublishCheckAutoOpen()
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RegisterMap(SceneEditSlotInfo slotInfo)
	{
	}

	public void SetInvalidStateMapChecked(SceneEditSlotInfo slotInfo)
	{
	}

	public bool IsInvalidStateMapChecked(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public bool HasUncheckedInvalidStateMap()
	{
		return false;
	}

	private long GetSlotExpiredSeconds()
	{
		return 0L;
	}

	private void RegisterExpiringMap(SceneEditSlotInfo slotInfo)
	{
	}

	public void SetExpiringMapChecked(SceneEditSlotInfo slotInfo)
	{
	}

	public bool IsExpiringMapChecked(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public bool IsMapExpiring(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public bool HasUncheckedExpiringMap()
	{
		return false;
	}
}
