using UnityEngine;

namespace GCommon;

public class NetworkMaterialHelper : MonoBehaviour
{
	public Vector2 TextureSize;

	public string[] TargetMaterialNameList;

	public ENetworkMaterialGroup m_NetWorkMaterialGroup;

	public bool m_IsDynamic;

	public uint CDNId;

	public int ActivityType;

	public string DefaultResourceID;

	private const string REGEX_MAT_END = "\\s*\\(.*\\)?$";

	private void Start()
	{
	}
}
