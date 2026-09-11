using GCommon;

namespace COW;

public class UIHudRankingTipsBubbleController : UIBaseController
{
	private UIHudRankingTipsBubbleView m_View;

	private UIModelRankingTips m_ModelRankingTips;

	private uint DelayCallId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(bool isBr)
	{
	}

	private void SetupActivityTaskUI()
	{
	}

	private void CreateActivityAwardItem(uint awardId, uint awardNum)
	{
	}

	public void SetLog(uint gameMode, uint rank, uint reason)
	{
	}

	public void CreateDelayCall()
	{
	}

	private void ChangeLabelSymBol(UILabel label, string SpriteName)
	{
	}

	private void ChangeLabelSymBolByResource(UILabel label, ResourceID resId)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
