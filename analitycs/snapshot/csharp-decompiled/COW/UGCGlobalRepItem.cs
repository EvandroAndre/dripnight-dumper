using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGlobalRepItem
{
	public const int PROP_ID_ISINVALIDMATCH = -11000;

	public const int PROP_ID_GAMETIMEMS = -11001;

	public const int PROP_ID_CURROUNDINDEX = -11002;

	public const int PROP_ID_CURPHASEINDEX = -11003;

	public const int PROP_ID_MODETEMPLATEID = -11004;

	public const int PROP_ID_HUMANCANREVIVE = -11005;

	public const int PROP_ID_BOTCANREVIVE = -11006;

	public const int PROP_ID_REVIVECDTIME = -11007;

	public const int PROP_ID_TEAMNUM = -11008;

	public const int PROP_ID_TEAMMEMBERNUM = -11009;

	public const int PROP_ID_RESETEQUIPMENT = -11010;

	public const int PROP_ID_SAFEZONEENABLED = -11011;

	public const int PROP_ID_SAFEZONESIZE = -11012;

	public const int PROP_ID_SAFEZONESTARTTIME = -11013;

	public const int PROP_ID_SAFEZONESHRINKTIME = -11014;

	public const int PROP_ID_SAFEZONEDAMAGE = -11015;

	public const int PROP_ID_TARGETSCORE = -11016;

	public const int PROP_ID_KILLINGSCORE = -11017;

	public const int PROP_ID_REVIVERULE = -11018;

	public const int PROP_ID_PLAYERROUNDRANKINGRULESCORETYPE = -11019;

	public const int PROP_ID_PLAYERROUNDRANKINGRULESORTTYPE = -11020;

	public const int PROP_ID_TEAMROUNDRANKINGRULESCORETYPE = -11021;

	public const int PROP_ID_TEAMROUNDRANKINGRULESORTTYPE = -11022;

	public const int PROP_ID_MVPRULESCORETYPE = -11023;

	public const int PROP_ID_MVPRULESCOREWEIGHT = -11024;

	public const int PROP_ID_ROUNDRANKTOSCOREMAP = -11025;

	public const int PROP_ID_SCORETYPETOSHOWRESULT = -11026;

	public const int PROP_ID_SUMROUNDCOUNT = -11027;

	public const int PROP_ID_TEAMRANKACCUMULATESCORETYPE = -11028;

	public const int PROP_ID_TEAMRANKACCUMULATESCOREORDER = -11029;

	public const int PROP_ID_PLAYERRANKACCUMULATESCORETYPE = -11030;

	public const int PROP_ID_PLAYERRANKACCUMULATESCOREORDER = -11031;

	public const int PROP_ID_ECOROUNDMONEY = -11032;

	public const int PROP_ID_ECOKILLMONEY = -11033;

	public const int PROP_ID_ECOWINMONEY = -11034;

	public const int PROP_ID_COINHUDSHOW = -11035;

	public const int PROP_ID_SKYBOXENV = -11036;

	public const int PROP_ID_FRAMECOUNT = -11037;

	public const int PROP_ID_MATCHCANMOVE = -11038;

	public const int PROP_ID_CUSTOMMATCHRESULT = -11039;

	public const int PROP_ID_ENABLEHALFWAYJOIN = -11040;

	public const int PROP_ID_ENABLEENERGYSAVINGMODE = -11041;

	public const int PROP_ID_DELTATIME = -11042;

	public const int PROP_ID_FIXEDDELTATIME = -11043;

	public const int PROP_ID_DISTANCEVOLUMES = -11044;

	public const int PROP_ID_FILTER = -11045;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCurRoundIndexChangeEvent;

	public Action<int> OnCurPhaseIndexChangeEvent;

	public Action<int> OnModeTemplateIDChangeEvent;

	public Action<bool> OnHumanCanReviveChangeEvent;

	public Action<bool> OnBotCanReviveChangeEvent;

	public Action<int> OnReviveCDTimeChangeEvent;

	public Action<int> OnTeamNumChangeEvent;

	public Action<int> OnTeamMemberNumChangeEvent;

	public Action<bool> OnResetEquipmentChangeEvent;

	public Action<bool> OnSafeZoneEnabledChangeEvent;

	public Action<float> OnSafeZoneSizeChangeEvent;

	public Action<float> OnSafeZoneStartTimeChangeEvent;

	public Action<float> OnSafeZoneShrinkTimeChangeEvent;

	public Action<float> OnSafeZoneDamageChangeEvent;

	public Action<int> OnTargetScoreChangeEvent;

	public Action<int> OnKillingScoreChangeEvent;

	public Action<int> OnReviveRuleChangeEvent;

	public Action<List<object>> OnPlayerRoundRankingRuleScoreTypeChangeEvent;

	public Action<List<object>> OnPlayerRoundRankingRuleSortTypeChangeEvent;

	public Action<List<object>> OnTeamRoundRankingRuleScoreTypeChangeEvent;

	public Action<List<object>> OnTeamRoundRankingRuleSortTypeChangeEvent;

	public Action<List<object>> OnMVPRuleScoreTypeChangeEvent;

	public Action<List<object>> OnMVPRuleScoreWeightChangeEvent;

	public Action<List<object>> OnRoundRankToScoreMapChangeEvent;

	public Action<List<object>> OnScoreTypeToShowResultChangeEvent;

	public Action<int> OnSumRoundCountChangeEvent;

	public Action<int> OnTeamRankAccumulateScoreTypeChangeEvent;

	public Action<int> OnTeamRankAccumulateScoreOrderChangeEvent;

	public Action<int> OnPlayerRankAccumulateScoreTypeChangeEvent;

	public Action<int> OnPlayerRankAccumulateScoreOrderChangeEvent;

	public Action<int> OnEcoRoundMoneyChangeEvent;

	public Action<int> OnEcoKillMoneyChangeEvent;

	public Action<int> OnEcoWinMoneyChangeEvent;

	public Action<bool> OnCoinHudShowChangeEvent;

	public Action<string> OnSkyboxEnvChangeEvent;

	public Action<bool> OnMatchCanMoveChangeEvent;

	public Action<bool> OnCustomMatchResultChangeEvent;

	public Action<bool> OnEnableHalfwayJoinChangeEvent;

	public Action<bool> OnEnableEnergySavingModeChangeEvent;

	public Action<string> OnDistanceVolumesChangeEvent;

	public Action<string> OnFilterChangeEvent;

	private int _003CCurRoundIndex_003Ek__BackingField;

	private int _003CCurPhaseIndex_003Ek__BackingField;

	private int _003CModeTemplateID_003Ek__BackingField;

	private bool _003CHumanCanRevive_003Ek__BackingField;

	private bool _003CBotCanRevive_003Ek__BackingField;

	private int _003CReviveCDTime_003Ek__BackingField;

	private int _003CTeamNum_003Ek__BackingField;

	private int _003CTeamMemberNum_003Ek__BackingField;

	private bool _003CResetEquipment_003Ek__BackingField;

	private bool _003CSafeZoneEnabled_003Ek__BackingField;

	private float _003CSafeZoneSize_003Ek__BackingField;

	private float _003CSafeZoneStartTime_003Ek__BackingField;

	private float _003CSafeZoneShrinkTime_003Ek__BackingField;

	private float _003CSafeZoneDamage_003Ek__BackingField;

	private int _003CTargetScore_003Ek__BackingField;

	private int _003CKillingScore_003Ek__BackingField;

	private int _003CReviveRule_003Ek__BackingField;

	private List<object> _003CPlayerRoundRankingRuleScoreType_003Ek__BackingField;

	private List<object> _003CPlayerRoundRankingRuleSortType_003Ek__BackingField;

	private List<object> _003CTeamRoundRankingRuleScoreType_003Ek__BackingField;

	private List<object> _003CTeamRoundRankingRuleSortType_003Ek__BackingField;

	private List<object> _003CMVPRuleScoreType_003Ek__BackingField;

	private List<object> _003CMVPRuleScoreWeight_003Ek__BackingField;

	private List<object> _003CRoundRankToScoreMap_003Ek__BackingField;

	private List<object> _003CScoreTypeToShowResult_003Ek__BackingField;

	private int _003CSumRoundCount_003Ek__BackingField;

	private int _003CTeamRankAccumulateScoreType_003Ek__BackingField;

	private int _003CTeamRankAccumulateScoreOrder_003Ek__BackingField;

	private int _003CPlayerRankAccumulateScoreType_003Ek__BackingField;

	private int _003CPlayerRankAccumulateScoreOrder_003Ek__BackingField;

	private int _003CEcoRoundMoney_003Ek__BackingField;

	private int _003CEcoKillMoney_003Ek__BackingField;

	private int _003CEcoWinMoney_003Ek__BackingField;

	private bool _003CCoinHudShow_003Ek__BackingField;

	private string _003CSkyboxEnv_003Ek__BackingField;

	private bool _003CMatchCanMove_003Ek__BackingField;

	private bool _003CCustomMatchResult_003Ek__BackingField;

	private bool _003CEnableHalfwayJoin_003Ek__BackingField;

	private bool _003CEnableEnergySavingMode_003Ek__BackingField;

	private string _003CDistanceVolumes_003Ek__BackingField;

	private string _003CFilter_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int CurRoundIndex
	{
		get
		{
			return _003CCurRoundIndex_003Ek__BackingField;
		}
		private set
		{
			_003CCurRoundIndex_003Ek__BackingField = value;
		}
	}

	public int CurPhaseIndex
	{
		get
		{
			return _003CCurPhaseIndex_003Ek__BackingField;
		}
		private set
		{
			_003CCurPhaseIndex_003Ek__BackingField = value;
		}
	}

	public int ModeTemplateID
	{
		get
		{
			return _003CModeTemplateID_003Ek__BackingField;
		}
		private set
		{
			_003CModeTemplateID_003Ek__BackingField = value;
		}
	}

	public bool HumanCanRevive
	{
		get
		{
			return _003CHumanCanRevive_003Ek__BackingField;
		}
		private set
		{
			_003CHumanCanRevive_003Ek__BackingField = value;
		}
	}

	public bool BotCanRevive
	{
		get
		{
			return _003CBotCanRevive_003Ek__BackingField;
		}
		private set
		{
			_003CBotCanRevive_003Ek__BackingField = value;
		}
	}

	public int ReviveCDTime
	{
		get
		{
			return _003CReviveCDTime_003Ek__BackingField;
		}
		private set
		{
			_003CReviveCDTime_003Ek__BackingField = value;
		}
	}

	public int TeamNum
	{
		get
		{
			return _003CTeamNum_003Ek__BackingField;
		}
		private set
		{
			_003CTeamNum_003Ek__BackingField = value;
		}
	}

	public int TeamMemberNum
	{
		get
		{
			return _003CTeamMemberNum_003Ek__BackingField;
		}
		private set
		{
			_003CTeamMemberNum_003Ek__BackingField = value;
		}
	}

	public bool ResetEquipment
	{
		get
		{
			return _003CResetEquipment_003Ek__BackingField;
		}
		private set
		{
			_003CResetEquipment_003Ek__BackingField = value;
		}
	}

	public bool SafeZoneEnabled
	{
		get
		{
			return _003CSafeZoneEnabled_003Ek__BackingField;
		}
		private set
		{
			_003CSafeZoneEnabled_003Ek__BackingField = value;
		}
	}

	public float SafeZoneSize
	{
		get
		{
			return _003CSafeZoneSize_003Ek__BackingField;
		}
		private set
		{
			_003CSafeZoneSize_003Ek__BackingField = value;
		}
	}

	public float SafeZoneStartTime
	{
		get
		{
			return _003CSafeZoneStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CSafeZoneStartTime_003Ek__BackingField = value;
		}
	}

	public float SafeZoneShrinkTime
	{
		get
		{
			return _003CSafeZoneShrinkTime_003Ek__BackingField;
		}
		private set
		{
			_003CSafeZoneShrinkTime_003Ek__BackingField = value;
		}
	}

	public float SafeZoneDamage
	{
		get
		{
			return _003CSafeZoneDamage_003Ek__BackingField;
		}
		private set
		{
			_003CSafeZoneDamage_003Ek__BackingField = value;
		}
	}

	public int TargetScore
	{
		get
		{
			return _003CTargetScore_003Ek__BackingField;
		}
		private set
		{
			_003CTargetScore_003Ek__BackingField = value;
		}
	}

	public int KillingScore
	{
		get
		{
			return _003CKillingScore_003Ek__BackingField;
		}
		private set
		{
			_003CKillingScore_003Ek__BackingField = value;
		}
	}

	public int ReviveRule
	{
		get
		{
			return _003CReviveRule_003Ek__BackingField;
		}
		private set
		{
			_003CReviveRule_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerRoundRankingRuleScoreType
	{
		get
		{
			return _003CPlayerRoundRankingRuleScoreType_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRoundRankingRuleScoreType_003Ek__BackingField = value;
		}
	}

	public List<object> PlayerRoundRankingRuleSortType
	{
		get
		{
			return _003CPlayerRoundRankingRuleSortType_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRoundRankingRuleSortType_003Ek__BackingField = value;
		}
	}

	public List<object> TeamRoundRankingRuleScoreType
	{
		get
		{
			return _003CTeamRoundRankingRuleScoreType_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRoundRankingRuleScoreType_003Ek__BackingField = value;
		}
	}

	public List<object> TeamRoundRankingRuleSortType
	{
		get
		{
			return _003CTeamRoundRankingRuleSortType_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRoundRankingRuleSortType_003Ek__BackingField = value;
		}
	}

	public List<object> MVPRuleScoreType
	{
		get
		{
			return _003CMVPRuleScoreType_003Ek__BackingField;
		}
		private set
		{
			_003CMVPRuleScoreType_003Ek__BackingField = value;
		}
	}

	public List<object> MVPRuleScoreWeight
	{
		get
		{
			return _003CMVPRuleScoreWeight_003Ek__BackingField;
		}
		private set
		{
			_003CMVPRuleScoreWeight_003Ek__BackingField = value;
		}
	}

	public List<object> RoundRankToScoreMap
	{
		get
		{
			return _003CRoundRankToScoreMap_003Ek__BackingField;
		}
		private set
		{
			_003CRoundRankToScoreMap_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreTypeToShowResult
	{
		get
		{
			return _003CScoreTypeToShowResult_003Ek__BackingField;
		}
		private set
		{
			_003CScoreTypeToShowResult_003Ek__BackingField = value;
		}
	}

	public int SumRoundCount
	{
		get
		{
			return _003CSumRoundCount_003Ek__BackingField;
		}
		private set
		{
			_003CSumRoundCount_003Ek__BackingField = value;
		}
	}

	public int TeamRankAccumulateScoreType
	{
		get
		{
			return _003CTeamRankAccumulateScoreType_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankAccumulateScoreType_003Ek__BackingField = value;
		}
	}

	public int TeamRankAccumulateScoreOrder
	{
		get
		{
			return _003CTeamRankAccumulateScoreOrder_003Ek__BackingField;
		}
		private set
		{
			_003CTeamRankAccumulateScoreOrder_003Ek__BackingField = value;
		}
	}

	public int PlayerRankAccumulateScoreType
	{
		get
		{
			return _003CPlayerRankAccumulateScoreType_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRankAccumulateScoreType_003Ek__BackingField = value;
		}
	}

	public int PlayerRankAccumulateScoreOrder
	{
		get
		{
			return _003CPlayerRankAccumulateScoreOrder_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerRankAccumulateScoreOrder_003Ek__BackingField = value;
		}
	}

	public int EcoRoundMoney
	{
		get
		{
			return _003CEcoRoundMoney_003Ek__BackingField;
		}
		private set
		{
			_003CEcoRoundMoney_003Ek__BackingField = value;
		}
	}

	public int EcoKillMoney
	{
		get
		{
			return _003CEcoKillMoney_003Ek__BackingField;
		}
		private set
		{
			_003CEcoKillMoney_003Ek__BackingField = value;
		}
	}

	public int EcoWinMoney
	{
		get
		{
			return _003CEcoWinMoney_003Ek__BackingField;
		}
		private set
		{
			_003CEcoWinMoney_003Ek__BackingField = value;
		}
	}

	public bool CoinHudShow
	{
		get
		{
			return _003CCoinHudShow_003Ek__BackingField;
		}
		private set
		{
			_003CCoinHudShow_003Ek__BackingField = value;
		}
	}

	public string SkyboxEnv
	{
		get
		{
			return _003CSkyboxEnv_003Ek__BackingField;
		}
		private set
		{
			_003CSkyboxEnv_003Ek__BackingField = value;
		}
	}

	public bool MatchCanMove
	{
		get
		{
			return _003CMatchCanMove_003Ek__BackingField;
		}
		private set
		{
			_003CMatchCanMove_003Ek__BackingField = value;
		}
	}

	public bool CustomMatchResult
	{
		get
		{
			return _003CCustomMatchResult_003Ek__BackingField;
		}
		private set
		{
			_003CCustomMatchResult_003Ek__BackingField = value;
		}
	}

	public bool EnableHalfwayJoin
	{
		get
		{
			return _003CEnableHalfwayJoin_003Ek__BackingField;
		}
		private set
		{
			_003CEnableHalfwayJoin_003Ek__BackingField = value;
		}
	}

	public bool EnableEnergySavingMode
	{
		get
		{
			return _003CEnableEnergySavingMode_003Ek__BackingField;
		}
		private set
		{
			_003CEnableEnergySavingMode_003Ek__BackingField = value;
		}
	}

	public string DistanceVolumes
	{
		get
		{
			return _003CDistanceVolumes_003Ek__BackingField;
		}
		private set
		{
			_003CDistanceVolumes_003Ek__BackingField = value;
		}
	}

	public string Filter
	{
		get
		{
			return _003CFilter_003Ek__BackingField;
		}
		private set
		{
			_003CFilter_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCGlobalRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
