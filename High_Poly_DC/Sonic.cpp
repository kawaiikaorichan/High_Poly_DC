#include "pch.h"
#include "sstextlist.h"

#define ReplacePVM(a, b) helperFunctions.ReplaceFile("system\\" a ".PVM", "system\\" b ".PVM");
NJS_MATERIAL* TemporaryMaterialArray[] = { nullptr };

void Tornado_init(const HelperFunctions& helperFunctions);

DataPointer(NJS_OBJECT, SonicPointingHand_Object, 0x2DD8708);

void PointingFinger_Init(const HelperFunctions& helperFunctions) {
	ModelInfo* mdl = new ModelInfo(helperFunctions.GetReplaceablePath("system\\SONIC_POINTINGHAND.sa1mdl"));

	if (mdl->getformat() == ModelFormat_Basic) {
		SonicPointingHand_Object = *mdl->getmodel();
	}
}

void __cdecl Sonic_Main_r(ObjectMaster* obj);
Trampoline Sonic_Main_t((int)Sonic_Main, (int)Sonic_Main + 0x7, Sonic_Main_r);
void __cdecl Sonic_Main_r(ObjectMaster* obj) {
	// Prevent Sonic's cinematic head from appearing
	SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->child->child->sibling->sibling->sibling = SONIC_OBJECTS[46];

	NonStaticFunctionPointer(void, original, (ObjectMaster * obj), Sonic_Main_t.Target());
	original(obj);
};

void __cdecl sub_4310D0_r(ObjectMaster* obj, const char* list);
Trampoline sub_4310D0_t(0x4310D0, 0x4310D6, sub_4310D0_r);
void __cdecl sub_4310D0_r(ObjectMaster* obj, const char* list) {
	NonStaticFunctionPointer(void, original, (ObjectMaster * obj, const char* list), sub_4310D0_t.Target());

	if (obj->Data1->CharID != Characters_Sonic) {
		original(obj, list);
	}
};

static ModelInfo* SonicPlaneMdl = nullptr;

DataPointer(NJS_OBJECT, Tornado1_Object, 0x28B1DA0);
DataPointer(NJS_OBJECT, Tornado2Before_Object, 0x27EB198);
DataPointer(NJS_OBJECT, Tornado2Change_Object, 0x280C158);

bool CheckIfSonicPlane(NJS_MODEL_SADX* model) {
	return SonicPlaneMdl->getlabel(model) != "";
}

void __cdecl TornadoCallBack(NJS_MODEL_SADX* model, int blend, int idk) {
	NonStaticFunctionPointer(void, sub_407FC0, (NJS_MODEL_SADX*, int), 0x407FC0);

	// If the currently drawn model is part of SONIC_PLANE, we use the character's texlist instead
	if (CheckIfSonicPlane(model)) {
		NJS_TEXLIST* tex_orig = CurrentTexList;

		njSetTexture(&SONIC_TEXLIST);
		sub_407FC0(model, blend);
		njSetTexture(tex_orig);
	}
	else {
		sub_407FC0(model, blend);
	}
}

void njAction_Queue_Tornado(NJS_ACTION* action, float frame, QueuedModelFlagsB flags) {
	DisplayAnimationFrame(action, frame, flags, 0.0, TornadoCallBack);
}

void Tornado_init(const HelperFunctions& helperFunctions) {
	ModelInfo* mdl = new ModelInfo(helperFunctions.GetReplaceablePath("system\\SONIC_PLANE.sa1mdl"));

	if (mdl->getformat() == ModelFormat_Basic) {
		SonicPlaneMdl = mdl;

		// We only replace Sonic's part of the plane
		Tornado1_Object.child->sibling->sibling->sibling->child = SonicPlaneMdl->getmodel();
		Tornado2Before_Object.child->sibling->sibling->child = SonicPlaneMdl->getmodel();
		Tornado2Change_Object.child->sibling->sibling->sibling->sibling->child = SonicPlaneMdl->getmodel();

		// Hack to use our own texture for Sonic's part of the plane, allowing compatibility with dc mods.
		WriteCall((void*)0x62753A, njAction_Queue_Tornado);
	}
	else {
		PrintDebug("[High-poly DC characters] Cannot open \"SONIC_PLANE.sa1mdl\".\n");
	}
}

uint16_t Sonic_RightUpperArmIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	8, 10,
	10, 12,
	12, 14,
	14, 8,
};

uint16_t Sonic_LeftUpperArmIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	8, 11,
	10, 13,
	12, 15,
	14, 9,
};

uint16_t Sonic_RightLowerArmIndices_DC[] = {
	0, 10,
	1, 11,
	4, 14,
	5, 15,
	9, 28,
	11, 31,
	13, 34,
	15, 25,
};

uint16_t Sonic_LeftLowerArmIndices_DC[] = {
	0, 10,
	1, 11,
	4, 14,
	5, 15,
	8, 26,
	10, 23,
	12, 32,
	14, 29,
};

uint16_t Sonic_RightKneeIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	9, 15,
	11, 13,
	13, 11,
	15, 9,
};

uint16_t Sonic_LeftKneeIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	9, 14,
	11, 8,
	13, 10,
	15, 12,
};

uint16_t Sonic_RightLegIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	8, 34,
	10, 25,
	12, 28,
	14, 31,
};

uint16_t Sonic_LeftLegIndices_DC[] = {
	0, 2,
	1, 3,
	4, 6,
	5, 7,
	9, 28,
	11, 25,
	13, 34,
	15, 31,
};

uint16_t Sonic_ShoeIndices_DC[] = {
	205, 396,
	206, 397,
	199, 394,
	200, 395,
	168, 399,
	169, 340,
	170, 341,
	289, 469,
	288, 467,
	324, 479,
	306, 478,
	283, 429,
	284, 430,
	285, 431,
	337, 517,
	186, 389,
	187, 390,
	188, 391,
	193, 392,
	194, 393,
	112, 314,
	113, 273,
	105, 236,
	106, 235,
	107, 234,
	132, 223,
	133, 224,
	24, 216,
	25, 215,
	26, 214,
	82, 260,
	83, 259,
	88, 262,
	89, 261,
	15, 200,
	16, 199,
	17, 198,
	76, 12,
	77, 238,
};

uint16_t Sonic_RightHandIndices_DC[] = {
	11, 50,
	74, 365,
	28, 153,
	59, 481,
	0, 14,
	77, 266,
	31, 77,
	63, 282,
	12, 13,
	39, 315,
	13, 115,
	40, 443,
	1, 55,
	51, 359,
	15, 147,
	43, 475,
	5, 54,
	42, 431,
	18, 205,
	47, 533,
	8, 12,
	67, 396,
	21, 180,
	50, 508,
	4, 15,
	70, 393,
	24, 178,
	55, 506,
};

uint16_t Sonic_LeftHandIndices_DC[] = {
	11, 50,
	75, 426,
	29, 201,
	60, 529,
	4, 15,
	76, 254,
	30, 67,
	61, 434,
	8, 12,
	43, 337,
	18, 131,
	46, 459,
	5, 54,
	62, 411,
	15, 188,
	42, 516,
	1, 55,
	47, 371,
	14, 158,
	40, 486,
	12, 13,
	68, 272,
	22, 80,
	52, 395,
	0, 14,
	72, 420,
	26, 196,
	56, 524,
};

uint16_t Sonic_CrystalArmIndices_DC[] = {
	0, 10,
	1, 11,
	4, 14,
	5, 15,
	9, 50,
	11, 48,
	13, 54,
	15, 52,
};

uint16_t Sonic_LightShoeIndices_DC[] = {
	205, 395,
	206, 396,
	199, 393,
	200, 394,
	168, 338,
	169, 339,
	170, 340,
	289, 468,
	288, 466,
	324, 478,
	306, 477,
	283, 428,
	284, 429,
	285, 430,
	337, 516,
	186, 388,
	187, 389,
	188, 390,
	193, 391,
	194, 392,
	112, 313,
	113, 272,
	105, 235,
	106, 234,
	107, 233,
	132, 222,
	133, 223,
	24, 215,
	25, 214,
	26, 213,
	82, 259,
	83, 258,
	88, 261,
	89, 260,
	15, 199,
	16, 198,
	17, 197,
	76, 12,
	77, 237,
};

void InitSonicWeldInfo_DC();
Trampoline InitSonicWeldInfo_t((int)InitSonicWeldInfo, (int)InitSonicWeldInfo + 0x5, InitSonicWeldInfo_DC);
void InitSonicWeldInfo_DC() {
	VoidFunc(original, InitSonicWeldInfo_t.Target());
	original(); // For Metal Sonic compatibility with other mods

	// Hand fix (The Mod Loader's chrmodels replacement system does that wrong)
	SONIC_OBJECTS[4] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling;
	SONIC_OBJECTS[5] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling->child->sibling;
	SONIC_OBJECTS[63]->sibling = SONIC_OBJECTS[4];

	// Shoe fix
	SONIC_OBJECTS[15] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling;
	SONIC_OBJECTS[16] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling->child;
	SONIC_OBJECTS[20] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling;
	SONIC_OBJECTS[21] = SONIC_OBJECTS[0]->child->child->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->sibling->child->child->child->child->sibling->sibling->child;

	// Sonic

	SonicWeldInfo[0].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[0].ModelA = SONIC_OBJECTS[1];
	SonicWeldInfo[0].ModelB = SONIC_OBJECTS[2];
	SonicWeldInfo[0].anonymous_5 = 0;
	SonicWeldInfo[0].VertexBuffer = 0;
	SonicWeldInfo[0].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightUpperArmIndices_DC) / 2);
	SonicWeldInfo[0].WeldType = 2;
	SonicWeldInfo[0].VertIndexes = Sonic_RightUpperArmIndices_DC;

	SonicWeldInfo[1].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[1].ModelA = SONIC_OBJECTS[2];
	SonicWeldInfo[1].ModelB = SONIC_OBJECTS[3];
	SonicWeldInfo[1].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightLowerArmIndices_DC) / 2);
	SonicWeldInfo[1].WeldType = 2;
	SonicWeldInfo[1].anonymous_5 = 0;
	SonicWeldInfo[1].VertexBuffer = 0;
	SonicWeldInfo[1].VertIndexes = Sonic_RightLowerArmIndices_DC;

	SonicWeldInfo[2].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[2].ModelA = SONIC_OBJECTS[7];
	SonicWeldInfo[2].ModelB = SONIC_OBJECTS[8];
	SonicWeldInfo[2].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftUpperArmIndices_DC) / 2);
	SonicWeldInfo[2].WeldType = 2;
	SonicWeldInfo[2].anonymous_5 = 0;
	SonicWeldInfo[2].VertexBuffer = 0;
	SonicWeldInfo[2].VertIndexes = Sonic_LeftUpperArmIndices_DC;

	SonicWeldInfo[3].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[3].ModelA = SONIC_OBJECTS[8];
	SonicWeldInfo[3].ModelB = SONIC_OBJECTS[9];
	SonicWeldInfo[3].VertIndexes = Sonic_LeftLowerArmIndices_DC;
	SonicWeldInfo[3].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftLowerArmIndices_DC) / 2);
	SonicWeldInfo[3].WeldType = 2;
	SonicWeldInfo[3].anonymous_5 = 0;
	SonicWeldInfo[3].VertexBuffer = 0;

	SonicWeldInfo[4].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[4].ModelA = SONIC_OBJECTS[12];
	SonicWeldInfo[4].ModelB = SONIC_OBJECTS[13];
	SonicWeldInfo[4].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightKneeIndices_DC) / 2);
	SonicWeldInfo[4].WeldType = 2;
	SonicWeldInfo[4].anonymous_5 = 0;
	SonicWeldInfo[4].VertexBuffer = 0;
	SonicWeldInfo[4].VertIndexes = Sonic_RightKneeIndices_DC;

	SonicWeldInfo[5].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[5].ModelA = SONIC_OBJECTS[13];
	SonicWeldInfo[5].ModelB = SONIC_OBJECTS[14];
	SonicWeldInfo[5].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightLegIndices_DC) / 2);
	SonicWeldInfo[5].WeldType = 2;
	SonicWeldInfo[5].anonymous_5 = 0;
	SonicWeldInfo[5].VertexBuffer = 0;
	SonicWeldInfo[5].VertIndexes = Sonic_RightLegIndices_DC;

	SonicWeldInfo[6].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[6].ModelA = SONIC_OBJECTS[17];
	SonicWeldInfo[6].VertIndexes = Sonic_LeftKneeIndices_DC;
	SonicWeldInfo[6].ModelB = SONIC_OBJECTS[18];
	SonicWeldInfo[6].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftKneeIndices_DC) / 2);
	SonicWeldInfo[6].WeldType = 2;
	SonicWeldInfo[6].anonymous_5 = 0;
	SonicWeldInfo[6].VertexBuffer = 0;

	SonicWeldInfo[7].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[7].ModelA = SONIC_OBJECTS[18];
	SonicWeldInfo[7].ModelB = SONIC_OBJECTS[19];
	SonicWeldInfo[7].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftLegIndices_DC) / 2);
	SonicWeldInfo[7].WeldType = 2;
	SonicWeldInfo[7].anonymous_5 = 0;
	SonicWeldInfo[7].VertexBuffer = 0;
	SonicWeldInfo[7].VertIndexes = Sonic_LeftLegIndices_DC;

	SonicWeldInfo[8].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[8].ModelA = SONIC_OBJECTS[15];
	SonicWeldInfo[8].ModelB = SONIC_OBJECTS[16];
	SonicWeldInfo[8].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_ShoeIndices_DC) / 2);
	SonicWeldInfo[8].WeldType = 2;
	SonicWeldInfo[8].anonymous_5 = 0;
	SonicWeldInfo[8].VertexBuffer = 0;
	SonicWeldInfo[8].VertIndexes = Sonic_ShoeIndices_DC;

	SonicWeldInfo[9].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[9].ModelA = SONIC_OBJECTS[20];
	SonicWeldInfo[9].VertIndexes = Sonic_ShoeIndices_DC;
	SonicWeldInfo[9].ModelB = SONIC_OBJECTS[21];
	SonicWeldInfo[9].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_ShoeIndices_DC) / 2);
	SonicWeldInfo[9].WeldType = 2;
	SonicWeldInfo[9].anonymous_5 = 0;
	SonicWeldInfo[9].VertexBuffer = 0;

	SonicWeldInfo[10].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[10].ModelA = SONIC_OBJECTS[10];
	SonicWeldInfo[10].ModelB = SONIC_OBJECTS[11];
	SonicWeldInfo[10].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightHandIndices_DC) / 2);
	SonicWeldInfo[10].WeldType = 2;
	SonicWeldInfo[10].anonymous_5 = 0;
	SonicWeldInfo[10].VertexBuffer = 0;
	SonicWeldInfo[10].VertIndexes = Sonic_RightHandIndices_DC;

	SonicWeldInfo[11].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[11].ModelA = SONIC_OBJECTS[4];
	SonicWeldInfo[11].ModelB = SONIC_OBJECTS[5];
	SonicWeldInfo[11].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftHandIndices_DC) / 2);
	SonicWeldInfo[11].WeldType = 2;
	SonicWeldInfo[11].anonymous_5 = 0;
	SonicWeldInfo[11].VertexBuffer = 0;
	SonicWeldInfo[11].VertIndexes = Sonic_LeftHandIndices_DC;

	SonicWeldInfo[12].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[12].ModelA = SONIC_OBJECTS[58];
	SonicWeldInfo[12].ModelB = SONIC_OBJECTS[59];
	SonicWeldInfo[12].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LightShoeIndices_DC) / 2);
	SonicWeldInfo[12].WeldType = 2;
	SonicWeldInfo[12].anonymous_5 = 0;
	SonicWeldInfo[12].VertexBuffer = 0;
	SonicWeldInfo[12].VertIndexes = Sonic_LightShoeIndices_DC;

	SonicWeldInfo[13].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[13].ModelA = SONIC_OBJECTS[60];
	SonicWeldInfo[13].ModelB = SONIC_OBJECTS[61];
	SonicWeldInfo[13].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LightShoeIndices_DC) / 2);
	SonicWeldInfo[13].WeldType = 2;
	SonicWeldInfo[13].anonymous_5 = 0;
	SonicWeldInfo[13].VertexBuffer = 0;
	SonicWeldInfo[13].VertIndexes = Sonic_LightShoeIndices_DC;

	SonicWeldInfo[14].BaseModel = SONIC_OBJECTS[0];
	SonicWeldInfo[14].ModelA = SONIC_OBJECTS[2];
	SonicWeldInfo[14].ModelB = SONIC_OBJECTS[63];
	SonicWeldInfo[14].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_CrystalArmIndices_DC) / 2);
	SonicWeldInfo[14].WeldType = 2;
	SonicWeldInfo[14].anonymous_5 = 0;
	SonicWeldInfo[14].VertexBuffer = 0;
	SonicWeldInfo[14].VertIndexes = Sonic_CrystalArmIndices_DC;

	// Super Sonic

	SonicWeldInfo[22].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[22].ModelA = SONIC_OBJECTS[23];
	SonicWeldInfo[22].ModelB = SONIC_OBJECTS[24];
	SonicWeldInfo[22].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightUpperArmIndices_DC) / 2);
	SonicWeldInfo[22].WeldType = 2;
	SonicWeldInfo[22].anonymous_5 = 0;
	SonicWeldInfo[22].VertexBuffer = 0;
	SonicWeldInfo[22].VertIndexes = Sonic_RightUpperArmIndices_DC;

	SonicWeldInfo[23].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[23].ModelA = SONIC_OBJECTS[24];
	SonicWeldInfo[23].ModelB = SONIC_OBJECTS[25];
	SonicWeldInfo[23].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightLowerArmIndices_DC) / 2);
	SonicWeldInfo[23].WeldType = 2;
	SonicWeldInfo[23].anonymous_5 = 0;
	SonicWeldInfo[23].VertexBuffer = 0;
	SonicWeldInfo[23].VertIndexes = Sonic_RightLowerArmIndices_DC;

	SonicWeldInfo[24].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[24].ModelA = SONIC_OBJECTS[28];
	SonicWeldInfo[24].ModelB = SONIC_OBJECTS[29];
	SonicWeldInfo[24].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftUpperArmIndices_DC) / 2);
	SonicWeldInfo[24].WeldType = 2;
	SonicWeldInfo[24].anonymous_5 = 0;
	SonicWeldInfo[24].VertexBuffer = 0;
	SonicWeldInfo[24].VertIndexes = Sonic_LeftUpperArmIndices_DC;

	SonicWeldInfo[25].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[25].ModelA = SONIC_OBJECTS[29];
	SonicWeldInfo[25].ModelB = SONIC_OBJECTS[30];
	SonicWeldInfo[25].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftLowerArmIndices_DC) / 2);
	SonicWeldInfo[25].WeldType = 2;
	SonicWeldInfo[25].anonymous_5 = 0;
	SonicWeldInfo[25].VertexBuffer = 0;
	SonicWeldInfo[25].VertIndexes = Sonic_LeftLowerArmIndices_DC;

	SonicWeldInfo[26].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[26].ModelA = SONIC_OBJECTS[33];
	SonicWeldInfo[26].ModelB = SONIC_OBJECTS[34];
	SonicWeldInfo[26].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightKneeIndices_DC) / 2);
	SonicWeldInfo[26].WeldType = 2;
	SonicWeldInfo[26].anonymous_5 = 0;
	SonicWeldInfo[26].VertexBuffer = 0;
	SonicWeldInfo[26].VertIndexes = Sonic_RightKneeIndices_DC;

	SonicWeldInfo[27].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[27].ModelA = SONIC_OBJECTS[34];
	SonicWeldInfo[27].ModelB = SONIC_OBJECTS[35];
	SonicWeldInfo[27].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightLegIndices_DC) / 2);
	SonicWeldInfo[27].WeldType = 2;
	SonicWeldInfo[27].anonymous_5 = 0;
	SonicWeldInfo[27].VertexBuffer = 0;
	SonicWeldInfo[27].VertIndexes = Sonic_RightLegIndices_DC;

	SonicWeldInfo[28].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[28].ModelA = SONIC_OBJECTS[38];
	SonicWeldInfo[28].VertIndexes = Sonic_LeftKneeIndices_DC;
	SonicWeldInfo[28].ModelB = SONIC_OBJECTS[39];
	SonicWeldInfo[28].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftKneeIndices_DC) / 2);
	SonicWeldInfo[28].WeldType = 2;
	SonicWeldInfo[28].anonymous_5 = 0;
	SonicWeldInfo[28].VertexBuffer = 0;

	SonicWeldInfo[29].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[29].ModelA = SONIC_OBJECTS[39];
	SonicWeldInfo[29].ModelB = SONIC_OBJECTS[40];
	SonicWeldInfo[29].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftLegIndices_DC) / 2);
	SonicWeldInfo[29].WeldType = 2;
	SonicWeldInfo[29].anonymous_5 = 0;
	SonicWeldInfo[29].VertexBuffer = 0;
	SonicWeldInfo[29].VertIndexes = Sonic_LeftLegIndices_DC;

	SonicWeldInfo[30].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[30].ModelA = SONIC_OBJECTS[36];
	SonicWeldInfo[30].ModelB = SONIC_OBJECTS[37];
	SonicWeldInfo[30].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LightShoeIndices_DC) / 2);
	SonicWeldInfo[30].WeldType = 2;
	SonicWeldInfo[30].anonymous_5 = 0;
	SonicWeldInfo[30].VertexBuffer = 0;
	SonicWeldInfo[30].VertIndexes = Sonic_LightShoeIndices_DC;

	SonicWeldInfo[31].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[31].ModelA = SONIC_OBJECTS[41];
	SonicWeldInfo[31].ModelB = SONIC_OBJECTS[42];
	SonicWeldInfo[31].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LightShoeIndices_DC) / 2);
	SonicWeldInfo[31].WeldType = 2;
	SonicWeldInfo[31].anonymous_5 = 0;
	SonicWeldInfo[31].VertexBuffer = 0;
	SonicWeldInfo[31].VertIndexes = Sonic_LightShoeIndices_DC;

	SonicWeldInfo[32].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[32].ModelA = SONIC_OBJECTS[31];
	SonicWeldInfo[32].ModelB = SONIC_OBJECTS[32];
	SonicWeldInfo[32].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftHandIndices_DC) / 2);
	SonicWeldInfo[32].WeldType = 2;
	SonicWeldInfo[32].anonymous_5 = 0;
	SonicWeldInfo[32].VertexBuffer = 0;
	SonicWeldInfo[32].VertIndexes = Sonic_LeftHandIndices_DC;

	SonicWeldInfo[33].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[33].ModelA = SONIC_OBJECTS[26];
	SonicWeldInfo[33].anonymous_5 = 0;
	SonicWeldInfo[33].VertexBuffer = 0;
	SonicWeldInfo[33].VertIndexes = Sonic_RightHandIndices_DC;
	SonicWeldInfo[33].ModelB = SONIC_OBJECTS[27];
	SonicWeldInfo[33].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightHandIndices_DC) / 2);
	SonicWeldInfo[33].WeldType = 2;

	SonicWeldInfo[34].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[34].ModelA = SONIC_OBJECTS[31];
	SonicWeldInfo[34].ModelB = SONIC_OBJECTS[32];
	SonicWeldInfo[34].anonymous_5 = 0;
	SonicWeldInfo[34].VertexBuffer = 0;
	SonicWeldInfo[34].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_LeftHandIndices_DC) / 2);
	SonicWeldInfo[34].VertIndexes = Sonic_LeftHandIndices_DC;
	SonicWeldInfo[34].WeldType = 2;

	SonicWeldInfo[35].BaseModel = SONIC_OBJECTS[22];
	SonicWeldInfo[35].ModelA = SONIC_OBJECTS[26];
	SonicWeldInfo[35].anonymous_5 = 0;
	SonicWeldInfo[35].VertexBuffer = 0;
	SonicWeldInfo[35].VertIndexes = Sonic_RightHandIndices_DC;
	SonicWeldInfo[35].VertexPairCount = (uint8_t)(LengthOfArray(Sonic_RightHandIndices_DC) / 2);
	SonicWeldInfo[35].ModelB = SONIC_OBJECTS[27];
	SonicWeldInfo[35].WeldType = 2;

	SonicWeldInfo[36].BaseModel = 0;
	SonicWeldInfo[36].ModelA = 0;
	SonicWeldInfo[36].ModelB = 0;
	SonicWeldInfo[36].VertexPairCount = 0;
	SonicWeldInfo[36].VertexBuffer = 0;
	SonicWeldInfo[36].VertIndexes = 0;
}

extern "C"
{
	__declspec(dllexport) void __cdecl Init(const char* path, const HelperFunctions& helperFunctions)
	{
		// Replace the pointing finger model that's used in cutscenes
		PointingFinger_Init(helperFunctions);

		// Replace Sonic on the Tornado
		Tornado_init(helperFunctions);

		//To make Super form work
		WriteData((NJS_TEXLIST**)0x55E65C, SSAura01);
		WriteData((NJS_TEXLIST**)0x55E751, SSAura01);
		WriteData((NJS_TEXLIST**)0x55E712, SSAura02);
		WriteData((NJS_TEXLIST**)0x55E7CD, SSWaterThing);
		WriteData((NJS_TEXLIST**)0x55F2B3, SSHomingTex1);
		WriteData((NJS_TEXLIST**)0x55F1D1, SSHomingTex1);
		WriteData((NJS_TEXLIST**)0x55F1DC, SSHomingTex2);
		WriteData((NJS_TEXLIST**)0x55F2BE, SSHomingTex2);
		WriteData((NJS_TEXLIST**)0x55F677, SSHomingTex2);
		WriteData((NJS_TEXLIST**)0x55F669, SSHomingTex3);
		SUPERSONIC_TEXLIST = SS_PVM;

		//Replace textures
		ReplacePVM("sonic", "sonichp");
		ReplacePVM("supersonic", "supersonichp");
		ReplacePVM("hypersonic", "hypersonichp");
	}

	__declspec(dllexport) ModInfo SADXModInfo = { ModLoaderVer };
}