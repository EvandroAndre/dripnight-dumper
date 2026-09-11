using GCommon;

namespace COW;

public class UIAchievementCommonController : UIBaseController
{
	private UIAchievementCommonView m_View;

	private AchievementProfileItemData m_Data;

	private uint m_AchievementId;

	private UIModelAchievement m_Model;

	private EAchievementBtnState m_State;

	public EAchievementBtnState State
	{
		get
		{
			return EAchievementBtnState.None;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(AchievementProfileItemData info)
	{
	}

	public void UnSelectItem()
	{
	}

	public UIButton GetButton()
	{
		return null;
	}

	private void OnButtonClick()
	{
	}

	private void OnButtonHit()
	{
	}

	private void OnTipClick()
	{
	}

	public void InitViewInProfileCustom()
	{
	}

	public void SetViewDataInProfileCustom(AchievementProfileItemData data, bool showButton)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
