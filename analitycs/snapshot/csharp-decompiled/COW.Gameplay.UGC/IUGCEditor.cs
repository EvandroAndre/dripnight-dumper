using message;

namespace COW.Gameplay.UGC;

public interface IUGCEditor<T>
{
	bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData = null);

	bool UnloadProject();

	bool Export(out byte[] projectDataBytes, out T runtimeData, ref EditorMiscData miscData);

	bool CheckLegality(ref EditorMiscData miscData);
}
