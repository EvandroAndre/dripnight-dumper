using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine;

public class UpdateTracker
{
	public enum UpdateClock
	{
		Fixed,
		Late
	}

	private class UpdateStatus
	{
		private const int kWindowSize = 30;

		private int windowStart;

		private int numWindowLateUpdateMoves;

		private int numWindowFixedUpdateMoves;

		private int numWindows;

		private int lastFrameUpdated;

		private Matrix4x4 lastPos;

		private UpdateClock _003CPreferredUpdate_003Ek__BackingField;

		public UpdateClock PreferredUpdate
		{
			get
			{
				return _003CPreferredUpdate_003Ek__BackingField;
			}
			private set
			{
				_003CPreferredUpdate_003Ek__BackingField = value;
			}
		}

		public UpdateStatus(int currentFrame, Matrix4x4 pos)
		{
		}

		public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos)
		{
		}
	}

	private static Dictionary<Transform, UpdateStatus> mUpdateStatus;

	private static List<Transform> sToDelete;

	private static float mLastUpdateTime;

	private static void InitializeModule()
	{
	}

	private static void UpdateTargets(UpdateClock currentClock)
	{
	}

	public static UpdateClock GetPreferredUpdate(Transform target)
	{
		return UpdateClock.Fixed;
	}

	public static void OnUpdate(UpdateClock currentClock)
	{
	}
}
