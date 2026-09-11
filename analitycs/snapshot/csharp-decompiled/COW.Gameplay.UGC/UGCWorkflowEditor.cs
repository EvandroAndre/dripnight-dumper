using message;

namespace COW.Gameplay.UGC;

public class UGCWorkflowEditor : IUGCEditor<OHCGHBFNOFA>
{
	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData)
	{
		return false;
	}

	public bool UnloadProject()
	{
		return false;
	}

	public bool Export(uint gameMode, int templateID, UIModeEditData editData, out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	public bool Export(out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	public bool ExportImpl(out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	public bool ExportInfection(out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	public bool ExportTemplate10(UIModeEditData editData, out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}
}
