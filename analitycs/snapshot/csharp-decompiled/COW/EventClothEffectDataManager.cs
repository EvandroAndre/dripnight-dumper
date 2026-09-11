using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class EventClothEffectDataManager : SingletonModule<EventClothEffectDataManager>
{
	public enum EBehaviorClientType
	{
		None = 0,
		SafeZone = 9,
		KillShowOnTarget = 18,
		KnockDownShowOnTarget = 19
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public List<EventClothEffectsData> list;

		public int i;

		public Predicate<EventClothEffectsData> _003C_003E9__0;

		internal bool _003CremoveDuplicationEffectsTriggerID_003Eb__0(EventClothEffectsData o)
		{
			return false;
		}
	}

	private Dictionary<uint, EventClothEffectsData> m_DictStateIdToData;

	private Dictionary<uint, LinkedList<EventClothEffectsData>> m_DictClothesIdToData;

	private Dictionary<uint, EventTriggerData> m_DictEventEffectTrigger;

	private Dictionary<uint, List<uint>> m_StateIdListDict;

	protected override void OnInit()
	{
	}

	public void LoadCSVData()
	{
	}

	public bool CheckClothHasEvent(uint id)
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}

	public bool IsClientClothEffects(EBehaviorClientType behaviorType, uint stateId)
	{
		return false;
	}

	public void GetEventClothEffectsDataByClothes(uint clothesId, List<EventClothEffectsData> list, bool partialClone = false)
	{
	}

	public LinkedList<EventClothEffectsData> GetEventClothEffectsDataListById(uint clothId)
	{
		return null;
	}

	public List<EventClothEffectsData> removeDuplicationEffectsTriggerID(List<EventClothEffectsData> list)
	{
		return null;
	}

	public EventTriggerData FindEventTriggerDataById(uint eventId)
	{
		return null;
	}

	public EventClothEffectsData FindEventEffectsDataByStateId(uint stateID)
	{
		return null;
	}
}
