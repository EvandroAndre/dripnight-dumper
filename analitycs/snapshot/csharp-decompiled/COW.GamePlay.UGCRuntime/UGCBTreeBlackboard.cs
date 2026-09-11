using System.Collections.Generic;
using TsiU;

namespace COW.GamePlay.UGCRuntime;

public class UGCBTreeBlackboard : TBTWorkingData, IUGCBTreeBlackboard
{
	private readonly UGCRuntime m_UGCRuntime;

	private readonly Dictionary<string, UGCSimpleValue> m_Values;

	private string m_TreeAttachableEntityID;

	public UGCBTreeBlackboard(UGCRuntime runtime)
	{
	}

	public UGCRuntime GetUGCRuntime()
	{
		return null;
	}

	public void SetTreeAttachableEntityID(string entityID)
	{
	}

	public void SetValue(string key, object value)
	{
	}

	public IUGCValue GetValue(string key)
	{
		return null;
	}

	public string GetTreeAttachableEntityID()
	{
		return null;
	}
}
