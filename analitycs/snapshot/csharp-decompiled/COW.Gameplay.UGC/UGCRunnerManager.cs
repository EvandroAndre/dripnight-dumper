using COW.GamePlay;
using message;

namespace COW.Gameplay.UGC;

public class UGCRunnerManager
{
	private IUGCRunner<JOEANMPIFAB> m_MapRunner;

	private IUGCRunner<FICHBIFMBOF> m_HudRunner;

	private IUGCRunner<CLMPMGMIDGD> _003CPhysicsRunner_003Ek__BackingField;

	private FFEAJEKGIIF _003CSceneBuilder_003Ek__BackingField;

	private bool _003CHasCreatedAllEntityFromData_003Ek__BackingField;

	private JOEANMPIFAB _003CRuntimeData_003Ek__BackingField;

	public IUGCRunner<CLMPMGMIDGD> PhysicsRunner
	{
		get
		{
			return _003CPhysicsRunner_003Ek__BackingField;
		}
		private set
		{
			_003CPhysicsRunner_003Ek__BackingField = value;
		}
	}

	public FFEAJEKGIIF SceneBuilder
	{
		get
		{
			return _003CSceneBuilder_003Ek__BackingField;
		}
		private set
		{
			_003CSceneBuilder_003Ek__BackingField = value;
		}
	}

	public bool HasCreatedAllEntityFromData
	{
		get
		{
			return _003CHasCreatedAllEntityFromData_003Ek__BackingField;
		}
		set
		{
			_003CHasCreatedAllEntityFromData_003Ek__BackingField = value;
		}
	}

	public JOEANMPIFAB RuntimeData
	{
		get
		{
			return _003CRuntimeData_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeData_003Ek__BackingField = value;
		}
	}

	public UGCRunnerManager(IUGCRunner<JOEANMPIFAB> mapRunner, IUGCRunner<FICHBIFMBOF> hudRunner, IUGCRunner<CLMPMGMIDGD> phyRunner)
	{
	}

	public bool LoadRunners(JOEANMPIFAB runtimeData)
	{
		return false;
	}

	public bool UnloadRunners()
	{
		return false;
	}
}
