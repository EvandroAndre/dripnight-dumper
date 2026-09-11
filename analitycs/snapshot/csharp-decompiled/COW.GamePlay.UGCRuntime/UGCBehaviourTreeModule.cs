using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCBehaviourTreeModule : IUGCBehaviourTreeModule, IUGCModule
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string treeID;

		internal bool _003CGetUGCTreeData_003Eb__0(HKPGKEJHINO x)
		{
			return false;
		}
	}

	private UGCRuntime m_UGCRuntime;

	private Dictionary<string, IUGCBTree> m_TreeMap;

	public IUGCModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public void AddBTree(string entityID, IUGCBTree tree)
	{
	}

	public void DestroyBTreeFromAttachable(UGCLogicEntity entity)
	{
	}

	public void DestroyBTree(string treeEntityID)
	{
	}

	public IUGCBTree CreateBTreeByID(string treeID, string targetEntityID)
	{
		return null;
	}

	private void OnTickEventHandle()
	{
	}

	private HKPGKEJHINO GetUGCTreeData(string treeID)
	{
		return null;
	}
}
