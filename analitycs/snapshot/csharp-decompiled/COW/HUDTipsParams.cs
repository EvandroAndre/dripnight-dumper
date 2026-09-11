using GCommon;

namespace COW;

public class HUDTipsParams : GEvent
{
	private ResourceID m_IconResID;

	private string m_ShowString;

	private float m_ShowDuration;

	private int m_Depth;

	private bool m_UseDepth;

	public ResourceID IconResID => default(ResourceID);

	public string ShowString => null;

	public float ShowDuration => 0f;

	public int Depth => 0;

	public bool UseDepth => false;

	public GEvent Reset(string showString, string iconName = "", float showDuration = 2f, int depth = 50, bool useDepth = false)
	{
		return null;
	}

	public GEvent Reset(string showString, ResourceID iconResID, float showDuration = 2f, int depth = 50, bool useDepth = false)
	{
		return null;
	}
}
