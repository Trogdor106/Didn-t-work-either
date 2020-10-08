#include "CheckpointLog.h"

void CheckpointLog::ResetLogger()
{
	m_RTBC.clear();
	m_TRT = 0.0f;
}

void CheckpointLog::SaveCheckpointTime(float RTBC)
{
	m_RTBC.push_back(RTBC);
	m_TRT += RTBC;
}

float CheckpointLog::GetTotalTime()
{
	return m_TRT;
}

float CheckpointLog::GetCheckpointTime(int index)
{
	return m_RTBC[index];
}

int CheckpointLog::GetNumCheckpoints()
{
	return m_RTBC.size();
}
