using GCommon;
using UnityEngine;

namespace COW;

public class UILaunchTagIntroduceItemController : UIBaseController
{
	public enum EIntroduceIndex
	{
		HowTo,
		Profile,
		Team,
		Leaderboard,
		UPLIMIT
	}

	private UILaunchTagIntroduceItemView m_View;

	private EIntroduceIndex m_Index;

	private static readonly Color Color_Select;

	private static readonly Color Color_UnSelect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetViewData(EIntroduceIndex privilegeIndex)
	{
	}

	public void RefreshLabelColor(EIntroduceIndex curSelect)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
