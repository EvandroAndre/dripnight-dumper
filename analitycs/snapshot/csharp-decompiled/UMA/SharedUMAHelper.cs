using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public class SharedUMAHelper
{
	public class UMASharedData
	{
		public List<Texture[]> sharedResultingTextures;

		public Mesh sharedMesh;
	}

	public static Dictionary<uint, UMASharedData> sharedData;

	public static bool SharedTexExist(UMAData umaData)
	{
		return false;
	}

	public static void SaveSharedTex(UMAData umaData)
	{
	}

	public static bool SharedMeshExist(UMAData umaData)
	{
		return false;
	}

	public static void SaveSharedMesh(UMAData umaData)
	{
	}

	public static void ReleaseSharedData()
	{
	}
}
