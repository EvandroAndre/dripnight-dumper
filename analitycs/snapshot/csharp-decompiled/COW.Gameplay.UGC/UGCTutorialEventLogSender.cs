namespace COW.Gameplay.UGC;

public static class UGCTutorialEventLogSender
{
	public const uint TASK_STATUS_ACCEPT = 1u;

	public const uint TASK_STATUS_COMPLETE = 2u;

	public const uint TASK_STATUS_EXIT = 3u;

	public static void Send(string levelId, string taskId, uint taskStatus, uint durationSeconds)
	{
	}

	private static UIModelSceneEdit.EUGCTutorialEntrySource ResolveEntrySource()
	{
		return UIModelSceneEdit.EUGCTutorialEntrySource.None;
	}
}
