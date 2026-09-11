using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCHostilityModule : IUGCModule
{
	private UGCRuntime ugcRuntime;

	private Dictionary<string, Dictionary<string, bool>> m_Entity2AttackableEntity;

	private Dictionary<string, Dictionary<string, bool>> m_Faction2AttackableFaction;

	private Dictionary<string, Dictionary<string, bool>> m_Team2AttackableTeam;

	private static float cacheGameTime;

	public UGCHostilityModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	private bool internalCalcHostile(Player attacker, Player attackee, out bool hostile)
	{
		hostile = default(bool);
		return false;
	}

	internal bool CalcFightingEntityHostile(Player attacker, OKEAMEELLBB attackee, out bool hostile)
	{
		hostile = default(bool);
		return false;
	}

	internal bool internalCalcFightingEntityHostile(Player attacker, OKEAMEELLBB attackee, out bool hostile)
	{
		hostile = default(bool);
		return false;
	}

	internal bool CalcHostile(Player attacker, Player attackee, out bool hostile)
	{
		hostile = default(bool);
		return false;
	}

	internal string GetEntityFaction(OKEAMEELLBB entity)
	{
		return null;
	}

	internal string GetPlayerFaction(Player player)
	{
		return null;
	}

	internal string GetPlayerTeam(Player player)
	{
		return null;
	}

	internal string GetEntityTeam(OKEAMEELLBB entity)
	{
		return null;
	}

	internal string GetEntityID(OKEAMEELLBB entity)
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

	private void OnReceiveUpdatingMsg(object[] data)
	{
	}

	private void UpdateHostility(PCDJHCNAENI data)
	{
	}

	private void SetHostility(List<CDNJFNCFFLG> relationShipSetPairs, Dictionary<string, Dictionary<string, bool>> target)
	{
	}

	private void DelHostility(List<MFBGOPBPJNA> relationShipDeltPairs, Dictionary<string, Dictionary<string, bool>> target)
	{
	}

	public List<object> GetActualFriendlyTeams(string teamEntityID)
	{
		return null;
	}

	public List<object> GetActualHostileTeams(string teamEntityID)
	{
		return null;
	}
}
