# CS_ARCH_ARM, CS_MODE_THUMB, None
0x85,0x46 = mov sp, r0
0x68,0x46 = mov r0, sp
0xed,0x46 = mov sp, sp
0x87,0x46 = mov pc, r0
0x78,0x46 = mov r0, pc
0xff,0x46 = mov pc, pc
0x4f,0xea,0x00,0x0d = mov.w sp, r0
0x4f,0xea,0x0d,0x00 = mov.w r0, sp