using UnityEngine;

namespace UMA;

public abstract class UMAGeneratorBase : MonoBehaviour
{
	public class AnimatorState
	{
		private int[] stateHashes;

		private float[] stateTimes;

		private AnimatorControllerParameter[] parameters;

		public void SaveAnimatorState(Animator animator)
		{
		}

		public void RestoreAnimatorState(Animator animator)
		{
		}
	}

	public bool fitAtlas;

	public TextureMerge textureMerge;

	public bool convertRenderTexture;

	public bool convertMipMaps;

	public int atlasResolution;

	protected static UMAGeneratorBase Instance;

	public abstract void addDirtyUMA(UMAData umaToAdd);

	public abstract bool IsIdle();

	public abstract int QueueSize();

	public abstract void Work();

	public abstract void WorkSync(UMAData umadata);

	public abstract void RemoveData(UMAData umadata);

	public static UMAGeneratorBase GetInstanceNoFind()
	{
		return null;
	}

	public static UMAGeneratorBase FindInstance()
	{
		return null;
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void UpdateAvatar(UMAData umaData)
	{
	}

	public static void SetAvatar(UMAData umaData, Animator animator)
	{
	}

	public static Avatar CreateAvatar(UMAData umaData, UmaTPose umaTPose)
	{
		return null;
	}

	public static Avatar CreateGenericAvatar(UMAData umaData)
	{
		return null;
	}

	public static HumanDescription CreateHumanDescription(UMAData umaData, UmaTPose umaTPose)
	{
		return default(HumanDescription);
	}
}
