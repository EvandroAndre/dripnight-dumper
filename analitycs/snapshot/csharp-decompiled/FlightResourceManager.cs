using System.Collections.Generic;
using COW;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public static class FlightResourceManager
{
	private static Dictionary<ResourceID, Object> flightResourceObj;

	private static Dictionary<ResourceID, uint> flightResourceRef;

	private static Dictionary<ResourceID, bool> flightResourceReleaseIntent;

	private static Dictionary<ResourceID, HashSet<ResourceID>> flightAudioPerModel;

	private static Dictionary<ResourceID, uint> flightAudioResourceRef;

	private static Dictionary<ResourceID, bool> flightAudioReleaseIntent;

	private static Dictionary<ResourceID, HashSet<ResourceID>> flightPlayerAnimControllersPerModel;

	private static Dictionary<ResourceID, uint> flightPlayerAnimControllerRef;

	private static Dictionary<ResourceID, bool> flightPlayerAnimControllerReleaseIntent;

	private static List<KeyValuePair<AnimationClip, AnimationClip>> flightPlayerAnimOverridePairs;

	private static HashSet<AnimationClip> flightPlayerAnimOverrideClipSet;

	private static int[] m_texturIDPropertys;

	private static bool IsLowMemOr32bit()
	{
		return false;
	}

	private static bool IsIOS4GMem()
	{
		return false;
	}

	public static bool IsReleaseFlightResOpen()
	{
		return false;
	}

	public static bool NeedReleaseFlightRes(bool islocal, bool isteammate)
	{
		return false;
	}

	public static void AddRef(ResourceID id, Object obj)
	{
	}

	public static void AttachResID(ResourceID id)
	{
	}

	public static void AttachGameObj(ResourceID id, Object obj)
	{
	}

	public static void AttachFlightExtraRes(ResourceID modelId, FlightData flightData)
	{
	}

	private static void AttachFlightPlayerAnimControllers(ResourceID modelId, IIHNJINGAID formation)
	{
	}

	private static void AttachFlightPlayerAnimController(ResourceID modelId, ResourceID controllerId)
	{
	}

	private static void ReleaseFlightPlayerAnimControllers(ResourceID modelId, bool needRelease)
	{
	}

	private static void ReleaseFlightPlayerAnimClips(ResourceID controllerId)
	{
	}

	private static void AddAudioRef(HashSet<ResourceID> modelSet, ResourceID audioId)
	{
	}

	private static void ReleaseFlightAudios(ResourceID modelId, bool needRelease)
	{
	}

	public static bool EaraseRef(ResourceID id, bool needRelease)
	{
		return false;
	}

	private static void UnloadFlightResources(Object obj)
	{
	}

	public static void Clear()
	{
	}
}
