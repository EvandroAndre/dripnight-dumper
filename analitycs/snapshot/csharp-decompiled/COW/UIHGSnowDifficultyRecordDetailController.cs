using GCommon;

namespace COW;

internal class UIHGSnowDifficultyRecordDetailController : UIBaseController
{
	private UIHGSnowDifficultyRecordDetailView m_View;

	private int m_DefaultBgHeight;

	private int m_DetalHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIModelHuntingGround.HuntingGroundMissionData data)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetHeight()
	{
		return 0;
	}

	private void OnBtnHideClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
