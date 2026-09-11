using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class GroupPhotoTemplateData
{
	public uint template_id;

	public uint sort_id;

	public string name;

	public string desc;

	public uint member_count;

	public ResourceID camera_prefab;

	public List<GroupPhotoTemplatePoseData> pose_datas;

	public ulong start_time;

	public ulong end_time;

	public string preview_icon_cdn;

	public bool is_vertical;

	public uint gopos;

	public string subgopos;

	public GroupPhotoTemplateChannel channel;

	public ulong expireTime;

	public bool isOwned;

	public string GrandPrizePreviewCDN;

	public bool isNew;

	public GroupPhotoTemplatePoseData GetPoseDataByPosId(uint pos_id)
	{
		return null;
	}

	public ResourceID GetResIdByPosId(uint pos_id, bool isFemale)
	{
		return default(ResourceID);
	}

	public Vector3 GetNamePosByPosId(uint pos_id)
	{
		return default(Vector3);
	}

	public bool NeedDownLoadResId(ref List<ResourceID> resourceIDs)
	{
		return false;
	}

	public bool IsPhotoTemplateGot()
	{
		return false;
	}

	public bool HaveGopos()
	{
		return false;
	}
}
