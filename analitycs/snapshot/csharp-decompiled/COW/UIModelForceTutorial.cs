using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelForceTutorial : UIBaseModel
{
	public enum ERequestFlag
	{
		None,
		Success,
		DataError,
		RequestError
	}

	public enum EScoreStep
	{
		None,
		First,
		TemporaryNewBie,
		TemporaryFPS
	}

	public enum EScoreEventType
	{
		None,
		HeadShotRate,
		KillTotalTime,
		WeaponReloadNum,
		OpenSightNum,
		IsSquatupDuringUseMedicate,
		UseReleaseGrenade
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public UIModelForceTutorial _003C_003E4__this;

		public bool isChoiceChanged;

		public EAccount.NewbieChoice oldChoice;

		public EAccount.NewbieChoice choice;

		internal void _003CRequestUpdateAccountNewbieChoice_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_UpdateNewbieChoiceType = 1u;

	public const uint PropID_UpdateSelectMapMode = 2u;

	private EAccount.NewbieChoice m_TestNewBieChoiceType;

	private uint m_TestCurPhase;

	private ERequestFlag m_RequestFlag;

	private readonly Dictionary<uint, NewbieTutorialScoreDesc> m_DicEvaluateIDToScoreDesc;

	private List<NewbieTagSeparateDesc> m_DicNewbieTagSeparateDescList;

	private float m_StepTotalScore;

	private readonly Dictionary<uint, EventLogger.EventTypeForceTutorialEvaluateInfo> m_EventLogForceEvaluateInfos;

	private bool m_HasUpdateNewBieType;

	public EAccount.NewbieChoice TestNewBieChoiceType => EAccount.NewbieChoice.NewbieChoice_NONE;

	public uint TestCurPhase => 0u;

	public ERequestFlag RequestFlag => ERequestFlag.None;

	public float StepTotalScore => 0f;

	public bool HasUpdateNewBieType => false;

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

	public void SetTestNewBieChoiceType(EAccount.NewbieChoice type)
	{
	}

	public void SetTestCurPhaseType(uint id)
	{
	}

	private void ProcssDicScoreDesc(CSGetNewbieTutorialDescRes data)
	{
	}

	private void ProcssDicSeparateDesc(CSGetNewbieTutorialDescRes data)
	{
	}

	private float CalFactorScore(EScoreEventType eventType, float curParam, EScoreStep step)
	{
		return 0f;
	}

	private EAccount.NewbieChoice GetCaledNewBieChoiceByTotalScore(float totalScore, bool useFinaleScore = false)
	{
		return EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	private void ProcessEventLogEvaluate(uint id, float value, float score)
	{
	}

	private string GetCdnUrlByLanguage(string originUrl)
	{
		return null;
	}

	public EAccount.NewbieChoice CalFirstStepType(float headShotRate, float killTotalTime, int weaponReloadTimes, int openSightTimes)
	{
		return EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	public EAccount.NewbieChoice CalTemporaryNewBieType(float headShotRate, float killTotalTime, int weaponReloadTimes, int openSightTimes, bool isSquatupDuringUseMedicate)
	{
		return EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	public EAccount.NewbieChoice CalTemporaryFPSType(float headShotRate, float killTotalTime, int weaponReloadTimes, int openSightTimes, bool UseReleaseGrenade)
	{
		return EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	public Dictionary<uint, EventLogger.EventTypeForceTutorialEvaluateInfo> GetDicEventLogForceEvaluateInfos()
	{
		return null;
	}

	public void ClearDicEventLogForceEvaluateInfos()
	{
	}

	public List<string> GetLoadingCDNUrls()
	{
		return null;
	}

	public void PreDownloadTutorialLoadingCDN()
	{
	}

	public List<string> GetFpsHudChangeUrls()
	{
		return null;
	}

	public string GetSkillINtroduceUrl(int index)
	{
		return null;
	}

	public List<string> GetSkillINtroduceUrls()
	{
		return null;
	}

	public void RequestNewbieTutorialDesc(HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestUpdateAccountNewbieChoice(EAccount.NewbieChoice choice, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	private void _003CRequestNewbieTutorialDesc_003Eb__45_0(HttpErrorCode errorCode, object res)
	{
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
