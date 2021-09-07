#ifndef __S2_FUSION_SSI_GUID_UPDATER_HELPER_V1_0_2__2_SERIES_ONLY__H__
#define __S2_FUSION_SSI_GUID_UPDATER_HELPER_V1_0_2__2_SERIES_ONLY__H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__UPDATE_GUIDS_B_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__MASTER_OVERRIDE_GUID_PREFIX$_STRING_INPUT 0
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__MASTER_OVERRIDE_GUID_PREFIX$_STRING_MAX_LEN 8
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __MASTER_OVERRIDE_GUID_PREFIX$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__MASTER_OVERRIDE_GUID_PREFIX$_STRING_MAX_LEN );

#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__CONSOLE_RX$_BUFFER_INPUT 1
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__CONSOLE_RX$_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __CONSOLE_RX$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__CONSOLE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__UPDATE_GUID_FINISHED_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__UPDATE_GUID_STATUS_TXT$_STRING_OUTPUT 0
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__MASTER_GUID_PREFIX_TXT$_STRING_OUTPUT 1
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__RVI_FILE_NAME_TXT$_STRING_OUTPUT 2
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__RVI_FILE_FULL_PATH_TXT$_STRING_OUTPUT 3
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__CONSOLE_TX$_STRING_OUTPUT 4
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__CONSOLE_STATUS_TXT$_STRING_OUTPUT 5
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__ROOMNAME$_STRING_OUTPUT 6
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__ROOMGUID$_STRING_OUTPUT 7
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__SYMBOL_SLOT_GUIDS_TX$_STRING_OUTPUT 8


/*
* Direct Socket Variables
*/

#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__TCPCONSOLE_SOCKET 7
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__TCPCONSOLE_STRING_MAX_LEN 1000
START_SOCKET_DEFINITION( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __TCPCONSOLE )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, SocketRxBuf, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__TCPCONSOLE_STRING_MAX_LEN );
};



/*
* INTEGER_PARAMETER
*/
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__PROCESSORMODE_INTEGER_PARAMETER 10
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__PREFIXGUIDS_INTEGER_PARAMETER 11
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__THREESERIESAPPENDSLOTNUMBER_INTEGER_PARAMETER 12
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__FILESTORAGELOCATION$_STRING_PARAMETER 13
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__FILESTORAGELOCATION$_PARAM_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __FILESTORAGELOCATION$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__FILESTORAGELOCATION$_PARAM_MAX_LEN );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NGUIDOVERRIDE, 60 );;
CREATE_INTARRAY1D( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NROOMNAMEUPDATED, 60 );;
CREATE_INTARRAY1D( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NGUIDCOUNT, 60 );;


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SMASTERGUIDPREFIX$_STRING_MAX_LEN 12
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SMASTERGUIDPREFIX$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SMASTERGUIDPREFIX$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDMASTEROVERRIDEPREFIX$_STRING_MAX_LEN 12
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SGUIDMASTEROVERRIDEPREFIX$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDMASTEROVERRIDEPREFIX$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVITEMP$_STRING_MAX_LEN 5500
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVITEMP$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVITEMP$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVINEWFILETEMP$_STRING_MAX_LEN 5500
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVINEWFILETEMP$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVINEWFILETEMP$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFULLFILEPATH$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFULLFILEPATH$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFULLFILEPATH$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVINEWFULLFILEPATH$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVINEWFULLFILEPATH$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVINEWFULLFILEPATH$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFILENAME$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFILENAME$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFILENAME$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFILELOCATION$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFILELOCATION$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SRVIFILELOCATION$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDPREFIX$_ARRAY_NUM_ELEMS 60
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDPREFIX$_ARRAY_NUM_CHARS 12
CREATE_STRING_ARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SGUIDPREFIX$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDPREFIX$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SGUIDPREFIX$_ARRAY_NUM_CHARS );
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SOVERRIDEROOMNAME$_ARRAY_NUM_ELEMS 60
#define __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SOVERRIDEROOMNAME$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SOVERRIDEROOMNAME$, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SOVERRIDEROOMNAME$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only__G_SOVERRIDEROOMNAME$_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_NCOUNT;
   unsigned short __G_NDEBUG;
   unsigned short __G_NCONSOLESTEP;
   unsigned short __G_NFUSIONDATASTARTED;
   unsigned short __G_NFUSIONSYMBOLDATASTARTED;
   unsigned short __G_NFUSIONSYMBOLCOUNT;
   unsigned short __G_NSEMAPHORE;
   unsigned short __G_NSLOTNUMBER;
   unsigned short __G_NINSTANCEIDFOUND;
   unsigned short __G_ASSETNAMEFOUND;
   unsigned short __G_NTSIDRETRYCOUNT;
   unsigned short __G_NTSIDUPDATEBUSY;
   unsigned short __G_NINITIALRUN;
   unsigned short __G_NRVIFILECHANGED;
   unsigned short __G_NROOMNAMEOVERRIDEALLOWED;
   unsigned short __G_NMASTERGUIDOVERRIDE;
   DECLARE_INTARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NGUIDOVERRIDE );
   DECLARE_INTARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NROOMNAMEUPDATED );
   DECLARE_INTARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_NGUIDCOUNT );
   short __G_SNCONSOLECONNECTIONOK;
   short __G_SNCONSOLECONNECTIONSTATUS;
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SMASTERGUIDPREFIX$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SGUIDMASTEROVERRIDEPREFIX$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVITEMP$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVINEWFILETEMP$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFULLFILEPATH$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVINEWFULLFILEPATH$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFILENAME$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SRVIFILELOCATION$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SGUIDPREFIX$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __G_SOVERRIDEROOMNAME$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __MASTER_OVERRIDE_GUID_PREFIX$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __CONSOLE_RX$ );
   DECLARE_SOCKET( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __TCPCONSOLE );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_, __FILESTORAGELOCATION$ );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_SSI_GUID_Updater_Helper_v1_0_2__2_series_only_ )
{
};



#endif //__S2_FUSION_SSI_GUID_UPDATER_HELPER_V1_0_2__2_SERIES_ONLY__H__
