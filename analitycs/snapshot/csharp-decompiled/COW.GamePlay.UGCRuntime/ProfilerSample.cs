namespace COW.GamePlay.UGCRuntime;

public class ProfilerSample
{
	public string name;

	public int parentIndex;

	public int depth;

	public int callCount;

	public long totalTicks;

	public long totalMemoryDelta;

	public string codeID;

	public float TotalMs => 0f;

	public float AvgMs => 0f;

	public void Reset(string sampleName, int parent, int sampleDepth, string codeID)
	{
	}
}
