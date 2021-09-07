NAME	= examples

CC      = m68k-elf-gcc
CXX     = m68k-elf-g++
LD      = m68k-elf-ld

# IMPORTANT : Uncomment the three lines below that correspond to your board.
#
# These examples support the SBC5206, SBC5206e, SBC5307 and sbc5206eLite
# set the VARIANT environment var to pick your board type

ifeq "$(strip $(VARIANT))" ""
  VARIANT=sbc5307
endif

# pattern match the variant to set the compiler flags

CPU_VARIANT=MCF5307
NEW_INSTRUCTIONS=-mmac -mhwdiv
SIMINFO=siminfo2.elf
MACTEST=mactest.elf

# Environment variable CPUTYPE should be set to STANDARDFLASH or LARGEFLASH.  If none,
# we will use STANDARDFLASH.
# standardflash.ld - uses 2 Meg SIMPL+ size
# largeflash.ld - uses 1 Meg SIMPL+ size
# ifeq "$(CPUTYPE)" "STANDARDFLASH"
#  LINKER_SCRIPT=standardflash.ld
# else 
# ifeq "$(CPUTYPE)" "LARGEFLASH"
#   LINKER_SCRIPT=largeflash.ld
# else
#   LINKER_SCRIPT=standardflash.ld
# endif
# endif

# We're setting the LD file to have a very large target link size.  The tools will catch it since they
# will accurate read the SPL file size from the internal Program Header.  In this way, GNU won't stop
# with an error that we have trouble trapping.
LINKER_SCRIPT=bigram.ld

#PIC_FLAGS = -fpic
PIC_FLAGS =
CFLAGS = -m5200 $(PIC_FLAGS) -D$(CPU_VARIANT) $(NEW_INSTRUCTIONS) -w
#CFLAGS = -m5200 $(NEW_INSTRUCTIONS) -D$(CPU_VARIANT) -DVARIANT_$(VARIANT)
#LDFLAGS = -m5200 $(NEW_INSTRUCTIONS) -T$(LINKER_SCRIPT) -Wl,-Map=$(basename $@).map
LDFLAGS = -T$(LINKER_SCRIPT) -Map=$(basename $@).map -nostartup -nodefaultlibs

CFLAGS += -I../../include

ifeq "$(DEBUG)" "1"
  CFLAGS += -gdwarf -DDEBUG_MODE_FLAG=1
else
# Remove the omit frame pointer option so that we can trace through the stack
#  CFLAGS += -O4 -fomit-frame-pointer
  CFLAGS += -O3
  LDFLAGS += -s -n
endif

#__SPLS_INSERT_INCL_FILES__ INCLUDES = library.h typedefs.h FnctList.h SimplSig.h
INCLUDES = library.h typedefs.h FnctList.h SimplSig.h

#__SPLS_INSERT_OBJ_FILES__
OBJECTS = S2_String_Check.o S2_MPS_Text_Centering.o S2_Knob_Acceleration__Pkt_.o S2_DMPS_Text_Router_v1_0.o S2_DMPS_Installer_Tools_v1_13.o S2_APAD_Long_Text_Edit.o S2_UserProgCmd_Interface_v1_0.o S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.o S2_DMPS_System_Info_V1_0_2.o S2_Single_Line_Scroller_v1_2.o S2_IP_Address_Edit_with_Up_Down.o S2_IP_Address_Edit_Acceleration.o S2_DMPS_Analog_To_String_Conversion_v1_1.o S2_DMPS_String_to_Analog_Conversion_v1_1.o S2_Console_Processor_v3_.o S2_Sleep_timer_countdown.o S2_Fusion_SSI_Device_Usage_Helper_v1_1.o S2_Panasonic_PT_EZ370RU_Processor.o 

ifeq "$(DEBUG)" "1"
  OBJECTS += Library_inline.o 
endif


#__SPLS_INSERT_LINKOUTPUT_FILE__
all: _S2_CA3076_7_8.spl


crt0.o: crt0.s
	$(CC) $(CFLAGS) -x assembler-with-cpp -Wall $< -c -o $@

#__SPLS_INSERT_TARGET_FILES__ $(CC) $(CFLAGS) -Wall $< -c -o $@
S2_String_Check.o: S2_String_Check.c S2_String_Check.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_MPS_Text_Centering.o: S2_MPS_Text_Centering.c S2_MPS_Text_Centering.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Knob_Acceleration__Pkt_.o: S2_Knob_Acceleration__Pkt_.c S2_Knob_Acceleration__Pkt_.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_DMPS_Text_Router_v1_0.o: S2_DMPS_Text_Router_v1_0.c S2_DMPS_Text_Router_v1_0.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_DMPS_Installer_Tools_v1_13.o: S2_DMPS_Installer_Tools_v1_13.c S2_DMPS_Installer_Tools_v1_13.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_APAD_Long_Text_Edit.o: S2_APAD_Long_Text_Edit.c S2_APAD_Long_Text_Edit.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_UserProgCmd_Interface_v1_0.o: S2_UserProgCmd_Interface_v1_0.c S2_UserProgCmd_Interface_v1_0.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.o: S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.c S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_DMPS_System_Info_V1_0_2.o: S2_DMPS_System_Info_V1_0_2.c S2_DMPS_System_Info_V1_0_2.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Single_Line_Scroller_v1_2.o: S2_Single_Line_Scroller_v1_2.c S2_Single_Line_Scroller_v1_2.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_IP_Address_Edit_with_Up_Down.o: S2_IP_Address_Edit_with_Up_Down.c S2_IP_Address_Edit_with_Up_Down.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_IP_Address_Edit_Acceleration.o: S2_IP_Address_Edit_Acceleration.c S2_IP_Address_Edit_Acceleration.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_DMPS_Analog_To_String_Conversion_v1_1.o: S2_DMPS_Analog_To_String_Conversion_v1_1.c S2_DMPS_Analog_To_String_Conversion_v1_1.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_DMPS_String_to_Analog_Conversion_v1_1.o: S2_DMPS_String_to_Analog_Conversion_v1_1.c S2_DMPS_String_to_Analog_Conversion_v1_1.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Console_Processor_v3_.o: S2_Console_Processor_v3_.c S2_Console_Processor_v3_.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Sleep_timer_countdown.o: S2_Sleep_timer_countdown.c S2_Sleep_timer_countdown.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Fusion_SSI_Device_Usage_Helper_v1_1.o: S2_Fusion_SSI_Device_Usage_Helper_v1_1.c S2_Fusion_SSI_Device_Usage_Helper_v1_1.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
S2_Panasonic_PT_EZ370RU_Processor.o: S2_Panasonic_PT_EZ370RU_Processor.c S2_Panasonic_PT_EZ370RU_Processor.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@


globals.o: globals.c globals.h
	$(CC) $(CFLAGS) -Wall $< -c -o $@

#this should be made a library archive
library.o: library.c library.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@

Library_inline.o: library_inline.c library_inline.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
	
#__SPLS_INSERT_LINK_CMD__ $(OBJECTS) globals.o library.o
_S2_CA3076_7_8.spl: 	$(OBJECTS) globals.o library.o
	$(LD) $(LDFLAGS) -o $@ $(OBJECTS) globals.o library.o
  ifeq "$(DEBUG)" "1"
	  cp $@ $@.elf
  endif
	AddHeader $@ -d:6

#__SPLS_INSERT_HDR_FILES__

