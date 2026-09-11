using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISeasonReplaySocialSocialTabController : UIBaseController
{
	private UISeasonReplaySocialSocialTabView m_View;

	private ESeasonReplaySocialRelationTag m_RelationTag;

	private static Dictionary<uint, string> RelationTagKeyDic;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ESeasonReplaySocialRelationTag tag)
	{
	}

	public void OnTabClick()
	{
	}

	public void SetSelected()
	{
	}

	public void SetUnSelected()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
