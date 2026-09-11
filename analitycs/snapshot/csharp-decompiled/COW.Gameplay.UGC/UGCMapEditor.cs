using System.Collections.Generic;
using COW.GamePlay;
using message;

namespace COW.Gameplay.UGC;

internal class UGCMapEditor : IUGCEditor<LPAHANBIOKC>
{
	private HNDHJGJILHC m_OwnerGame;

	private EditorEntityData m_sharedEntityData;

	private string _003CCachedProjectDataJsonString_003Ek__BackingField;

	public string CachedProjectDataJsonString
	{
		get
		{
			return _003CCachedProjectDataJsonString_003Ek__BackingField;
		}
		set
		{
			_003CCachedProjectDataJsonString_003Ek__BackingField = value;
		}
	}

	public UGCMapEditor(HNDHJGJILHC ownerGame)
	{
	}

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData)
	{
		return false;
	}

	public bool UnloadProject()
	{
		return false;
	}

	public bool Export(out byte[] projectDataBytes, out LPAHANBIOKC allSceneRuntimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		allSceneRuntimeData = null;
		return false;
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private LPAHANBIOKC ExportRuntimeData(uint mapID, List<SceneEditObjectBase> allSceneEditObject, EditorMiscData miscData)
	{
		return null;
	}

	private void CollectSceneEditObj(ref List<SceneEditObjectBase> all, ref List<SceneEditObjectBase> root)
	{
	}
}
