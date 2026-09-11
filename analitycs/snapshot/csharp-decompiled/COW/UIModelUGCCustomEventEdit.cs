using System.Collections.Generic;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using ECAPackage;
using GCommon;
using message;

namespace COW;

public class UIModelUGCCustomEventEdit : UIBaseModel, IUGCEditor<PEDPONDINCG>
{
	public const uint PropID_CurSelectEventChanged = 1u;

	public const uint PropID_EventParamListChanged = 2u;

	public const uint PropID_EventListChanged = 4u;

	public PEDPONDINCG CustomEventData;

	internal UGCEditorManager UGCEditorManager;

	private NEIFIIBPMOM m_CurSelectEvent;

	private PEDPONDINCG m_OldCopy;

	private Dictionary<int, List<NEIFIIBPMOM>> m_ExternalEventItems;

	public NEIFIIBPMOM CurSelectEvent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void SetSomethingToSave()
	{
	}

	public NEIFIIBPMOM GetEventItemById(string id)
	{
		return null;
	}

	public NEIFIIBPMOM CreateCustomEvent()
	{
		return null;
	}

	public NEIFIIBPMOM CreateCustomEventCopy(NEIFIIBPMOM origin)
	{
		return null;
	}

	public void RemoveCustomEvent(NEIFIIBPMOM eventItem)
	{
	}

	public List<string> GetDuplicatedNameEventItemUid()
	{
		return null;
	}

	public int CalculateCustomEventBlockCount(BlockEditGraphs blockGraphs)
	{
		return 0;
	}

	public FDGCNDLOKME CreateEventParam(NEIFIIBPMOM eventItem)
	{
		return null;
	}

	bool IUGCEditor<PEDPONDINCG>.LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData)
	{
		return false;
	}

	private static void MigrateDeprecatedParamTypes(PEDPONDINCG data)
	{
	}

	bool IUGCEditor<PEDPONDINCG>.UnloadProject()
	{
		return false;
	}

	bool IUGCEditor<PEDPONDINCG>.Export(out byte[] projectDataBytes, out PEDPONDINCG runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	bool IUGCEditor<PEDPONDINCG>.CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private NEIFIIBPMOM CopyEventItem(NEIFIIBPMOM eventItem)
	{
		return null;
	}

	private FDGCNDLOKME CopyEventItemParam(FDGCNDLOKME param)
	{
		return null;
	}

	public void CreateOldCopy()
	{
	}

	public bool IsInOldCopy(string eventUid)
	{
		return false;
	}

	public PEDPONDINCG GetOldCopy()
	{
		return null;
	}

	public List<string> GetDirtyEventItemsUid()
	{
		return null;
	}

	private bool Equals(NEIFIIBPMOM item1, NEIFIIBPMOM item2)
	{
		return false;
	}

	public void ClearExternalEventItem()
	{
	}

	public void AddExternalEventItem(EUGCUserCustomEventSource source, NEIFIIBPMOM eventItem)
	{
	}

	public List<NEIFIIBPMOM> GetExternalEventItems(EUGCUserCustomEventSource source)
	{
		return null;
	}

	public NEIFIIBPMOM GetExternalEventItem(EUGCUserCustomEventSource source, string eventId)
	{
		return null;
	}

	public NEIFIIBPMOM ConvertECAEventDefine(ECAEventDefine ecaEvent)
	{
		return null;
	}
}
