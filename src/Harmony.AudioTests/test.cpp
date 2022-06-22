#include "pch.h"
#include "../Harmony.Audio/include/AudioMain.h"

TEST(Audio, AudioInit) {
  EXPECT_EQ(1, 1);
  EXPECT_TRUE(audio::init(1,2));
}