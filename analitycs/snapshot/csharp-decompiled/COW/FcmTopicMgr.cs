using System.Collections.Generic;

namespace COW;

internal class FcmTopicMgr
{
	public class FCMTask
	{
		public enum TaskType
		{
			ForceUpdateToken,
			DeleteToken,
			GetToken,
			SubscribeTopic,
			UnsubscribeTopic,
			Wait
		}

		private TaskType _003CType_003Ek__BackingField;

		public TaskType Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			protected set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		public virtual string IdentifySelf()
		{
			return null;
		}

		public static bool IsEqual(FCMTask a, FCMTask b)
		{
			return false;
		}
	}

	public class TopicTask : FCMTask
	{
		private string _003CTopicKey_003Ek__BackingField;

		private string _003CTopicValue_003Ek__BackingField;

		public string TopicKey
		{
			get
			{
				return _003CTopicKey_003Ek__BackingField;
			}
			private set
			{
				_003CTopicKey_003Ek__BackingField = value;
			}
		}

		public string TopicValue
		{
			get
			{
				return _003CTopicValue_003Ek__BackingField;
			}
			private set
			{
				_003CTopicValue_003Ek__BackingField = value;
			}
		}

		private TopicTask()
		{
		}

		public static TopicTask SubscribeTopic(string topicKey, string topicValue)
		{
			return null;
		}

		public static TopicTask UnsubscribeTopic(string topicKey, string topicValue)
		{
			return null;
		}

		public override string IdentifySelf()
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_IdentifySelf()
		{
			return null;
		}
	}

	public class WaitTask : FCMTask
	{
		private ulong _003CSince_003Ek__BackingField;

		private float _003CSeconds_003Ek__BackingField;

		private FCMTask _003CPending_003Ek__BackingField;

		public ulong Since
		{
			get
			{
				return _003CSince_003Ek__BackingField;
			}
			private set
			{
				_003CSince_003Ek__BackingField = value;
			}
		}

		public float Seconds
		{
			get
			{
				return _003CSeconds_003Ek__BackingField;
			}
			private set
			{
				_003CSeconds_003Ek__BackingField = value;
			}
		}

		public FCMTask Pending
		{
			get
			{
				return _003CPending_003Ek__BackingField;
			}
			private set
			{
				_003CPending_003Ek__BackingField = value;
			}
		}

		private WaitTask()
		{
		}

		public override string IdentifySelf()
		{
			return null;
		}

		public static WaitTask Wait(ulong since, float seconds, FCMTask pending = null)
		{
			return null;
		}

		public string _003C_003EiFixBaseProxy_IdentifySelf()
		{
			return null;
		}
	}

	private static FcmTopicMgr _I;

	private FCMTask _PendingTask;

	private LinkedList<FCMTask> _QueuedTasks;

	private bool _isTaskQueueBlocked;

	private const string PLAYER_PREFS_KEY_FCM_TOPIC_UPDATE_RETRY_INTERVAL = "RNM_FCM_TOPIC_UPDATE_RETRY_INTERVAL";

	private const string PLAYER_PREFS_KEY_FCM_TOPIC_UPDATE_FAILED_AT = "RNM_FCM_TOPIC_UPDATE_FAILED_AT";

	private uint _TopicUpdateRetryDelayCallID;

	private uint _TopicTaskTimeoutDelayCallID;

	private const string ERROR_TOPIC_TIMEOUT = "TIMEOUT";

	public static FcmTopicMgr I => null;

	public FCMTask PendingTask => null;

	public int TopicUpdateRetryInterval
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public ulong TopicUpdateFailedAt
	{
		get
		{
			return 0uL;
		}
		private set
		{
		}
	}

	public bool TopicTaskTimeout => false;

	private FcmTopicMgr()
	{
	}

	private void ShowDebugTips(string tips)
	{
	}

	public void BlockTaskQueue(bool blocked)
	{
	}

	private void TopicUpdateRetryInterval_Double()
	{
	}

	private void TopicUpdateRetryInterval_Half()
	{
	}

	private void TopicUpdateRetryInterval_Reset()
	{
	}

	private void CancelTopicUpdateRetry()
	{
	}

	private void TopicUpdateRetry()
	{
	}

	private void RetryOrContinue()
	{
	}

	public void QueueSubscribeTopicsFirst(Dictionary<string, string> topics)
	{
	}

	public void SubscribeTopic(string topicKey, string topicValue)
	{
	}

	private void _OnSubscribedTopic(TopicTask topicTask, string topic, bool isOK, string error)
	{
	}

	public void UnsubscribeTopic(string topicKey, string topicValue)
	{
	}

	private void _OnUnsubscribedTopic(TopicTask topicTask, string topic, bool isOK, string error)
	{
	}

	public void TriggerTaskQueue()
	{
	}

	public void ExpectTokenChange()
	{
	}

	private void _ProcessTaskQueue(bool canWait = true)
	{
	}

	private void _ProcessTask(FCMTask task)
	{
	}

	private void PerhapsSetupTopicTaskTimeout()
	{
	}

	private void PerhapsCancelTopicTaskTimeout()
	{
	}

	private void ClearPendingTopicTask()
	{
	}

	private void _TopicTaskTimeout()
	{
	}
}
