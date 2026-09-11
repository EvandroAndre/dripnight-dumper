using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW;

public class UIModelUGCTimelineEditData : UIBaseModel
{
	private HLCNBGLCCNI m_EditorAssetDataList;

	private Dictionary<string, PAEHKPKMJKN> m_UGCTimelineDataMap;

	public int SelectedEditorDataIndex;

	private Dictionary<int, SceneEditTimelineInspector> m_TimelineInspectorCfg;

	private Dictionary<int, UGCTimelineEditTracksConfig> m_TimelineTracksCfg;

	private List<UGCTimelineEditRule> m_TimelineTipsCfg;

	private uint mTimelineTrackEditTime;

	private uint mTimelineSceneEditTime;

	private ulong mTrackEditStartTime;

	private ulong mSceneEditStartTime;

	private ulong mTimelineCameraTrackFpvStartTime;

	private ulong mTimelineCameraTrackFpvEditDuration;

	private ulong mTimelineCameraTrackNormalStartTime;

	private ulong mTimelineCameraTrackNormalEditDuration;

	private ulong TimelineAudiencePersBtnCnt;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version)
	{
		return false;
	}

	public bool Export(out byte[] editorDataBytes, ref EditorMiscData miscData)
	{
		editorDataBytes = null;
		return false;
	}

	private void CollectAllRefSceneEntity(EditorMiscData miscData)
	{
	}

	public bool UnloadProject()
	{
		return false;
	}

	private void LoadConfig()
	{
	}

	public int GetEditorAssetDataCount()
	{
		return 0;
	}

	public CAIDHLFFJDP GetEditorAssetData(int index)
	{
		return null;
	}

	public PAEHKPKMJKN GetTimelineData(CAIDHLFFJDP editorAssetData)
	{
		return null;
	}

	public CAIDHLFFJDP CreateNewPerformance()
	{
		return null;
	}

	private string GetNewPerformanceName()
	{
		return null;
	}

	private string GetNewCopyPerformanceName(string originName)
	{
		return null;
	}

	public bool CopyPerformance(int index)
	{
		return false;
	}

	public void RemovePerformance(int index)
	{
	}

	public bool UpdataSave(CAIDHLFFJDP editorAssetData)
	{
		return false;
	}

	public bool Rename(int index, string newPerformanceName)
	{
		return false;
	}

	public uint GetAssetCount()
	{
		return 0u;
	}

	public void GetTimelineLogInfo(ref uint timeline_asset_cnt, ref List<EventLogger.EventTypeWorkshopSceneEdit.TimelineTrackInfo> timeline_track_info, ref uint timeline_track_edit_time, ref uint timeline_scene_edit_time, ref uint timeline_asset_avg_duration, ref List<uint> timeline_switch_camera_track_cnt, ref uint timeline_camera_track_fpv_edit_time, ref uint timeline_camera_track_normal_edit_time, ref List<EventLogger.EventTypeWorkshopSceneEdit.TimelineAnimationTrackInfo> timeline_animation_track_info, ref List<EventLogger.EventTypeWorkshopSceneEdit.TimelineAudioTrackInfo> timeline_audio_track_info, ref uint timeline_event_track_send_cnt, ref uint timeline_audience_pers_btn_cnt)
	{
	}

	private void CollectTimelineDataInfo(PAEHKPKMJKN timelineData, ref List<uint> timeline_switch_camera_track_cnt, ref Dictionary<string, uint> timeline_animation_track_map, ref Dictionary<string, uint> timeline_audio_track_map, ref uint timeline_event_track_send_cnt)
	{
	}

	private void CollectTimelineTrackInfo(HPKDGEHKENL trackData, ref uint timeline_switch_camera_track_cnt, ref Dictionary<string, uint> timeline_animation_track_map, ref Dictionary<string, uint> timeline_audio_track_map, ref uint timeline_event_track_send_cnt)
	{
	}

	private void CollectTimelineAudioTrackInfo(HPKDGEHKENL track, ref Dictionary<string, uint> timeline_audio_track_map)
	{
	}

	private void CollectTimelineEventTrackInfo(HPKDGEHKENL track, ref uint timeline_event_track_send_cnt)
	{
	}

	private void CollectTimelineAnimationTrackInfo(HPKDGEHKENL track, ref Dictionary<string, uint> timeline_animation_track_map)
	{
	}

	private string GetTrackName(int trackType)
	{
		return null;
	}

	public void EnterTrackEditView()
	{
	}

	public void ExitTrackEditView(uint pauseTime)
	{
	}

	public void EnterSceneEditView()
	{
	}

	public void ExitSceneEditView(uint pauseTime)
	{
	}

	public void EnterCameraTrackFpvEditView()
	{
	}

	public void ExitCameraTrackFpvEditView(uint pauseTime)
	{
	}

	public void EnterCameraTrackNormalEditView()
	{
	}

	public void ExitCameraTrackNormalEditView(uint pauseTime)
	{
	}

	public void CollectTimelineAudiencePersCount()
	{
	}

	public List<UGCTimelineEditRule> GetTimelineRuleTips()
	{
		return null;
	}

	public bool CheckShowInInspector(int propID)
	{
		return false;
	}

	public List<UGCTimelineEditTracksConfig> GetParentTracks()
	{
		return null;
	}

	public UGCTimelineEditTracksConfig GetTrackConfig(MHHOHPCLMFB trackType)
	{
		return null;
	}

	public bool TryGetBindTrackByTypeName(string typeName, out UGCTimelineEditTracksConfig cfg)
	{
		cfg = null;
		return false;
	}
}
