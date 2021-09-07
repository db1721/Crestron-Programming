/*STARTUP(crt0.o) */
OUTPUT_ARCH(m68k)
/* Uncomment this if you want srecords. This is needed for a.out
 * if you plan to use GDB.
OUTPUT_FORMAT(srec)
 */

SEARCH_DIR(.)
/* GROUP(-ldbug -lc -lgcc -lm -lstdc++) */
__DYNAMIC  =  0;

/*
 * Setup the memory map of the Arnewsh SBC5307
 * stack grows down from high memory.
 *
 * The memory map look like this:
 * +--------------------+ <- low memory
 * | .text              |
 * |        _etext      |
 * |        ctor list   | the ctor and dtor lists are for
 * |        dtor list   | C++ support
 * +--------------------+
 * | .data              | initialized data goes here
 * |        _edata      |
 * +--------------------+
 * | .bss               |
 * |        __bss_start | start of bss, cleared by crt0
 * |        _end        | start of heap, used by sbrk()
 * +--------------------+
 * .                    .
 * .                    .
 * .                    .
 * |        __stack     | top of stack
 * +--------------------+
 */
/* Now Simpl Plus modules will be put at the start of ram.
 */
/*
*  Make it 5 megs of RAM - very large, but the tools will be used to catch oveflow.  We'll make it
*  Huge becuase otherwise GNU linker errors out if our SIMPL+ exceeds the Length (HPN 12/20/2007)
*/

MEMORY
{
  ram (rwx) : ORIGIN = 0x80000000, LENGTH = 0x0500000
}

/*
 * allocate the stack to be at the top of memory, since the stack
 * grows down
 */

PROVIDE (__stack = 0x400000);

/*
 * Initalize some symbols to be zero so we can reference them in the
 * crt0 without core dumping. These functions are all optional, but
 * we do this so we can have our crt0 always use them if they exist.
 * This is so BSPs work better when using the crt0 installed with gcc.
 * We have to initalize them twice, so we cover a.out (which prepends
 * an underscore) and coff object file formats.
 */
PROVIDE (hardware_init_hook = 0);
PROVIDE (_hardware_init_hook = 0);
PROVIDE (software_init_hook = 0);
PROVIDE (_software_init_hook = 0);
/*
 * stick everything in ram (of course)
 */
SECTIONS
{
  .text :
  {
    *(.text)
    . = ALIGN (16);

    *(.eh_frame)
    . = ALIGN (16);

    *(.gnu.linkonce.t.*)

    . = ALIGN(0x4);
     __CTOR_LIST__ = .;
    ___CTOR_LIST__ = .;
    LONG((__CTOR_END__ - __CTOR_LIST__) / 4 - 2)
    *(.ctors)
    LONG(0)
    __CTOR_END__ = .;
    __DTOR_LIST__ = .;
    ___DTOR_LIST__ = .;
    LONG((__DTOR_END__ - __DTOR_LIST__) / 4 - 2)
    *(.dtors)
     LONG(0)
    __DTOR_END__ = .;
    *(.rodata)
    *(.gcc_except_table)

    . = ALIGN(0x2);
    __INIT_SECTION__ = . ;
    LONG (0x4e560000)	/* linkw %fp,#0 */
    *(.init)
    SHORT (0x4e5e)	/* unlk %fp */
    SHORT (0x4e75)	/* rts */

    __FINI_SECTION__ = . ;
    LONG (0x4e560000)	/* linkw %fp,#0 */
    *(.fini)
    SHORT (0x4e5e)	/* unlk %fp */
    SHORT (0x4e75)	/* rts */

    *(.lit)
    . = ALIGN(16);
    _etext = .;
    etext = .;
  } > ram

  .data :
  {
    copy_start = .;
    *(.shdata)
    *(.data)
    *(.gnu.linkonce.d.*)
    . = ALIGN (16);
    _edata = .;
    copy_end = .;
  } > ram

  .got :
  {
    *(.got.plt)
    *(.got)
/*    gotsize = . - copy_end;  */
  } > ram

  EntryList :
  {
    *(EntryList)
    . = ALIGN ( 4);
  } > ram

  FunctionList :
  {
    *(FunctionList)
    . = ALIGN ( 4);
  } > ram

  .bss :
  {
    . = ALIGN(0x4);
    __bss_start = . ;
    *(.shbss)
    *(.bss)
    *(COMMON)
    _end =  ALIGN (0x8);
    __end = _end;
  } > ram

  .stab 0 (NOLOAD) :
  {
    *(.stab)
  }

  .stabstr 0 (NOLOAD) :
  {
    *(.stabstr)
  }
  /* DWARF debug sections.
     Symbols in the DWARF debugging sections are relative to the beginning
     of the section so we begin them at 0.  */
  /* DWARF 1 */
  .debug          0 : { *(.debug) }
  .line           0 : { *(.line) }
  /* GNU DWARF 1 extensions */
  .debug_srcinfo  0 : { *(.debug_srcinfo) }
  .debug_sfnames  0 : { *(.debug_sfnames) }
  /* DWARF 1.1 and DWARF 2 */
  .debug_aranges  0 : { *(.debug_aranges) }
  .debug_pubnames 0 : { *(.debug_pubnames) }
  /* DWARF 2 */
  .debug_info     0 : { *(.debug_info) }
  .debug_abbrev   0 : { *(.debug_abbrev) }
  .debug_line     0 : { *(.debug_line) }
  .debug_frame    0 : { *(.debug_frame) }
  .debug_str      0 : { *(.debug_str) }
  .debug_loc      0 : { *(.debug_loc) }
  .debug_macinfo  0 : { *(.debug_macinfo) }
  /* SGI/MIPS DWARF 2 extensions */
  .debug_weaknames 0 : { *(.debug_weaknames) }
  .debug_funcnames 0 : { *(.debug_funcnames) }
  .debug_typenames 0 : { *(.debug_typenames) }
  .debug_varnames  0 : { *(.debug_varnames) }
  /* These must appear regardless of  .  */
}
