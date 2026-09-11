using GCommon;
using UnityEngine;

namespace COW;

public class OpenTweenTipsEvent : GEvent
{
	public string message;

	public float duration;

	public ResourceID iconRes;

	public ResourceID effectRes;

	public string textureRes;

	public int customId;

	public bool useUpIcon;

	public string activitySys;

	public int depth;

	public int YOffset;

	public bool useNewEffect;

	public Vector2 uvInfo;

	public OpenTweenTipsEvent(string message, float duration, ResourceID iconRes, ResourceID effectRes, string textureRes, int customId = 0, bool useUpIcon = false, string actSys = "", int depth = 0, int yOffset = 0, bool useNewEffect = false, float uvx = 0f, float uvy = 0f)
	{
	}

	public OpenTweenTipsEvent(string message, ResourceID iconRes, string actSys = "", int depth = 0, float dduration = 4f)
	{
	}
}
