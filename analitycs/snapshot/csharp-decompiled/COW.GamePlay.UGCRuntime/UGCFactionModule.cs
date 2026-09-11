using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCFactionModule : IUGCModule
{
	private UGCRuntime ugcRuntime;

	private Dictionary<string, string> m_Entity2Faction;

	public UGCFactionModule Create(UGCRuntime ugcRuntime)
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

	public string GetEntityFaction(string entityID)
	{
		return null;
	}

	private void OnReceiveUpdatingMsg(object[] data)
	{
	}
}
