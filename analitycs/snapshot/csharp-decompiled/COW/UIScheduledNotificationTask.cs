using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIScheduledNotificationTask
{
	public readonly uint UniqueID;

	public readonly Type ControllerType;

	public readonly Transform Parent;

	public readonly Vector3 LocalPosition;

	public readonly EUIAnchor Anchor;

	public readonly object ViewData;

	public readonly float DurationSecs;

	public UIScheduledNotificationTask(uint uniqueID, Type controllerType, object viewData, float durationSecs, Transform parent, Vector3 localPosition, EUIAnchor anchor)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
