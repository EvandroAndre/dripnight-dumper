using System.Collections.Generic;
using GCommon;

public class CacherNode
{
	public ResourceID m_Rid;

	public ResourceManager.LoadPriority m_Priority;

	public uint m_Ticket;

	public bool m_Preload;

	public int m_InstCount;

	public List<int> m_Referencer;

	public void Reset()
	{
	}

	public void AddReferencer(int insId)
	{
	}

	public void RemoveReferencer(int insId)
	{
	}

	public bool IsReferenced()
	{
		return false;
	}
}
