using System.Collections.Generic;

namespace proto;

public class CSGetPlayerCallbackInfoRes
{
	public PlayerCallbackInfo self_callback_info;

	public List<ReturnerCallbackInfo> invited_returner_infos;

	public List<CallbackRequest> sent_requests;

	public List<CallbackRequest> received_requests;

	public uint callback_points;

	public uint[] claimed_process;
}
