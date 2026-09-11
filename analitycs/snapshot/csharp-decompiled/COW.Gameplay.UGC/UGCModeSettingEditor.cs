using System;
using COW.GamePlay;
using message;

namespace COW.Gameplay.UGC;

internal class UGCModeSettingEditor : IUGCEditor<CLMPMGMIDGD>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<LJICFKFGFHL> _003C_003E9__7_0;

		internal bool _003CUpgradeProjectToOB39_003Eb__7_0(LJICFKFGFHL e)
		{
			return false;
		}
	}

	private HNDHJGJILHC m_OwnerGame;

	public UGCModeSettingEditor(HNDHJGJILHC ownerGame)
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

	public bool Export(out byte[] projectDataBytes, out CLMPMGMIDGD modeSetting, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		modeSetting = null;
		return false;
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private bool UpgradeProject(MFDKDILMLFP version, CLMPMGMIDGD data)
	{
		return false;
	}

	private bool UpgradeProjectToOB39(CLMPMGMIDGD data)
	{
		return false;
	}
}
