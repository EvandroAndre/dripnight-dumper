using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;

namespace COW.Gameplay.UGC;

internal class UGCHardCodeManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<object, string> _003C_003E9__13_0;

		public static Converter<object, string> _003C_003E9__13_1;

		internal string _003CHandleAimHighLight_003Eb__13_0(object e)
		{
			return null;
		}

		internal string _003CHandleAimHighLight_003Eb__13_1(object e)
		{
			return null;
		}
	}

	private readonly FJEEGHOAKOG m_OwnerGame;

	private readonly UGCEntityDataStore m_EntityModule;

	private readonly IUGCModuleArchTypeMgr m_ArchTypeManager;

	private readonly UGCLevelParamsHelper m_LevelParamsHelper;

	private int m_GSModeTemplateId;

	private bool m_LocalPlayerAimNeedHighlight;

	private const string HIDER_TAG = "HIDER";

	private const string MORPH_TAG = "MORPH";

	private const string HIGHLIGHT_TAG = "HIGHLIGHT";

	public UGCHardCodeManager(FJEEGHOAKOG game, UGCEntityDataStore entityModule, UGCLevelParamsHelper levelParamsHelper)
	{
	}

	private void OnAddEntity(string archTypeID, string ugcEntityID)
	{
	}

	private void OnRemoveEntity(string archTypeID, string ugcEntityID)
	{
	}

	private void ParseParams()
	{
	}

	public void HandleAimHighLight(List<object> tagList, string prevEntity, string curEntity)
	{
	}

	public bool HandleCanWeaponHitEntity(string entityID)
	{
		return false;
	}
}
