using GCommon;
using proto;

namespace COW;

public class UISparkPetLuckDrawItemController : UIEasyListItemController
{
	private UISparkPetLuckDrawItemView m_View;

	private SparkGachaPoolRewardInfo m_Data;

	private BaseItemInfo m_ItemInfo;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	public bool IsReward(uint rewardID)
	{
		return false;
	}

	public void SetHighlight(bool active)
	{
	}

	public void RefreshObtained()
	{
	}

	private void OnClickBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
