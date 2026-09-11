using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudStackedFeedbackNotificationController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIHudStackedFeedbackNotificationController _003C_003E4__this;

		public int index;

		internal void _003COnSkipFeedback_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public int index;

		public UIHudStackedFeedbackNotificationController _003C_003E4__this;

		internal void _003CShowNotifyIcon_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_1
	{
		public int index;

		public UIHudStackedFeedbackNotificationController _003C_003E4__this;

		internal void _003CShowNotifyIcon_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_2
	{
		public int index;

		public UIHudStackedFeedbackNotificationController _003C_003E4__this;

		internal void _003CShowNotifyIcon_003Eb__2()
		{
		}
	}

	private sealed class _003CPlayKillNotificationDelay_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudStackedFeedbackNotificationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayKillNotificationDelay_003Ed__38(int _003C_003E1__state)
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

	private UIHudStackedFeedbackNotificationView m_View;

	protected uint m_DelayCallID;

	private const string m_OutAnima = "UIHudStackedFeedbackNotification_Out";

	private float KnockDownDelayTime;

	private float NextWaitDelay;

	private float StopOrReplacePlayingDelay;

	private float ReplacePlayingDelay;

	private float LastOneDelay;

	private List<Queue<NotificationData>> m_QueueList;

	private Dictionary<ulong, List<RecyleFeedbackItem>> m_NotificationItemDic;

	private RecyleAnimationRoot[] m_NodeAnimations;

	private int LastIndex;

	private bool playing;

	private int m_WeakCount;

	private int m_FeedbackCount;

	private NotificationType m_LastPlayingNotifyType;

	private byte m_LastPriority;

	private float m_LastPlayingNotifyTime;

	private float m_lastKnockDownTime;

	private uint m_KnockDownDelayWait;

	private HashSet<int> m_SkipSet;

	private HashSet<int> m_UnCombineSet;

	private const float TweenDurExt = 0.1f;

	private GameObject m_SoundKillGo;

	private Queue<HMMKICLHEBL> m_PendingHighlightMsgs;

	private uint m_HighlightPhotoDelayID;

	protected IEnumerator m_KillEnr;

	protected Queue<NotificationData> m_KillParams;

	protected override void OnUIInit()
	{
	}

	private void DoCache()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	private void ClearQueue()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnSkipFeedback(int open, int value)
	{
	}

	private bool IsReplayStateJumping()
	{
		return false;
	}

	private void OnShowNotify(GEvent edata)
	{
	}

	private void AddToQueue(NotificationData data)
	{
	}

	private IEnumerator PlayKillNotificationDelay()
	{
		return null;
	}

	private void DoQueueLogic(NotificationData data)
	{
	}

	private bool CanReplace(bool isKnockDown, float nowTime)
	{
		return false;
	}

	private bool ReplacePlayingNotify(NotificationData data)
	{
		return false;
	}

	private bool NeedWaitKnockDownDelay(float nowTime, bool curKnockDown)
	{
		return false;
	}

	private void Stop2PlayImmediately(NotificationData data)
	{
	}

	private void WaitForKnockDown(NotificationData data, float delay)
	{
	}

	private void ClearKnockDownDelay()
	{
	}

	private void OnTakeHighlightPhoto(object[] param)
	{
	}

	private void ClearHighlightPhotoDelay()
	{
	}

	private void TryTakeHighlightPhotoAfterDisplay()
	{
	}

	private void ExecuteHighlightPhoto()
	{
	}

	private void PlayKnockdownAfter()
	{
	}

	private bool ReplaceQueueData(NotificationData data)
	{
		return false;
	}

	private void PlayNotifyShow(NotificationData data)
	{
	}

	private void TryStartOrNext(NotificationData data)
	{
	}

	private void TryStart(bool hasBefore)
	{
	}

	private bool HasNext()
	{
		return false;
	}

	private bool HasRealNext()
	{
		return false;
	}

	private NotificationData GetFirst()
	{
		return null;
	}

	private ulong GetSkinType(NotificationType nType, uint skinid)
	{
		return 0uL;
	}

	private void ShowNotifyIcon(NotificationData data, bool hasBeforePlay)
	{
	}

	private void OnAnimationEnd(int index)
	{
	}

	private void ResetAnimationData(RecyleAnimationRoot aniData)
	{
	}

	private RecyleFeedbackItem ShowIconWithType(ulong iconType, Type uiType, NotificationData data, Transform parent)
	{
		return null;
	}

	private void WaitNext()
	{
	}

	private RecyleAnimationRoot GetUseAnimation()
	{
		return null;
	}

	private void OnPlayKillAudio(object[] data)
	{
	}

	private void PlayKillAudio(int killStack, uint scannerMarkAddCoin, BHGGAEEHJCO victimPlayerID)
	{
	}

	private ResourceID GetKillAudioResID(int killStack, uint scannerMarkAddCoin, BHGGAEEHJCO victimPlayerID)
	{
		return default(ResourceID);
	}

	private void PlaySoundKillAudio()
	{
	}

	public void DebugLog(object message)
	{
	}

	private void _003CTryTakeHighlightPhotoAfterDisplay_003Eb__48_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
