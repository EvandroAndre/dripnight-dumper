namespace COW;

public class RecordResCheckInfo
{
	private readonly string[] m_WorkshopCodes;

	private ulong m_StartTime;

	private uint m_CheckTime;

	public RecordResCheckInfo(string[] workshopCodes)
	{
	}

	public bool IsSame(string[] workshopCodes)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void StartCheck()
	{
	}

	public void EndCheck()
	{
	}

	public void Submit()
	{
	}
}
