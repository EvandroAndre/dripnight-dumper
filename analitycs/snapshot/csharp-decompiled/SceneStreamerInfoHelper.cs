using System.Collections.Generic;

public class SceneStreamerInfoHelper
{
	private static SceneStreamerInfoHelper m_Instance;

	public bool m_HaveUnloaded;

	public bool EnableMeshUnload;

	public bool EnableTextureUnload;

	private bool m_IsInited;

	private Dictionary<uint, StreamerMeshInfo> m_MeshInfos;

	private Dictionary<uint, StreamerTextureInfo> m_TexureInfos;

	private List<StreamerObjectRefInfo> m_NeedUnloadInfos;

	public static SceneStreamerInfoHelper Instance => null;

	public static SceneStreamerInfoHelper CreateInstance(bool enable_mesh_unload, bool enbale_texture_unlaod)
	{
		return null;
	}

	public static void ClearInstance()
	{
	}

	public void Init(bool enable_mesh_unload, bool enbale_texture_unlaod)
	{
	}

	public void UnInit()
	{
	}

	public void UpdateObjectRefs(StreamerSceneCollectionInfo scene_streamer_info)
	{
	}

	public StreamerMeshInfo FindMeshInfo(uint _mesh_id, bool could_create = false)
	{
		return null;
	}

	public StreamerTextureInfo FindTextureInfo(uint _text_id, bool could_create = false)
	{
		return null;
	}

	public void RemoveMeshInfo(uint _mesh_id)
	{
	}

	public void RemoveTexureInfo(uint _texture_id)
	{
	}

	public void RecordNeedUnloadObject(StreamerObjectRefInfo ref_info)
	{
	}

	public void UnloadUnusedAssets()
	{
	}
}
