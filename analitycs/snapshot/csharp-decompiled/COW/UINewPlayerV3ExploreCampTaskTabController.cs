using GCommon;

namespace COW;

public class UINewPlayerV3ExploreCampTaskTabController : UIBaseController
{
	private const string TAB_NAME = "T_49_MF_EXPLORE_SESSION";

	private const string TAB_UNLOCK_TIP = "T_49_MF_EXPLORE_TIPS";

	private UINewPlayerV3ExploreCampTaskTabView m_View;

	private uint m_SectionID;

	private int m_TabIndex;

	private bool m_IsTabUnlock;

	public uint SectionID => 0u;

	public int TabIndex
	{
		get
		{
			return 0;
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

	protected override void OnUIDestory()
	{
	}

	public void OnTabClick()
	{
	}

	public void OnTabSelect()
	{
	}

	public void OnTabUnselect()
	{
	}

	public void InitTabView(uint sectionID)
	{
	}

	public void RefreshTabView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
