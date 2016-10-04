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

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EnemyControl
struct  EnemyControl_t1151432917  : public MonoBehaviour_t667441552
{
public:
	// System.Int32 EnemyControl::_speed
	int32_t ____speed_2;
	// System.Int32 EnemyControl::_drift
	int32_t ____drift_3;
	// UnityEngine.Transform EnemyControl::_transform
	Transform_t1659122786 * ____transform_4;
	// System.Boolean EnemyControl::_direction
	bool ____direction_5;

public:
	inline static int32_t get_offset_of__speed_2() { return static_cast<int32_t>(offsetof(EnemyControl_t1151432917, ____speed_2)); }
	inline int32_t get__speed_2() const { return ____speed_2; }
	inline int32_t* get_address_of__speed_2() { return &____speed_2; }
	inline void set__speed_2(int32_t value)
	{
		____speed_2 = value;
	}

	inline static int32_t get_offset_of__drift_3() { return static_cast<int32_t>(offsetof(EnemyControl_t1151432917, ____drift_3)); }
	inline int32_t get__drift_3() const { return ____drift_3; }
	inline int32_t* get_address_of__drift_3() { return &____drift_3; }
	inline void set__drift_3(int32_t value)
	{
		____drift_3 = value;
	}

	inline static int32_t get_offset_of__transform_4() { return static_cast<int32_t>(offsetof(EnemyControl_t1151432917, ____transform_4)); }
	inline Transform_t1659122786 * get__transform_4() const { return ____transform_4; }
	inline Transform_t1659122786 ** get_address_of__transform_4() { return &____transform_4; }
	inline void set__transform_4(Transform_t1659122786 * value)
	{
		____transform_4 = value;
		Il2CppCodeGenWriteBarrier(&____transform_4, value);
	}

	inline static int32_t get_offset_of__direction_5() { return static_cast<int32_t>(offsetof(EnemyControl_t1151432917, ____direction_5)); }
	inline bool get__direction_5() const { return ____direction_5; }
	inline bool* get_address_of__direction_5() { return &____direction_5; }
	inline void set__direction_5(bool value)
	{
		____direction_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
