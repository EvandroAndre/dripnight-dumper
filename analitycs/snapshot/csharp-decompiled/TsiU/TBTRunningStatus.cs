namespace TsiU;

public class TBTRunningStatus
{
	public const int EXECUTING = 0;

	public const int FINISHED = 1;

	public const int TRANSITION = 2;

	public const int USER_EXECUTING = 100;

	public const int USER_FINISHED = 1000;

	public static bool IsOK(int runningStatus)
	{
		return false;
	}

	public static bool IsError(int runningStatus)
	{
		return false;
	}

	public static bool IsFinished(int runningStatus)
	{
		return false;
	}

	public static bool IsExecuting(int runningStatus)
	{
		return false;
	}
}
