using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class MatchResultTaskDataManager : SingletonModule<MatchResultTaskDataManager>, IUIModelDataChangeObserver
{
	private byte m_ReadyFlag;

	public const byte STEP_EPCHANLLENGE_READY = 1;

	public const byte STEP_VETERAN_READY = 2;

	public const byte STEP_NEWPLAYER_READY = 4;

	public const byte STEP_DailyChallenge_READY = 8;

	public const byte STEP_AVATARAWAKEN_READY = 16;

	public const float PlayAnimTime = 1.5f;

	private byte m_AllReadyStep;

	private bool m_HasShowRewardWnd;

	private UIModelVeteran m_VeteranModel;

	private UIModelNewPlayerV3 m_NewPlayerModel;

	private UIModelBooyahPass m_BooyahPassModel;

	private UIModelAvatarProfile m_AvatarProfileModel;

	private UIModelActivity m_ModelActivity;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private Dictionary<uint, ClientActivityDesc> m_BigEventTaskDic;

	private Dictionary<uint, ClientActivityDesc> m_TemplateBigEventTaskDic;

	public string BigEventTemplateIconCDN;

	private Dictionary<EActivity.SubType, string> m_BigEventIconCDNDict;

	private AutoOpenIntegrationData m_AutoOpenIntegrationData;

	private bool m_ActivityDescReady;

	private bool m_BigEventOpenInfoReady;

	private bool m_BigEventTemplateOpenInfoReady;

	public Dictionary<uint, ClientActivityDesc> BigEventTaskDic => null;

	public Dictionary<uint, ClientActivityDesc> TemplateBigEventTaskDic => null;

	public bool HasShowRewardWnd => false;

	public bool IsShowCommonRewardWnd => false;

	public string GetBigEventIconCDN(EActivity.SubType subType)
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool ClaimAllRewards(ref uint bpExp)
	{
		return false;
	}

	public void OpenCommonRewardWnd()
	{
	}

	private void ClearData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public bool CheckBigEventActivity(uint activityId, ref MatchResultTaskType matchResultTaskType)
	{
		return false;
	}

	public void StartMatch()
	{
	}

	public void PrepareBigEventTaskDic()
	{
	}

	private void AddFinishSameRowId(List<uint> finishId, List<ClientActivityDesc> taskList)
	{
	}

	public void Logout()
	{
	}

	private void _003COpenCommonRewardWnd_003Eb__34_0()
	{
	}
}
