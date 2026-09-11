using message;

namespace GCommon;

public abstract class ReplicationEntity : Entity
{
	protected bool m_IsPRIRecivedFirstTime;

	protected IPRIDataPool m_PRIDataPool;

	private DPMPLDDOLDI _003CReplicationEntityTag_003Ek__BackingField;

	public DPMPLDDOLDI ReplicationEntityTag
	{
		get
		{
			return _003CReplicationEntityTag_003Ek__BackingField;
		}
		set
		{
			_003CReplicationEntityTag_003Ek__BackingField = value;
		}
	}

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	public override void OnRecycleClearData()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public void OnReplicationBind(uint replicationID)
	{
	}

	public void OnSyncReplicationMsg(DHIEKICKHPN entityMsg)
	{
	}

	public void OnSyncReplicationData(FastBinaryReader reader)
	{
	}

	public uint GetReplicationID()
	{
		return 0u;
	}

	private void InvokeInitialCallback()
	{
	}

	private void ClearReplicationPool()
	{
	}

	protected virtual void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void OnPRIInitialized()
	{
	}

	protected abstract int GetMaxRepDataCount();

	protected abstract bool IsLocalEntity();

	protected abstract void RegisterEntity();

	protected abstract void UnRegisterEntity();
}
