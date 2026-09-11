using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCEntityAttributeEditor : IUGCEditor<List<FJOPMIJBFEI>>
{
	private UGCCustomEntityAttributeManager m_CustomEntityManager => null;

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData = null)
	{
		return false;
	}

	public bool UnloadProject()
	{
		return false;
	}

	public bool Export(out byte[] projectDataBytes, out List<FJOPMIJBFEI> runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}
}
