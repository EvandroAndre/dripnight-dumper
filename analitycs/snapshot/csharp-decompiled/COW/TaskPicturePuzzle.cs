using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TaskPicturePuzzle : BaseTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TaskDragDropContainer, bool> _003C_003E9__6_0;

		internal bool _003CCheckComplete_003Eb__6_0(TaskDragDropContainer container)
		{
			return false;
		}
	}

	public int SelectFragmentCount;

	public List<TaskItemPicPuzzle> PicPuzzleList;

	public List<Transform> FragmentShowRoot;

	private List<TaskDragDropContainer> dragDropContainers;

	private bool m_IsComplete;

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
