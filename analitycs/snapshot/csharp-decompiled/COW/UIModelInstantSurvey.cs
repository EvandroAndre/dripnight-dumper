using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelInstantSurvey : UIBaseModel
{
	public class QuickFeedbackQuestionGroup
	{
		public QuickFeedbackQuestDesc Root;

		public readonly List<QuickFeedbackQuestDesc> Questions;

		public uint Weight => 0u;

		public uint QuestionCount => 0u;
	}

	public const uint LowLevelLimit = 12u;

	public const float MatchResultDelaySeconds = 0f;

	private const string PopupStampKeyPrefix = "InstantSurvey_LastPopupTimestamp_";

	private const string VoiceQuestionStampKeyPrefix = "InstantSurvey_VoiceQuestStamp_";

	private const string IfOnlyQuestionStampKeyPrefix = "InstantSurvey_IfOnlyQuestStamp_";

	private const uint StageMatchmaking = 1u;

	private const uint StageMatchResult = 2u;

	private uint[] m_MatchAffixIds;

	private ulong m_VoiceMatchId;

	private bool m_TeammateMicEverOpenedThisMatch;

	private bool m_LocalSpeakerEverOpenedThisMatch;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool TryEnsureSurveyDataReady()
	{
		return false;
	}

	public bool IsLevelAllowed()
	{
		return false;
	}

	public bool IsCDValid()
	{
		return false;
	}

	public void RecordPopupShown()
	{
	}

	public void SetMatchAffixIds(uint[] affixIds)
	{
	}

	public QuickFeedbackQuestionGroup PickQuestionGroup(EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode)
	{
		return null;
	}

	private bool IsVoiceGroup(QuickFeedbackQuestionGroup group)
	{
		return false;
	}

	public QuickFeedbackQuestDesc PickNextQuestion(QuickFeedbackQuestionGroup questionGroup, EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode, HashSet<uint> askedQuestionIds, HashSet<uint> answeredQuestionIds)
	{
		return null;
	}

	private List<QuickFeedbackQuestionGroup> BuildQuestionGroups(List<QuickFeedbackQuestDesc> allData)
	{
		return null;
	}

	private QuickFeedbackQuestionGroup BuildQuestionGroup(QuickFeedbackQuestDesc root, Dictionary<uint, List<QuickFeedbackQuestDesc>> childrenByPreId, HashSet<uint> groupedIds)
	{
		return null;
	}

	private void AddQuestionToGroup(QuickFeedbackQuestDesc question, Dictionary<uint, List<QuickFeedbackQuestDesc>> childrenByPreId, HashSet<uint> groupedIds, QuickFeedbackQuestionGroup group)
	{
	}

	private List<QuickFeedbackQuestDesc> GetAllQuestions()
	{
		return null;
	}

	private bool CanUseGroup(QuickFeedbackQuestionGroup group, EQuickFeedbackPlayerTag playerTag, EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode)
	{
		return false;
	}

	private bool CanUseQuestionInCurrentGroup(QuickFeedbackQuestionGroup questionGroup, QuickFeedbackQuestDesc data, EQuickFeedbackPlayerTag playerTag, EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode, HashSet<uint> askedQuestionIds, HashSet<uint> answeredQuestionIds)
	{
		return false;
	}

	private bool CanUseQuestionBase(QuickFeedbackQuestDesc data, EQuickFeedbackPlayerTag playerTag, EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode, HashSet<uint> askedQuestionIds = null)
	{
		return false;
	}

	private bool IsActiveAffix(uint affixId)
	{
		return false;
	}

	private bool IsQuestionTypeAllowed(QuickFeedbackQuestDesc data, EQuickFeedbackTriggerScene scene)
	{
		return false;
	}

	private QuickFeedbackQuestDesc PickWeightedQuestion(List<QuickFeedbackQuestDesc> candidates, uint totalWeight, HashSet<uint> askedQuestionIds)
	{
		return null;
	}

	private QuickFeedbackQuestionGroup PickWeightedGroup(List<QuickFeedbackQuestionGroup> candidates, uint totalWeight)
	{
		return null;
	}

	private QuickFeedbackQuestDesc MarkQuestionAsked(QuickFeedbackQuestDesc question, HashSet<uint> askedQuestionIds)
	{
		return null;
	}

	private bool IsStageMatched(QuickFeedbackQuestDesc data, EQuickFeedbackTriggerScene scene)
	{
		return false;
	}

	private uint GetStageValue(EQuickFeedbackTriggerScene scene)
	{
		return 0u;
	}

	private bool IsIfOnlyQuestionValid(QuickFeedbackQuestDesc data)
	{
		return false;
	}

	private bool IsModeMatched(QuickFeedbackQuestDesc data, EQuickFeedbackTriggerScene scene, uint gameMode, uint matchMode)
	{
		return false;
	}

	private bool IsPlayerTagAllowed(QuickFeedbackQuestDesc data, EQuickFeedbackPlayerTag tag)
	{
		return false;
	}

	public EQuickFeedbackPlayerTag GetCurrentPlayerTag()
	{
		return EQuickFeedbackPlayerTag.None;
	}

	private ulong GetCurrentMatchId()
	{
		return 0uL;
	}

	public void NotifyTeammateVoiceOn(string voiceUserId)
	{
	}

	public void NotifyLocalSpeakerListenModeChanged(EGameVoiceListenMode mode)
	{
	}

	public void ClearVoiceMatchState()
	{
	}

	public bool IsVoiceConditionsMet()
	{
		return false;
	}

	private bool IsLocalSpeakerOnNowOrEver()
	{
		return false;
	}

	private void EnsureVoiceMatchScope()
	{
	}

	private bool IsLocalVoiceUserId(string voiceUserId)
	{
		return false;
	}

	public bool IsVoiceQuestionCDValid(uint questionId)
	{
		return false;
	}

	public void RecordVoiceQuestionShown(uint questionId)
	{
	}

	public void RecordQuestionShown(QuickFeedbackQuestDesc question)
	{
	}

	private string GetVoiceQuestionStampKey(uint questionId)
	{
		return null;
	}

	private ulong GetVoiceQuestionStamp(uint questionId)
	{
		return 0uL;
	}

	private void SaveVoiceQuestionStamp(uint questionId, ulong stamp)
	{
	}

	private string GetIfOnlyQuestionStampKey(uint questionId)
	{
		return null;
	}

	private ulong GetIfOnlyQuestionStamp(uint questionId)
	{
		return 0uL;
	}

	private void SaveIfOnlyQuestionStamp(uint questionId, ulong stamp)
	{
	}

	private string GetCDStampKey()
	{
		return null;
	}

	private ulong GetAccountId()
	{
		return 0uL;
	}

	private ulong GetLastPopupStamp()
	{
		return 0uL;
	}

	private void SaveLastPopupStamp(ulong stamp)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
