using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class HGEventTrigger : MonoBehaviour
{
	public int UID;

	public float EventDurationSec;

	public List<LevelRoom> TriggerRoomList;

	public HGEventDoor Door;

	public LevelBuffECATriggerObject BuffTrigger;

	public bool IsEventEndClearAllAI;

	public bool IsEventEndStopSpawnAI;

	public ANBNCADMNGL ActiveType;

	public string EventKey;

	public string EventIconResIDName;

	public GameObject EventActiveEffect;

	public string EventActiveSoundResIDName;

	public bool IsHideMarkPoint;

	public Transform MarkPoint;

	private bool GIKCHIHCGDD;

	private Dictionary<HGEventTriggerHelper, bool> AGBMLDENIJM;

	public bool FJAGPPFNHKB => false;

	private void Start()
	{
	}

	public void OnPlayerEnterTrigger(DBODPHFGNFJ BDGPANDIIJM, HGEventTriggerHelper BIPLCKECOBP)
	{
	}

	public void OnPlayerExitTrigger(DBODPHFGNFJ BDGPANDIIJM, HGEventTriggerHelper BIPLCKECOBP)
	{
	}

	public void PostActive()
	{
	}

	private void PEEGCNNJPNH(DBODPHFGNFJ DCAPIHJMMBL)
	{
	}

	public void NotifyGSTriggerAction()
	{
	}

	public void GSSyncClinetIsUsed()
	{
	}
}
