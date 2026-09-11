using System;

namespace COW;

public class TaskDragDrop : BaseTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TaskDragDropContainer, bool> _003C_003E9__4_0;

		internal bool _003CCheckComplete_003Eb__4_0(TaskDragDropContainer container)
		{
			return false;
		}
	}

	public TaskDragDropContainer[] dragDropContainers;

	private bool m_IsComplete;

	private void Awake()
	{
	}

	public override void OnStart()
	{
	}

	private void CheckComplete()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
