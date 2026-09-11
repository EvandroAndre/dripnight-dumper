using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkShopCollaborationResourcesManager : SingletonModule<WorkShopCollaborationResourcesManager>
{
	private List<WorkShopCollaborationResources> mAllResource;

	private Dictionary<uint, List<WorkShopCollaborationResources>> mResDic;

	protected override void OnInit()
	{
	}

	public List<WorkShopCollaborationResources> GetCollaborationResourcesList()
	{
		return null;
	}

	public List<WorkShopCollaborationResources> GetCollaborationResourcesList(WorkShopCollaborationResources.ECollaborationResType resType)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
