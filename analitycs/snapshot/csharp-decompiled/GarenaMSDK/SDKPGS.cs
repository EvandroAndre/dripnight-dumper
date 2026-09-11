using System;
using System.Collections.Generic;
using UnityEngine;

namespace GarenaMSDK;

public class SDKPGS
{
	public static class AchievementType
	{
		public const int Standard = 0;

		public const int Incremental = 1;

		public static string ToString(int type)
		{
			return null;
		}
	}

	public static class AchievementState
	{
		public const int Unlocked = 0;

		public const int Revealed = 1;

		public const int Hidden = 2;

		public static string ToString(int state)
		{
			return null;
		}
	}

	[Serializable]
	public class AchievementResult
	{
		public bool success;

		public string errorMessage;

		public string achievementId;

		public bool isUnlocked;
	}

	[Serializable]
	public class AchievementInfo
	{
		public string achievementId;

		public string name;

		public string description;

		public int type;

		public int state;

		public int currentSteps;

		public int totalSteps;

		public long xpValue;
	}

	[Serializable]
	public class LoadAchievementsResult
	{
		public bool success;

		public string errorMessage;

		public List<AchievementInfo> achievements;

		public bool isStale;
	}

	[Serializable]
	public class ShowAchievementsResult
	{
		public bool success;

		public string errorMessage;
	}

	public class Impl_Android : SDKPGS
	{
		public class ICallback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConShowAchievements_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass3_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConLoadAchievements_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConUnlockAchievementImmediate_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConIncrementAchievementImmediate_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConRevealAchievementImmediate_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass7_0
			{
				public ICallback _003C_003E4__this;

				public long id;

				public string resultJson;

				internal void _003ConSetAchievementStepsImmediate_003Eb__0()
				{
				}
			}

			private Impl_Android _Impl;

			public ICallback(Impl_Android impl)
				: base((string)null)
			{
			}

			public void onShowAchievements(long id, string resultJson)
			{
			}

			public void onLoadAchievements(long id, string resultJson)
			{
			}

			public void onUnlockAchievementImmediate(long id, string resultJson)
			{
			}

			public void onIncrementAchievementImmediate(long id, string resultJson)
			{
			}

			public void onRevealAchievementImmediate(long id, string resultJson)
			{
			}

			public void onSetAchievementStepsImmediate(long id, string resultJson)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnShowAchievements_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnLoadAchievements_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnUnlockAchievementImmediate_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnIncrementAchievementImmediate_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnRevealAchievementImmediate_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public string resultJson;

			public Impl_Android _003C_003E4__this;

			public long id;

			internal void _003COnSetAchievementStepsImmediate_003Eb__0()
			{
			}
		}

		private ICallback _Callback;

		private AndroidJavaObject _Java;

		private LongSeqPool<Action<ShowAchievementsResult>> _ShowAchievementsCallbacks;

		private LongSeqPool<Action<LoadAchievementsResult>> _LoadAchievementsCallbacks;

		private LongSeqPool<Action<AchievementResult>> _UnlockAchievementCallbacks;

		private LongSeqPool<Action<AchievementResult>> _IncrementAchievementCallbacks;

		private LongSeqPool<Action<AchievementResult>> _RevealAchievementCallbacks;

		private LongSeqPool<Action<AchievementResult>> _SetAchievementStepsCallbacks;

		public override bool SupportAchievements => false;

		public override void ShowAchievements(int requestCode, Action<ShowAchievementsResult> callback)
		{
		}

		public override void LoadAchievements(bool forceReload, Action<LoadAchievementsResult> callback)
		{
		}

		public override string UnlockAchievement(string achievementId)
		{
			return null;
		}

		public override void UnlockAchievementImmediate(string achievementId, Action<AchievementResult> callback)
		{
		}

		public override string IncrementAchievement(string achievementId, int numSteps)
		{
			return null;
		}

		public override void IncrementAchievementImmediate(string achievementId, int numSteps, Action<AchievementResult> callback)
		{
		}

		public override string RevealAchievement(string achievementId)
		{
			return null;
		}

		public override void RevealAchievementImmediate(string achievementId, Action<AchievementResult> callback)
		{
		}

		public override string SetAchievementSteps(string achievementId, int numSteps)
		{
			return null;
		}

		public override void SetAchievementStepsImmediate(string achievementId, int numSteps, Action<AchievementResult> callback)
		{
		}

		internal void OnShowAchievements(long id, string resultJson)
		{
		}

		internal void OnLoadAchievements(long id, string resultJson)
		{
		}

		internal void OnUnlockAchievementImmediate(long id, string resultJson)
		{
		}

		internal void OnIncrementAchievementImmediate(long id, string resultJson)
		{
		}

		internal void OnRevealAchievementImmediate(long id, string resultJson)
		{
		}

		internal void OnSetAchievementStepsImmediate(long id, string resultJson)
		{
		}

		public bool _003C_003EiFixBaseProxy_get_SupportAchievements()
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_ShowAchievements(int P0, Action<ShowAchievementsResult> P1)
		{
		}

		public void _003C_003EiFixBaseProxy_LoadAchievements(bool P0, Action<LoadAchievementsResult> P1)
		{
		}

		public string _003C_003EiFixBaseProxy_UnlockAchievement(string P0)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_UnlockAchievementImmediate(string P0, Action<AchievementResult> P1)
		{
		}

		public string _003C_003EiFixBaseProxy_IncrementAchievement(string P0, int P1)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_IncrementAchievementImmediate(string P0, int P1, Action<AchievementResult> P2)
		{
		}

		public string _003C_003EiFixBaseProxy_RevealAchievement(string P0)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_RevealAchievementImmediate(string P0, Action<AchievementResult> P1)
		{
		}

		public string _003C_003EiFixBaseProxy_SetAchievementSteps(string P0, int P1)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_SetAchievementStepsImmediate(string P0, int P1, Action<AchievementResult> P2)
		{
		}
	}

	private static SDKPGS _I;

	private static readonly string kNotSupported;

	public virtual bool SupportAchievements => false;

	public static SDKPGS I => null;

	protected SDKPGS()
	{
	}

	public virtual void ShowAchievements(int requestCode, Action<ShowAchievementsResult> callback)
	{
	}

	public virtual void LoadAchievements(bool forceReload, Action<LoadAchievementsResult> callback)
	{
	}

	public virtual string UnlockAchievement(string achievementId)
	{
		return null;
	}

	public virtual void UnlockAchievementImmediate(string achievementId, Action<AchievementResult> callback)
	{
	}

	public virtual string IncrementAchievement(string achievementId, int numSteps)
	{
		return null;
	}

	public virtual void IncrementAchievementImmediate(string achievementId, int numSteps, Action<AchievementResult> callback)
	{
	}

	public virtual string RevealAchievement(string achievementId)
	{
		return null;
	}

	public virtual void RevealAchievementImmediate(string achievementId, Action<AchievementResult> callback)
	{
	}

	public virtual string SetAchievementSteps(string achievementId, int numSteps)
	{
		return null;
	}

	public virtual void SetAchievementStepsImmediate(string achievementId, int numSteps, Action<AchievementResult> callback)
	{
	}
}
