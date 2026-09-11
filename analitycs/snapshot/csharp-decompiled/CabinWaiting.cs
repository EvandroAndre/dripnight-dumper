using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class CabinWaiting : MonoBehaviour
{
	private enum DoorLightType
	{
		Green,
		RedAlarm,
		Red
	}

	private sealed class _003CDoorOpen_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform door;

		public Vector3 startPos;

		public Vector3 endPos;

		public float totalTime;

		public bool needOpenDoorOverEffect;

		public CabinWaiting _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoorOpen_003Ed__28(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Transform leftDoor;

	public Transform rightDoor;

	public List<GameObject> lightList;

	public Transform cloudEffectParent;

	public Transform openDoorPos;

	public Transform effectParent;

	public GameObject doorLightGreen;

	public GameObject doorLightRed;

	public GameObject doorLightRedAlarm;

	public string StrTrainResID;

	public Vector3 CabinPostion;

	public Vector3 TargetFlyPostion;

	public Transform SuperEmotePosition1;

	public Transform SuperEmotePosition2;

	public bool IsSpecialCabin;

	private bool hasOpenDoor;

	private bool[] lightOpenFlag;

	private uint windEffectAsyncID;

	private EntityVisualEffectManager m_EntityVisualEffectManager;

	private ResourceID m_TrainResID;

	private uint trainAsyncID;

	private EntityVisualEffectManager GetVisualEffectManager()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetRemainTime(int secTime)
	{
	}

	public void PlayDoorAnim()
	{
	}

	private void LoadCloudEffect()
	{
	}

	private IEnumerator DoorOpen(Transform door, Vector3 startPos, Vector3 endPos, float totalTime, bool needOpenDoorOverEffect)
	{
		return null;
	}

	public void PlayLightAnim(int remainTimeIndex)
	{
	}

	private void SwitchDoorLight(DoorLightType t)
	{
	}

	private void LoadWindEffect()
	{
	}

	private void LoadTrain()
	{
	}

	private void OnTrainLoaded(uint uniqueid, ResourceID vfxresid, GameObject go)
	{
	}
}
