using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINotificationQueueScheduler
{
	private float m_NextNotificationTime;

	private IScheduledNotification m_CurrentNotification;

	private readonly UniqueIDGenerator m_IDGenerator;

	private readonly List<UIScheduledNotificationTask> m_PendingTasks;

	private readonly LinkedList<UIBaseController> m_CachedNotificationCtrls;

	private UIBaseController AllocNotification(UIScheduledNotificationTask task)
	{
		return null;
	}

	private void CollectNotification(UIBaseController controller)
	{
	}

	private void FinishCurrentNotification(bool interrupted)
	{
	}

	private void StartNextNotification(UIScheduledNotificationTask task)
	{
	}

	public void Tick(float gameTime, float deltaTime)
	{
	}

	public void PlayQueued<T>(object viewData, float durationSecs, Transform parent = null, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.Center) where T : UIBaseController, IScheduledNotification
	{
	}

	public void PlayCut<T>(object viewData, float durationSecs, Transform parent = null, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.Center) where T : UIBaseController, IScheduledNotification
	{
	}

	public void Clear()
	{
	}

	public void CleanCache()
	{
	}
}
