# CS_ARCH_AARCH64, None, None
# This regression test file is new. The option flags could not be determined.
# LLVM uses the following mattr = ['mattr=+cpa']
0x20,0x20,0x02,0x9a == addpt x0, x1, x2
0xff,0x23,0x02,0x9a == addpt sp, sp, x2
0x20,0x3c,0x02,0x9a == addpt x0, x1, x2, lsl #7
0xff,0x3f,0x02,0x9a == addpt sp, sp, x2, lsl #7
0x20,0x20,0x02,0xda == subpt x0, x1, x2
0xff,0x23,0x02,0xda == subpt sp, sp, x2
0x20,0x3c,0x02,0xda == subpt x0, x1, x2, lsl #7
0xff,0x3f,0x02,0xda == subpt sp, sp, x2, lsl #7
0x20,0x0c,0x62,0x9b == maddpt x0, x1, x2, x3
0x20,0x8c,0x62,0x9b == msubpt x0, x1, x2, x3