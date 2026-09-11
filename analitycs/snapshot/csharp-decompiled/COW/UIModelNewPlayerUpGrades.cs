using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelNewPlayerUpGrades : UIBaseModel
{
	private NewPlayerTargetData m_TrainIslandData;

	private NewPlayerTargetData m_RankGameData;

	private List<NewPlayerTargetData> m_LevelUpRewardDataList;

	private Dictionary<int, int> m_CanShowLevelUpBubbleMap;

	private UIModelProfile m_ModelProfile;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private bool m_RankGameTypeToGuideAfterRankedFlg;

	private int m_RankModePreferenceCount;

	private float m_ModePreference;

	private Dictionary<uint, List<NewPlayerTargetData>> m_NewPlayerTargetDataDic;

	public List<uint> LevelUpRewardAvatarId;

	public List<uint> NewPlayerTaskAvatarId;

	public NewPlayerTargetData TrainIslandData => null;

	public NewPlayerTargetData RankGameData => null;

	public List<NewPlayerTargetData> LevelUpRewardDataList => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Init()
	{
	}

	public void InitAfterLogin()
	{
	}

	public bool CheckSpecGotoGuide(ENewbieGuideType guideType)
	{
		return false;
	}

	public ENewbieGuideType RankGameTypeToGuide()
	{
		return ENewbieGuideType.None;
	}

	private ENewbieGuideType RankGameTypeToGuideBeforeRanked()
	{
		return ENewbieGuideType.None;
	}

	private ENewbieGuideType RankGameTypeToGuideAfterRanked(uint brTimes, uint csTimes)
	{
		return ENewbieGuideType.None;
	}

	private ENewbieGuideType BRorCSGame(uint brTimes, uint csTimes)
	{
		return ENewbieGuideType.None;
	}

	private void GenerateLevelUpRewardBubbleMap()
	{
	}

	public bool IsUserGuest()
	{
		return false;
	}

	public bool IsLevelUpReward(uint id)
	{
		return false;
	}

	public bool IsFreeAvatar(uint id)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
