using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINinthSYSPeakDayWndController : UIBigEventPeakDayWndBaseController
{
	private UIModelBigEvent m_ModelBigEvent;

	private UIModelNinthSYS m_ModelNinthSYS;

	private UINinthSYSPeakDayWndView m_PeakDayWndView;

	private BaseItemInfo m_BigPrizeItemInfo;

	private BaseItemInfo m_BigPrizeItemInfo2;

	private readonly Vector2 ITEM_SIZE;

	private int m_CheckInIndex;

	private float m_ProgressWidth;

	private float m_BigRewardWidgetWidth;

	private int m_CheckDays;

	private int m_CurBigRewardIndex;

	private int m_NextBigRewardIndex;

	private readonly float space;

	private float m_CurRightPosX;

	private float m_CurLeftPosX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickRuleBtn()
	{
	}

	private void OnClickClaimBtn()
	{
	}

	private void OnClickBigPrizeLookBtn()
	{
	}

	private void OnClickBigPrizeLookBtn2()
	{
	}

	private void OnClickNextBigRewardBtn()
	{
	}

	private void OnClickBigRewardBtn()
	{
	}

	private void Update()
	{
	}

	private void RefreshBigReward(bool force = false)
	{
	}

	private void ShowBigPrizeCdn(int index)
	{
	}

	private void InitTable2Template()
	{
	}

	private void InitView()
	{
	}

	private AwardDesc GetAwardDesc(int index)
	{
		return null;
	}

	private void RefershView()
	{
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__33_0()
	{
		return null;
	}

	private void _003CInitView_003Eb__34_0()
	{
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
