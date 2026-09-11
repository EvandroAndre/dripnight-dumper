using GCommon;
using proto;

namespace COW;

public class UISparkPetLevelUpPreviewItemDoubleCellController : UIBaseController
{
	private UISparkPetLevelUpPreviewItemDoubleCellView m_View;

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

	private void OnFeatureIconClick()
	{
	}

	private void OnRewardIconClick()
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

	private void SetSparkGachaIcon()
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
