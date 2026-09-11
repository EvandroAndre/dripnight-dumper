using System.Collections.Generic;
using UnityEngine;

public class FFFBXEngine
{
	private static float threshold;

	public static Mesh ParseBytesToMeshInEngine(byte[] content, out List<string> BoneList, int startIndex)
	{
		BoneList = null;
		return null;
	}

	public static Mesh ParseBytesToMesh(byte[] content, int startIndex)
	{
		return null;
	}

	private static bool CheckRange(byte[] content, int index, int needBytes, string field)
	{
		return false;
	}

	private static bool CheckCount(long count, int remainBytes, int elemBytes, string field)
	{
		return false;
	}

	public static Mesh ParseBytesToMeshV2(byte[] content, out List<string> Bone, int startIndex)
	{
		Bone = null;
		return null;
	}

	public static AnimationClip ParseBytesToAnimClipInEngine(byte[] content, bool legacyClip, out float length, out float start)
	{
		length = default(float);
		start = default(float);
		return null;
	}

	public static AnimationClip ParseBytesToAnimClip(byte[] content, bool legacyClip, out float length, out float start)
	{
		length = default(float);
		start = default(float);
		return null;
	}

	public static AnimationClip ParseBytesToAnimClipV2(byte[] content, bool legacyClip, out float length, out float start)
	{
		length = default(float);
		start = default(float);
		return null;
	}

	private static void UpdateCurveSmooth(ref AnimationCurve curve, float smoothfactor = 0f)
	{
	}
}
