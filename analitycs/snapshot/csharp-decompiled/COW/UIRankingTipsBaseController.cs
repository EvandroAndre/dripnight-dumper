using GCommon;
using UnityEngine;

namespace COW;

public class UIRankingTipsBaseController : UIBaseController
{
	private UIStandardItemMiniController m_RewardCtrl;

	private UIModelLadderMatch m_UIModelLadderMatch;

	private UIModelCSLadderMatch m_UIModelCSLadderMatch;

	public UIModelRankingTips m_UIModelRankingTips;

	private uint m_IntervalTime;

	private uint m_DurationTime;

	public uint m_IntervalTimeDelayCallId;

	public uint m_DurationTimeDelayCallId;

	public bool m_IsShow;

	public RankingTipsLobby TipsData;

	private bool m_CurrentShowGameMode;

	private bool m_IsCanAddFrequency;

	public GameObject CountDownContainer;

	public GameObject OneLineContainer;

	public GameObject TwoLineContainer;

	public GameObject TwoLineWithAwardContainer;

	public GameObject SeasonCountDownContainer;

	public UILabel LabelUp;

	public UILabel LabelDown;

	public UILabel LabelDownFriend;

	public UILabel OneLineLabel;

	public UILabel TargetLabel;

	public UICountDownLabel SeasonCountDownLabel;

	public UICountDownLabel CountDownLabel;

	public Transform AwardItemTransForm;

	public UISprite LeftKellySprite;

	public UISprite RightKellySprite;

	public GameObject MainGameObject;

	public UILabel RankTitle;

	public UISprite CountDownIcon;

	public GameObject CountDownBG;

	public UILabel CountDownBaseLabel;

	public GameObject LeftKellyGameObject;

	public GameObject RightKellyGameObject;

	public UISprite TwoLineBg;

	public UILabel TwoLineRankTitle;

	public GameObject TwoLineMissionUpdatedContainer;

	public UILabel LabelDownMissionUpdated;

	public UILabel LabelUpMissionUpdated;

	public UITable TwoLineTable;

	public UIButton TwoLineGoToBtn;

	public GameObject TwoLineGoToBtnContainer;

	public GameObject ActivityNoticeContainer;

	public Animation ActivityNoticeAnim;

	public UILabel ActivityNoticeLabel;

	public UISprite TwoLineWithAwardBG;

	private const uint BLACK_COLOR = 437918463u;

	private const uint WITHE_COLOR = uint.MaxValue;

	private const int LABEL_MARGIN = 40;

	private const int GOTO_BTN_HEIGHT = 34;

	protected Vector3 m_MainGameObjectLocalPosition;

	protected override void OnUIInit()
	{
	}

	public void TriggerForceDisplayActivityTipsDebug()
	{
	}

	protected virtual void OnForceDisplayActivityTipsDebug()
	{
	}

	private void HideStateAndClearForceDisplayDebug()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetUIData()
	{
	}

	private void ChangeLabelSymBol(UILabel label, string SpriteName)
	{
	}

	private void ChangeLabelSymBolByResource(UILabel label, ResourceID resId)
	{
	}

	private void CreatRewardItem(BaseItemInfo item)
	{
	}

	private void SetupActivityTaskUI()
	{
	}

	private void AdjustTwoLineWithAwardBG()
	{
	}

	private void RefreshTime(uint type)
	{
	}

	private void BGFit(bool isRank = true)
	{
	}

	private void OnTwoLineGotoBtnClick()
	{
	}

	private void ShowStateAndSetDelayCall()
	{
	}

	private void HideStateAndSetDelayCall()
	{
	}

	public void HideAndResetDisplayState(bool preserveIntervalDelayCall = false)
	{
	}

	protected virtual void RequestRestoreGameAssistantBubble()
	{
	}

	public void RefreshDelayCal()
	{
	}

	protected virtual void PlayMainAnimation()
	{
	}

	protected virtual void SkipActivityNoticeAnimation()
	{
	}

	public void OnMainGameobjectHidden()
	{
	}

	public void CheckNeedAddFrequency()
	{
	}

	private void SetLog(bool isBr, uint TipsId)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSelectGameMode(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
