using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class InGameLevelUpgradeManager : SingletonModule<InGameLevelUpgradeManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<InGameLevelUpgrade> _003C_003E9__6_0;

		internal int _003CInitData_003Eb__6_0(InGameLevelUpgrade a, InGameLevelUpgrade b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public List<InGameLevelUpgrade> inGameLevelUpgradeList;

		public int i;

		public Predicate<InGameLevelUpgrade> _003C_003E9__0;

		internal bool _003CGetUnlockedUpgradeListAccordingToCurrentLevel_003Eb__0(InGameLevelUpgrade e)
		{
			return false;
		}
	}

	public static byte TeamCrystalNeedFragments;

	private List<InGameLevelUpgradeSource> m_CompleteInGameLevelUpgradeSourceList;

	private List<InGameLevelUpgradeSource> m_FragmentInGameLevelUpgradeSourceList;

	private Dictionary<uint, List<InGameLevelUpgrade>> m_IDToInGameLevelUpgradeListDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void InitData()
	{
	}

	private void ClearData()
	{
	}

	public List<InGameLevelUpgradeSource> GetInGameLevelUpgradeSourceList(DCGENOPBOEE upgradeGemType)
	{
		return null;
	}

	public List<InGameLevelUpgrade> GetInGameLevelUpgradeList(uint loadoutID)
	{
		return null;
	}

	public List<InGameLevelUpgrade> GetUnlockedUpgradeListAccordingToCurrentLevel(uint currentLevel, uint loadoutID)
	{
		return null;
	}

	public InGameLevelUpgrade GetNextUpgradeData(uint currentLevel, uint loadoutID)
	{
		return null;
	}

	public uint GetCurrentTotalLevelExp(uint currentLevel, uint loadoutID)
	{
		return 0u;
	}
}
