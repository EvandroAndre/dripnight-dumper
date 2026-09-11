using GCommon;
using proto;

namespace COW;

public class UISparkPetLevelUpPreviewItemSingleCellController : UIBaseController
{
	private UISparkPetLevelUpPreviewItemSingleCellView m_View;

	private SparkLevelAwardDesc m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(SparkLevelAwardDesc levelAwardDesc)
	{
	}

	private void OnRewardIconClick()
	{
	}

	private void OnFeatureIconClick()
	{
	}

	private bool IsSparkGachaPoolFeatureUnlock(SparkLevelAwardDesc levelAwardDesc)
	{
		return false;
	}

	private bool IsSparkGachaDrawAward(AwardDesc awardDesc)
	{
		return false;
	}

	private void UpdateSparkGachaDrawAwardClaimState(SparkLevelAwardDesc levelAwardDesc, AwardDesc awardDesc)
	{
	}

	private void OpenSparkGachaPoolPopup()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
