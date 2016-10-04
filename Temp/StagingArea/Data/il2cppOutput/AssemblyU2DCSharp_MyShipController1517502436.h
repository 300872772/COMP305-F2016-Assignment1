#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t1659122786;
// UnityEngine.AudioSource
struct AudioSource_t1740077639;
// GameController
struct GameController_t2782302542;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MyShipController
struct  MyShipController_t1517502436  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.Transform MyShipController::_tranform
	Transform_t1659122786 * ____tranform_2;
	// UnityEngine.AudioSource MyShipController::HitSound
	AudioSource_t1740077639 * ___HitSound_3;
	// UnityEngine.AudioSource MyShipController::PowerUpSound
	AudioSource_t1740077639 * ___PowerUpSound_4;
	// GameController MyShipController::gameController
	GameController_t2782302542 * ___gameController_5;

public:
	inline static int32_t get_offset_of__tranform_2() { return static_cast<int32_t>(offsetof(MyShipController_t1517502436, ____tranform_2)); }
	inline Transform_t1659122786 * get__tranform_2() const { return ____tranform_2; }
	inline Transform_t1659122786 ** get_address_of__tranform_2() { return &____tranform_2; }
	inline void set__tranform_2(Transform_t1659122786 * value)
	{
		____tranform_2 = value;
		Il2CppCodeGenWriteBarrier(&____tranform_2, value);
	}

	inline static int32_t get_offset_of_HitSound_3() { return static_cast<int32_t>(offsetof(MyShipController_t1517502436, ___HitSound_3)); }
	inline AudioSource_t1740077639 * get_HitSound_3() const { return ___HitSound_3; }
	inline AudioSource_t1740077639 ** get_address_of_HitSound_3() { return &___HitSound_3; }
	inline void set_HitSound_3(AudioSource_t1740077639 * value)
	{
		___HitSound_3 = value;
		Il2CppCodeGenWriteBarrier(&___HitSound_3, value);
	}

	inline static int32_t get_offset_of_PowerUpSound_4() { return static_cast<int32_t>(offsetof(MyShipController_t1517502436, ___PowerUpSound_4)); }
	inline AudioSource_t1740077639 * get_PowerUpSound_4() const { return ___PowerUpSound_4; }
	inline AudioSource_t1740077639 ** get_address_of_PowerUpSound_4() { return &___PowerUpSound_4; }
	inline void set_PowerUpSound_4(AudioSource_t1740077639 * value)
	{
		___PowerUpSound_4 = value;
		Il2CppCodeGenWriteBarrier(&___PowerUpSound_4, value);
	}

	inline static int32_t get_offset_of_gameController_5() { return static_cast<int32_t>(offsetof(MyShipController_t1517502436, ___gameController_5)); }
	inline GameController_t2782302542 * get_gameController_5() const { return ___gameController_5; }
	inline GameController_t2782302542 ** get_address_of_gameController_5() { return &___gameController_5; }
	inline void set_gameController_5(GameController_t2782302542 * value)
	{
		___gameController_5 = value;
		Il2CppCodeGenWriteBarrier(&___gameController_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
