using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelNewPlayerUnlockFeature : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GamePatternConfigDesc> _003C_003E9__31_0;

		public static Comparison<GamePatternConfigDesc> _003C_003E9__31_1;

		internal int _003CProcessAffixUnlockParam_003Eb__31_0(GamePatternConfigDesc a, GamePatternConfigDesc b)
		{
			return 0;
		}

		internal int _003CProcessAffixUnlockParam_003Eb__31_1(GamePatternConfigDesc a, GamePatternConfigDesc b)
		{
			return 0;
		}
	}

	public bool CanShowNewPlayerUnlockBanner;

	public const string NewPlayerUnlockFeatureKey = "NewPlayerUnlockFeatureKey_";

	private Dictionary<uint, NewPlayerUnlockFeatureDesc> m_NewPlayerUnlockFeatureDic;

	private Dictionary<uint, uint> m_AffixUnlockParamDic;

	private Dictionary<uint, uint[]> m_AffixCombIDDisplayAffixDic;

	private Dictionary<uint, uint> m_NewPlayerUnlockFeatureShowParamDic;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint GetEventIDByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	public uint GetAffixCombIDByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	public NewPlayerUnlockFeatureDesc GetNewPlayerUnlockFeatureDescByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public uint[] GetDisplayAffixsByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public uint GetAffixUnlockParam(uint gameMode, uint matchMode, uint affixID)
	{
		return 0u;
	}

	public uint GetNewPlayerUnlockFeatureShowParam(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	public List<string> GetUnlockFeatureCDN(uint gameMode, uint matchMode)
	{
		return null;
	}

	public bool CheckHasNewPlayerUnlockFeature(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool CheckFeatureIsUnlock(uint affixID, uint gameMode, uint matchMode)
	{
		return false;
	}

	public List<string> GetIngameUnlockFeatureCDN(uint gameMode, uint matchMode, uint groupMode)
	{
		return null;
	}

	public bool CheckNeedShowNewPlayerFeatureTempUnlockTip(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool CheckHasUnlockFeatureBetweenTwoParam(uint gameMode, uint matchMode, uint lowwerParam, uint upperParam)
	{
		return false;
	}

	public List<uint> GetAffixsNeedToDisplay(uint gameMode, uint matchMode, bool isInGameCDN = false)
	{
		return null;
	}

	public void SetDisPlayAffixsPlayerPrefsValue(uint gameMode, uint matchMode, bool isInGameCDN = false)
	{
	}

	public string GetNewPlayerUnlockFeatureKey(uint gameMode, uint matchMode, bool isInGameCDN = false)
	{
		return null;
	}

	public string GetGameModeMainKeyParam(uint gameMode, uint matchMode)
	{
		return null;
	}

	public ResourceID GetNewPlayerUnlockFeatureContentTipsBtn()
	{
		return default(ResourceID);
	}

	public void ProcessNewPlayerUnlockFeatureDesc(List<NewPlayerUnlockFeatureDesc> res)
	{
	}

	public UIGameModeGameplayAffixPreviewItemViewData[] BuildGameplayAffixPreviewViewDataItems(uint[] lobbyAffixes)
	{
		return null;
	}

	private uint GetCurPlayerUnlockParam(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	private uint GetNewPlayerUnlockFeatureDicKey(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	private void ProcessAffixUnlockParam(NewPlayerUnlockFeatureDesc desc)
	{
	}

	private uint GetAffixUnlockParamKey(uint gameMode, uint matchMode, uint affixID)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
