using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCPlayableModule : IUGCModule
{
	public const int C_PLAYABLE_FLAG_RESET = 0;

	public const int C_PLAYABLE_FLAG_PLAYED = 1;

	public const int C_PLAYABLE_FLAG_WAIT = 2;

	private UGCRuntime ugcRuntime;

	private UGCEntityDataStore entityModule;

	private int guid;

	private uint prevGameTime;

	private MFFBNJMPCEM m_playableSystem;

	private UGCCubicBezierV2 m_uGCCubicBezierV2;

	private UGCCubicBezier m_uGCCubicBezier;

	public MFFBNJMPCEM playableSystem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UGCCubicBezierV2 CubicBezierV2 => null;

	public UGCCubicBezier CubicBezier => null;

	public UGCPlayableModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void Destroy()
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public int allocateID()
	{
		return 0;
	}

	public UGCLogicEntity NewTweenV2(EntityIndex entityIndex, long propID, object src, object dst, float duration, int style, List<object> controlPoints)
	{
		return null;
	}

	public UGCLogicEntity NewTrajectory(UGCLogicEntity targetEntity, Vector3 initialVelocity, Vector3 acceleration, float maxDisplacement)
	{
		return null;
	}

	public UGCLogicEntity NewPosFollow(UGCLogicEntity selfEntity, UGCLogicEntity targetEntity, Vector3 offset, int coordinateType)
	{
		return null;
	}

	public UGCLogicEntity NewLookAt(UGCLogicEntity selfEntity, UGCLogicEntity targetEntity, Vector3 offset, int coordinateType)
	{
		return null;
	}

	public UGCLogicEntity NewSelfRelative(EntityIndex entityIndex, long propID, object delta, float duration, int style, List<object> controlPoints)
	{
		return null;
	}

	public UGCLogicEntity NewSelfRelativeFrame(EntityIndex entityIndex, long propID, object delta, bool isSwitch)
	{
		return null;
	}

	public UGCLogicEntity NewEffectEntity(string effectType, int loopType, bool autoPlay)
	{
		return null;
	}

	public UGCLogicEntity CloneSoundEntity(UGCLogicEntity entityToClone)
	{
		return null;
	}

	public void InitSoundEntityV2(string entityId, UGCLogicEntity entity)
	{
	}

	public UGCLogicEntity NewAlongPathMotion(UGCLogicEntity targetEntity, UGCLogicEntity path, int style, float speed, bool tangentFacing, bool autoPlay)
	{
		return null;
	}

	public void Play(string entityID, bool reset)
	{
	}

	public void Reset(string entityID)
	{
	}

	public void Pause(string entityID)
	{
	}

	public void Delete(UGCLogicEntity entity)
	{
	}
}
