#pragma once
#include "pch.h"

#ifdef HARMONYAUDIO_EXPORTS
#define AUDIO_API __declspec(dllexport)
#else
#define AUDIO_API __declspec(dllimport)
#endif
namespace audio
{
	extern "C" AUDIO_API bool init(const unsigned long long a, const unsigned long long b);
}
