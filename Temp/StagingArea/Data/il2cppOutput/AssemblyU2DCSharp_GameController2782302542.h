#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioSource
struct AudioSource_t1740077639;
// RelicController1
struct RelicController1_t3364053698;
// EnemyControl
struct EnemyControl_t1151432917;
// UnityEngine.UI.Text
struct Text_t9039225;
// UnityEngine.UI.Button
struct Button_t3896396478;
// UnityEngine.GameObject
struct GameObject_t3674682005;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameController
struct  GameController_t2782302542  : public MonoBehaviour_t667441552
{
public:
	// System.Int32 GameController::_livesValue
	int32_t ____livesValue_2;
	// System.Int32 GameController::_scoreValue
	int32_t ____scoreValue_3;
	// UnityEngine.AudioSource GameController::_endGameSound
	AudioSource_t1740077639 * ____endGameSound_4;
	// System.Int32 GameController::killerRelic1Number
	int32_t ___killerRelic1Number_5;
	// RelicController1 GameController::killerRelic
	RelicController1_t3364053698 * ___killerRelic_6;
	// System.Int32 GameController::enemiesNumber
	int32_t ___enemiesNumber_7;
	// EnemyControl GameController::enemies
	EnemyControl_t1151432917 * ___enemies_8;
	// UnityEngine.UI.Text GameController::LivesLabel
	Text_t9039225 * ___LivesLabel_9;
	// UnityEngine.UI.Text GameController::ScoreLabel
	Text_t9039225 * ___ScoreLabel_10;
	// UnityEngine.UI.Text GameController::GameOverLabel
	Text_t9039225 * ___GameOverLabel_11;
	// UnityEngine.UI.Text GameController::FinalScoreLabel
	Text_t9039225 * ___FinalScoreLabel_12;
	// UnityEngine.UI.Button GameController::RestartButton
	Button_t3896396478 * ___RestartButton_13;
	// UnityEngine.GameObject GameController::myShip
	GameObject_t3674682005 * ___myShip_14;
	// UnityEngine.GameObject GameController::killerRelic1
	GameObject_t3674682005 * ___killerRelic1_15;
	// UnityEngine.GameObject GameController::killerRelic2
	GameObject_t3674682005 * ___killerRelic2_16;
	// UnityEngine.GameObject GameController::killerRelic3
	GameObject_t3674682005 * ___killerRelic3_17;
	// UnityEngine.GameObject GameController::powerRelic1
	GameObject_t3674682005 * ___powerRelic1_18;
	// UnityEngine.GameObject GameController::powerRelic2
	GameObject_t3674682005 * ___powerRelic2_19;

public:
	inline static int32_t get_offset_of__livesValue_2() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ____livesValue_2)); }
	inline int32_t get__livesValue_2() const { return ____livesValue_2; }
	inline int32_t* get_address_of__livesValue_2() { return &____livesValue_2; }
	inline void set__livesValue_2(int32_t value)
	{
		____livesValue_2 = value;
	}

	inline static int32_t get_offset_of__scoreValue_3() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ____scoreValue_3)); }
	inline int32_t get__scoreValue_3() const { return ____scoreValue_3; }
	inline int32_t* get_address_of__scoreValue_3() { return &____scoreValue_3; }
	inline void set__scoreValue_3(int32_t value)
	{
		____scoreValue_3 = value;
	}

	inline static int32_t get_offset_of__endGameSound_4() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ____endGameSound_4)); }
	inline AudioSource_t1740077639 * get__endGameSound_4() const { return ____endGameSound_4; }
	inline AudioSource_t1740077639 ** get_address_of__endGameSound_4() { return &____endGameSound_4; }
	inline void set__endGameSound_4(AudioSource_t1740077639 * value)
	{
		____endGameSound_4 = value;
		Il2CppCodeGenWriteBarrier(&____endGameSound_4, value);
	}

	inline static int32_t get_offset_of_killerRelic1Number_5() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___killerRelic1Number_5)); }
	inline int32_t get_killerRelic1Number_5() const { return ___killerRelic1Number_5; }
	inline int32_t* get_address_of_killerRelic1Number_5() { return &___killerRelic1Number_5; }
	inline void set_killerRelic1Number_5(int32_t value)
	{
		___killerRelic1Number_5 = value;
	}

	inline static int32_t get_offset_of_killerRelic_6() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___killerRelic_6)); }
	inline RelicController1_t3364053698 * get_killerRelic_6() const { return ___killerRelic_6; }
	inline RelicController1_t3364053698 ** get_address_of_killerRelic_6() { return &___killerRelic_6; }
	inline void set_killerRelic_6(RelicController1_t3364053698 * value)
	{
		___killerRelic_6 = value;
		Il2CppCodeGenWriteBarrier(&___killerRelic_6, value);
	}

	inline static int32_t get_offset_of_enemiesNumber_7() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___enemiesNumber_7)); }
	inline int32_t get_enemiesNumber_7() const { return ___enemiesNumber_7; }
	inline int32_t* get_address_of_enemiesNumber_7() { return &___enemiesNumber_7; }
	inline void set_enemiesNumber_7(int32_t value)
	{
		___enemiesNumber_7 = value;
	}

	inline static int32_t get_offset_of_enemies_8() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___enemies_8)); }
	inline EnemyControl_t1151432917 * get_enemies_8() const { return ___enemies_8; }
	inline EnemyControl_t1151432917 ** get_address_of_enemies_8() { return &___enemies_8; }
	inline void set_enemies_8(EnemyControl_t1151432917 * value)
	{
		___enemies_8 = value;
		Il2CppCodeGenWriteBarrier(&___enemies_8, value);
	}

	inline static int32_t get_offset_of_LivesLabel_9() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___LivesLabel_9)); }
	inline Text_t9039225 * get_LivesLabel_9() const { return ___LivesLabel_9; }
	inline Text_t9039225 ** get_address_of_LivesLabel_9() { return &___LivesLabel_9; }
	inline void set_LivesLabel_9(Text_t9039225 * value)
	{
		___LivesLabel_9 = value;
		Il2CppCodeGenWriteBarrier(&___LivesLabel_9, value);
	}

	inline static int32_t get_offset_of_ScoreLabel_10() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___ScoreLabel_10)); }
	inline Text_t9039225 * get_ScoreLabel_10() const { return ___ScoreLabel_10; }
	inline Text_t9039225 ** get_address_of_ScoreLabel_10() { return &___ScoreLabel_10; }
	inline void set_ScoreLabel_10(Text_t9039225 * value)
	{
		___ScoreLabel_10 = value;
		Il2CppCodeGenWriteBarrier(&___ScoreLabel_10, value);
	}

	inline static int32_t get_offset_of_GameOverLabel_11() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___GameOverLabel_11)); }
	inline Text_t9039225 * get_GameOverLabel_11() const { return ___GameOverLabel_11; }
	inline Text_t9039225 ** get_address_of_GameOverLabel_11() { return &___GameOverLabel_11; }
	inline void set_GameOverLabel_11(Text_t9039225 * value)
	{
		___GameOverLabel_11 = value;
		Il2CppCodeGenWriteBarrier(&___GameOverLabel_11, value);
	}

	inline static int32_t get_offset_of_FinalScoreLabel_12() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___FinalScoreLabel_12)); }
	inline Text_t9039225 * get_FinalScoreLabel_12() const { return ___FinalScoreLabel_12; }
	inline Text_t9039225 ** get_address_of_FinalScoreLabel_12() { return &___FinalScoreLabel_12; }
	inline void set_FinalScoreLabel_12(Text_t9039225 * value)
	{
		___FinalScoreLabel_12 = value;
		Il2CppCodeGenWriteBarrier(&___FinalScoreLabel_12, value);
	}

	inline static int32_t get_offset_of_RestartButton_13() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___RestartButton_13)); }
	inline Button_t3896396478 * get_RestartButton_13() const { return ___RestartButton_13; }
	inline Button_t3896396478 ** get_address_of_RestartButton_13() { return &___RestartButton_13; }
	inline void set_RestartButton_13(Button_t3896396478 * value)
	{
		___RestartButton_13 = value;
		Il2CppCodeGenWriteBarrier(&___RestartButton_13, value);
	}

	inline static int32_t get_offset_of_myShip_14() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___myShip_14)); }
	inline GameObject_t3674682005 * get_myShip_14() const { return ___myShip_14; }
	inline GameObject_t3674682005 ** get_address_of_myShip_14() { return &___myShip_14; }
	inline void set_myShip_14(GameObject_t3674682005 * value)
	{
		___myShip_14 = value;
		Il2CppCodeGenWriteBarrier(&___myShip_14, value);
	}

	inline static int32_t get_offset_of_killerRelic1_15() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___killerRelic1_15)); }
	inline GameObject_t3674682005 * get_killerRelic1_15() const { return ___killerRelic1_15; }
	inline GameObject_t3674682005 ** get_address_of_killerRelic1_15() { return &___killerRelic1_15; }
	inline void set_killerRelic1_15(GameObject_t3674682005 * value)
	{
		___killerRelic1_15 = value;
		Il2CppCodeGenWriteBarrier(&___killerRelic1_15, value);
	}

	inline static int32_t get_offset_of_killerRelic2_16() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___killerRelic2_16)); }
	inline GameObject_t3674682005 * get_killerRelic2_16() const { return ___killerRelic2_16; }
	inline GameObject_t3674682005 ** get_address_of_killerRelic2_16() { return &___killerRelic2_16; }
	inline void set_killerRelic2_16(GameObject_t3674682005 * value)
	{
		___killerRelic2_16 = value;
		Il2CppCodeGenWriteBarrier(&___killerRelic2_16, value);
	}

	inline static int32_t get_offset_of_killerRelic3_17() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___killerRelic3_17)); }
	inline GameObject_t3674682005 * get_killerRelic3_17() const { return ___killerRelic3_17; }
	inline GameObject_t3674682005 ** get_address_of_killerRelic3_17() { return &___killerRelic3_17; }
	inline void set_killerRelic3_17(GameObject_t3674682005 * value)
	{
		___killerRelic3_17 = value;
		Il2CppCodeGenWriteBarrier(&___killerRelic3_17, value);
	}

	inline static int32_t get_offset_of_powerRelic1_18() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___powerRelic1_18)); }
	inline GameObject_t3674682005 * get_powerRelic1_18() const { return ___powerRelic1_18; }
	inline GameObject_t3674682005 ** get_address_of_powerRelic1_18() { return &___powerRelic1_18; }
	inline void set_powerRelic1_18(GameObject_t3674682005 * value)
	{
		___powerRelic1_18 = value;
		Il2CppCodeGenWriteBarrier(&___powerRelic1_18, value);
	}

	inline static int32_t get_offset_of_powerRelic2_19() { return static_cast<int32_t>(offsetof(GameController_t2782302542, ___powerRelic2_19)); }
	inline GameObject_t3674682005 * get_powerRelic2_19() const { return ___powerRelic2_19; }
	inline GameObject_t3674682005 ** get_address_of_powerRelic2_19() { return &___powerRelic2_19; }
	inline void set_powerRelic2_19(GameObject_t3674682005 * value)
	{
		___powerRelic2_19 = value;
		Il2CppCodeGenWriteBarrier(&___powerRelic2_19, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
