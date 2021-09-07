using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using Crestron.RAD.DeviceTypes.Display;
using Crestron.RAD.DriverResources;
using Crestron.RAD.Common.Transports;
using Crestron.RAD.Common.Interfaces;
using Crestron.RAD.Common.Helpers;
using Crestron.RAD.Common.Enums;
using Crestron.RAD.Common;
using Crestron.RAD.Common.ModelFile;
using Crestron.RAD.Common.StandardCommands;
using Crestron.RAD.Common.BasicDriver;
using Crestron.RAD.DeviceTypes.PoolController;
using PreEmptive.Dotfuscator.ObfuscationAttributes;
using Crestron.RAD.Common.FactoryInterfaces;
using Crestron.RAD.Common.BasicDriver.Ramping;
using Crestron.RAD.Common.Logging;
using Crestron.RAD.Common.Events;
using Crestron.RAD.Common.Attributes;
using Crestron.RAD.Common.BasicDriver.FakeFeedback;
using Crestron.RAD.Common.ExtensionMethods;
using Crestron.RAD.SystemManager;

namespace CrestronModule_CRESTRONCERTIFIEDDRIVERSVIDEODISPLAYMODULE_V1_11
{
    public class CrestronModuleClass_CRESTRONCERTIFIEDDRIVERSVIDEODISPLAYMODULE_V1_11 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput CECINITIALIZE;
        Crestron.Logos.SplusObjects.StringInput FILE;
        Crestron.Logos.SplusObjects.BufferInput RX;
        Crestron.Logos.SplusObjects.StringInput IPADDRESS;
        Crestron.Logos.SplusObjects.AnalogInput PORT;
        Crestron.Logos.SplusObjects.StringOutput TX;
        Crestron.Logos.SplusObjects.StringOutput PACKETTX;
        Crestron.Logos.SplusObjects.DigitalOutput DRIVERLOADED;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTPORT;
        Crestron.Logos.SplusObjects.DigitalOutput REBOOTREQUIRED;
        Crestron.Logos.SplusObjects.AnalogInput ID;
        Crestron.Logos.SplusObjects.StringOutput SDKVERSION;
        Crestron.Logos.SplusObjects.StringOutput MANUFACTURER;
        Crestron.Logos.SplusObjects.StringOutput BASEMODEL;
        Crestron.Logos.SplusObjects.StringOutput SUPPORTEDMODELS;
        Crestron.Logos.SplusObjects.StringOutput SUPPORTEDSERIES;
        Crestron.Logos.SplusObjects.StringOutput DESCRIPTION;
        Crestron.Logos.SplusObjects.StringOutput DRIVERVERSION;
        Crestron.Logos.SplusObjects.StringOutput DRIVERVERSIONDATE;
        Crestron.Logos.SplusObjects.StringOutput GUID;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSFEEDBACK;
        Crestron.Logos.SplusObjects.StringInput USERNAME;
        Crestron.Logos.SplusObjects.StringInput PASSWORD;
        Crestron.Logos.SplusObjects.AnalogOutput AUTHENTICATIONSTATUS;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSUSERNAME;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPASSWORD;
        Crestron.Logos.SplusObjects.DigitalOutput AUTHENTICATIONISREQUIRED;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPOWER_F;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDISCRETEPOWER;
        Crestron.Logos.SplusObjects.DigitalInput POWERON;
        Crestron.Logos.SplusObjects.DigitalInput POWEROFF;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSTOGGLEPOWER;
        Crestron.Logos.SplusObjects.DigitalInput POWERTOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSWARMUPTIME;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSCOOLDOWNTIME;
        Crestron.Logos.SplusObjects.AnalogInput WARMUPTIME;
        Crestron.Logos.SplusObjects.AnalogInput COOLDOWNTIME;
        Crestron.Logos.SplusObjects.DigitalOutput WARMINGUP;
        Crestron.Logos.SplusObjects.DigitalOutput COOLINGDOWN;
        Crestron.Logos.SplusObjects.AnalogOutput WARMUPTIME_F;
        Crestron.Logos.SplusObjects.AnalogOutput COOLDOWNTIME_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSINPUT_F;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIVEINPUTTYPE;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEINPUTCONNECTOR;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEINPUTDESCRIPTION;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEINPUTFRIENDLYNAME;
        Crestron.Logos.SplusObjects.AnalogOutput NUMBEROFINPUTS;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSETINPUT;
        Crestron.Logos.SplusObjects.AnalogInput SETINPUT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARROWKEYS;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARROWUP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARROWDOWN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARROWLEFT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARROWRIGHT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSELECT;
        Crestron.Logos.SplusObjects.DigitalInput UPARROW;
        Crestron.Logos.SplusObjects.DigitalInput DOWNARROW;
        Crestron.Logos.SplusObjects.DigitalInput LEFTARROW;
        Crestron.Logos.SplusObjects.DigitalInput RIGHTARROW;
        Crestron.Logos.SplusObjects.DigitalInput SELECT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSCLEAR;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSEXIT;
        Crestron.Logos.SplusObjects.DigitalInput EXIT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSHOME;
        Crestron.Logos.SplusObjects.DigitalInput HOME;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSMENU;
        Crestron.Logos.SplusObjects.DigitalInput MENU;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSEARCH;
        Crestron.Logos.SplusObjects.DigitalInput SEARCH;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSYOUTUBE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSYOUTUBETV;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSNETFLIX;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSHULU;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDIRECTVNOW;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSAMAZONVIDEO;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPLAYSTATIONVUE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSLINGTV;
        Crestron.Logos.SplusObjects.DigitalInput YOUTUBE;
        Crestron.Logos.SplusObjects.DigitalInput YOUTUBETV;
        Crestron.Logos.SplusObjects.DigitalInput NETFLIX;
        Crestron.Logos.SplusObjects.DigitalInput HULU;
        Crestron.Logos.SplusObjects.DigitalInput DIRECTVNOW;
        Crestron.Logos.SplusObjects.DigitalInput AMAZONVIDEO;
        Crestron.Logos.SplusObjects.DigitalInput PLAYSTATIONVUE;
        Crestron.Logos.SplusObjects.DigitalInput SLINGTV;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSFORWARDSCAN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSREVERSESCAN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPLAY;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPAUSE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSTOP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSFORWARDSKIP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSREVERSESKIP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSREPEAT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSRETURN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSBACK;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPLAYPAUSE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSOPTIONS;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSINFO;
        Crestron.Logos.SplusObjects.DigitalInput FORWARDSCAN;
        Crestron.Logos.SplusObjects.DigitalInput REVERSESCAN;
        Crestron.Logos.SplusObjects.DigitalInput PLAY;
        Crestron.Logos.SplusObjects.DigitalInput PAUSE;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.DigitalInput FORWARDSKIP;
        Crestron.Logos.SplusObjects.DigitalInput REVERSESKIP;
        Crestron.Logos.SplusObjects.DigitalInput REPEAT;
        Crestron.Logos.SplusObjects.DigitalInput RETURNCOMMAND;
        Crestron.Logos.SplusObjects.DigitalInput BACK;
        Crestron.Logos.SplusObjects.DigitalInput PLAYPAUSE;
        Crestron.Logos.SplusObjects.DigitalInput OPTIONS;
        Crestron.Logos.SplusObjects.DigitalInput INFO;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSVOLUME_F;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSMUTE_F;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDISCRETEMUTE;
        Crestron.Logos.SplusObjects.DigitalInput MUTEON;
        Crestron.Logos.SplusObjects.DigitalInput MUTEOFF;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSMUTE;
        Crestron.Logos.SplusObjects.DigitalInput MUTETOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSETVOLUME;
        Crestron.Logos.SplusObjects.AnalogInput SETVOLUME;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSCHANGEVOLUME;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput SETVOLUMEUP;
        Crestron.Logos.SplusObjects.DigitalInput SETVOLUMEDOWN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSVIDEOMUTE_F;
        Crestron.Logos.SplusObjects.DigitalOutput VIDEOMUTE_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDISCRETEVIDEOMUTE;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTEON;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTEOFF;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSTOGGLEVIDEOMUTE;
        Crestron.Logos.SplusObjects.DigitalInput VIDEOMUTETOGGLE;
        Crestron.Logos.SplusObjects.StringInput CUSTOM_COMMAND;
        Crestron.Logos.SplusObjects.StringInput CUSTOM_COMMAND_BY_NAME;
        Crestron.Logos.SplusObjects.StringInput CUSTOM_COMMAND_BY_VALUE;
        Crestron.Logos.SplusObjects.DigitalInput ENABLERXOUT;
        Crestron.Logos.SplusObjects.StringOutput RXOUT;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECTION_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDISCONNECT;
        Crestron.Logos.SplusObjects.DigitalInput DISCONNECT;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSRECONNECT;
        Crestron.Logos.SplusObjects.DigitalInput RECONNECT;
        Crestron.Logos.SplusObjects.DigitalInput CONNECT;
        Crestron.Logos.SplusObjects.DigitalInput ENABLELOGGING;
        Crestron.Logos.SplusObjects.DigitalInput ENABLETXDEBUG;
        Crestron.Logos.SplusObjects.DigitalInput ENABLERXDEBUG;
        Crestron.Logos.SplusObjects.StringOutput LOG;
        Crestron.Logos.SplusObjects.StringInput SELECTMEDIASERVICEBYID;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSMEDIASERVICES;
        Crestron.Logos.SplusObjects.DigitalOutput HASDIRECTACCESSTOSERVICES;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSACTIVEMEDIASERVICEFEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput ACTIVEMEDIASERVICE_ISSELECTABLE;
        Crestron.Logos.SplusObjects.DigitalOutput ACTIVEMEDIASERVICE_ISBRANDED;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEMEDIASERVICE_FRIENDLYNAME;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIVEMEDIASERVICE_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEMEDIASERVICE_SMALLIMAGEURL;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEMEDIASERVICE_MEDIUMIMAGEURL;
        Crestron.Logos.SplusObjects.StringOutput ACTIVEMEDIASERVICE_LARGEIMAGEURL;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDVR;
        Crestron.Logos.SplusObjects.DigitalInput DVR;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSLIVE;
        Crestron.Logos.SplusObjects.DigitalInput LIVE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSRECORD;
        Crestron.Logos.SplusObjects.DigitalInput RECORD;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSPEEDSLOW;
        Crestron.Logos.SplusObjects.DigitalInput SPEEDSLOW;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSTHUMBSUP;
        Crestron.Logos.SplusObjects.DigitalInput THUMBSUP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSTHUMBSDOWN;
        Crestron.Logos.SplusObjects.DigitalInput THUMBSDOWN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSCHANNELFEEDBACK;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_F;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSCHANGECHANNEL;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELDOWN;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELUP;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSSETCHANNEL;
        Crestron.Logos.SplusObjects.StringInput SETCHANNEL;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSGUIDE;
        Crestron.Logos.SplusObjects.DigitalInput GUIDE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPAGECHANGE;
        Crestron.Logos.SplusObjects.DigitalInput PAGEDOWN;
        Crestron.Logos.SplusObjects.DigitalInput PAGEUP;
        Crestron.Logos.SplusObjects.DigitalInput SETCHANNEL_SENDENTERAFTERSEQUENCE;
        Crestron.Logos.SplusObjects.AnalogInput SETCHANNEL_TIMEBETWEENSEQUENCESINMS;
        Crestron.Logos.SplusObjects.AnalogInput SETCHANNEL_TIMEBETWEENCOMMANDSINMS;
        Crestron.Logos.SplusObjects.AnalogInput SETCHANNEL_IRCOMMANDDURATIONINMS;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSKEYPADNUMBER;
        Crestron.Logos.SplusObjects.DigitalInput _0;
        Crestron.Logos.SplusObjects.DigitalInput _1;
        Crestron.Logos.SplusObjects.DigitalInput _2;
        Crestron.Logos.SplusObjects.DigitalInput _3;
        Crestron.Logos.SplusObjects.DigitalInput _4;
        Crestron.Logos.SplusObjects.DigitalInput _5;
        Crestron.Logos.SplusObjects.DigitalInput _6;
        Crestron.Logos.SplusObjects.DigitalInput _7;
        Crestron.Logos.SplusObjects.DigitalInput _8;
        Crestron.Logos.SplusObjects.DigitalInput _9;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSKEYPADPOUND;
        Crestron.Logos.SplusObjects.DigitalInput KEYPADPOUND;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSKEYPADASTERISK;
        Crestron.Logos.SplusObjects.DigitalInput KEYPADASTERISK;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSKEYPADBACKSPACE;
        Crestron.Logos.SplusObjects.DigitalInput KEYPADBACKSPACE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSPERIOD;
        Crestron.Logos.SplusObjects.DigitalInput PERIOD;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDASH;
        Crestron.Logos.SplusObjects.DigitalInput DASH;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSENTER;
        Crestron.Logos.SplusObjects.DigitalInput ENTER;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARTWORKMODE;
        Crestron.Logos.SplusObjects.DigitalInput ARTWORKON;
        Crestron.Logos.SplusObjects.DigitalInput ARTWORKOFF;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSARWORKMODEONPOWEROFF;
        Crestron.Logos.SplusObjects.DigitalInput ENABLEARTWORKONPOWEROFF;
        Crestron.Logos.SplusObjects.DigitalInput DISABLEARTWORKONPOWEROFF;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSDISPLAYMODES;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSA;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSB;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSC;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSD;
        Crestron.Logos.SplusObjects.DigitalInput A;
        Crestron.Logos.SplusObjects.DigitalInput B;
        Crestron.Logos.SplusObjects.DigitalInput C;
        Crestron.Logos.SplusObjects.DigitalInput D;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSRED;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSGREEN;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSBLUE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSYELLOW;
        Crestron.Logos.SplusObjects.DigitalInput RED;
        Crestron.Logos.SplusObjects.DigitalInput GREEN;
        Crestron.Logos.SplusObjects.DigitalInput BLUE;
        Crestron.Logos.SplusObjects.DigitalInput YELLOW;
        Crestron.Logos.SplusObjects.DigitalInput CMDGROUPUP;
        Crestron.Logos.SplusObjects.DigitalInput CMDGROUPDOWN;
        Crestron.Logos.SplusObjects.AnalogOutput NUMCUSTOMCOMMANDS;
        Crestron.Logos.SplusObjects.AnalogOutput NUMPAGES;
        Crestron.Logos.SplusObjects.AnalogOutput CUSTOMCOMMANDPAGENUM;
        Crestron.Logos.SplusObjects.AnalogOutput NUMMEDIASERVICEPAGES;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENTMEDIASERVICEPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput SETNUMITEMS;
        Crestron.Logos.SplusObjects.DigitalInput NEXTMEDIASERVICEPAGE;
        Crestron.Logos.SplusObjects.DigitalInput PREVMEDIASERVICEPAGE;
        Crestron.Logos.SplusObjects.DigitalOutput SUPPORTSLAMPHOURS;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> LAMPHOURS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TRIGGERCOMMAND;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> COMMANDEXISTS;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> COMMANDNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> COMMANDNAMEOUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> USERATTRIBUTE_SENDITIN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> USERATTRIBUTE_STRINGVALUE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> USERATTRIBUTE_ANALOGVALUE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> USERATTRIBUTE_DIGITALVALUE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> USERATTRIBUTE_ISAVAILABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> USERATTRIBUTE_ISPERSISTENT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> USERATTRIBUTE_LABEL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> USERATTRIBUTE_DESCRIPTION;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> USERATTRIBUTE_TYPE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> USERATTRIBUTE_DATATYPE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> USERATTRIBUTE_REQUIREDFORCONNECTION;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SELECTMEDIASERVICE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> MEDIASERVICE_ISAVAILABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> MEDIASERVICE_ISSELECTABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> MEDIASERVICE_ISBRANDED;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MEDIASERVICE_FRIENDLYNAME;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MEDIASERVICE_STATE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MEDIASERVICE_SUBSCRIPTIONSTATE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MEDIASERVICE_SMALLIMAGEURL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MEDIASERVICE_MEDIUMIMAGEURL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MEDIASERVICE_LARGEIMAGEURL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SELECTDISPLAYMODE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DISPLAYMODE_ISAVAILABLE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYMODE_FRIENDLYNAME;
        StringParameter UNIQUEID;
        StringParameter TRANSPORT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYINPUTDESCRIPTION;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYINPUTCONNECTOR;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYINPUTFRIENDLYNAME;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> DISPLAYINPUTTYPE;
        CrestronString _DRIVERFILENAME;
        ushort _INITILIZATIONCOMPLETE = 0;
        Crestron.RAD.DeviceTypes.Display.SimplDisplay SIMPLSHARPCOMPONENT;
        Crestron.RAD.SystemManager.SMWrapper SYSTEMMODULE;
        MEDIASERVICESTRUC [] CCD_MEDIASERVICES;
        CrestronString [] CMDNAMEIN;
        ushort MEDIASERVICENUMPAGES = 0;
        ushort MEDIASERVICECURRENTPAGE = 0;
        ushort MEDIASERVICECOUNT = 0;
        ushort ISETVOLUME = 0;
        private ushort CALCPAGENUMBERS (  SplusExecutionContext __context__, ushort NUMSERVICES ) 
            { 
            ushort PAGES = 0;
            
            
            __context__.SourceCodeLine = 404;
            PAGES = (ushort) ( (NUMSERVICES / 25) ) ; 
            __context__.SourceCodeLine = 405;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PAGES > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 407;
                PAGES = (ushort) ( (PAGES + 1) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 411;
                PAGES = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 413;
            MEDIASERVICENUMPAGES = (ushort) ( PAGES ) ; 
            __context__.SourceCodeLine = 414;
            return (ushort)( PAGES) ; 
            
            }
            
        private void OUTPUTMEDIASERVICESPAGE (  SplusExecutionContext __context__, ushort PAGENUM , ushort NUMSERVICES ) 
            { 
            ushort PAGEINDEX = 0;
            
            ushort LOOPEND = 0;
            
            ushort OFFSET = 0;
            
            ushort PAGEMOD = 0;
            
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 426;
            PAGEINDEX = (ushort) ( ((PAGENUM * 25) - 24) ) ; 
            __context__.SourceCodeLine = 427;
            OFFSET = (ushort) ( ((PAGEINDEX - PAGEINDEX) + 1) ) ; 
            __context__.SourceCodeLine = 428;
            LOOPEND = (ushort) ( (PAGEINDEX + 24) ) ; 
            __context__.SourceCodeLine = 429;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( PAGEINDEX ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)LOOPEND; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 431;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CCD_MEDIASERVICES[ I ].FRIENDLYNAME == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 433;
                    PAGEMOD = (ushort) ( Mod( NUMSERVICES , 25 ) ) ; 
                    __context__.SourceCodeLine = 434;
                    SETNUMITEMS  .Value = (ushort) ( PAGEMOD ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 436;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I == (PAGEINDEX + 24)))  ) ) 
                        { 
                        __context__.SourceCodeLine = 438;
                        PAGEMOD = (ushort) ( 25 ) ; 
                        __context__.SourceCodeLine = 439;
                        SETNUMITEMS  .Value = (ushort) ( PAGEMOD ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 441;
                MEDIASERVICE_ISAVAILABLE [ ((I - PAGEINDEX) + 1)]  .Value = (ushort) ( CCD_MEDIASERVICES[ I ].ISAVAILABLE ) ; 
                __context__.SourceCodeLine = 442;
                MEDIASERVICE_ISSELECTABLE [ ((I - PAGEINDEX) + 1)]  .Value = (ushort) ( CCD_MEDIASERVICES[ I ].ISSELECTABLE ) ; 
                __context__.SourceCodeLine = 443;
                MEDIASERVICE_ISBRANDED [ ((I - PAGEINDEX) + 1)]  .Value = (ushort) ( CCD_MEDIASERVICES[ I ].ISBRANDED ) ; 
                __context__.SourceCodeLine = 444;
                MEDIASERVICE_FRIENDLYNAME [ ((I - PAGEINDEX) + 1)]  .UpdateValue ( CCD_MEDIASERVICES [ I] . FRIENDLYNAME  ) ; 
                __context__.SourceCodeLine = 445;
                MEDIASERVICE_STATE [ ((I - PAGEINDEX) + 1)]  .Value = (ushort) ( CCD_MEDIASERVICES[ I ].STATE ) ; 
                __context__.SourceCodeLine = 446;
                MEDIASERVICE_SUBSCRIPTIONSTATE [ ((I - PAGEINDEX) + 1)]  .Value = (ushort) ( CCD_MEDIASERVICES[ I ].SUBSCRIPTIONSTATE ) ; 
                __context__.SourceCodeLine = 447;
                MEDIASERVICE_SMALLIMAGEURL [ ((I - PAGEINDEX) + 1)]  .UpdateValue ( CCD_MEDIASERVICES [ I] . SMALLIMAGEURL  ) ; 
                __context__.SourceCodeLine = 448;
                MEDIASERVICE_MEDIUMIMAGEURL [ ((I - PAGEINDEX) + 1)]  .UpdateValue ( CCD_MEDIASERVICES [ I] . MEDIUMIMAGEURL  ) ; 
                __context__.SourceCodeLine = 449;
                MEDIASERVICE_LARGEIMAGEURL [ ((I - PAGEINDEX) + 1)]  .UpdateValue ( CCD_MEDIASERVICES [ I] . LARGEIMAGEURL  ) ; 
                __context__.SourceCodeLine = 429;
                } 
            
            
            }
            
        object USERNAME_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 456;
                SIMPLSHARPCOMPONENT . SimplOverrideUsername ( USERNAME .ToString()) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PASSWORD_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 461;
            SIMPLSHARPCOMPONENT . SimplOverridePassword ( PASSWORD .ToString()) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POWERTOGGLE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 467;
        SIMPLSHARPCOMPONENT . SimplPowerToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERON_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 471;
        SIMPLSHARPCOMPONENT . SimplPowerOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWEROFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 475;
        SIMPLSHARPCOMPONENT . SimplPowerOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERTOGGLE_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 479;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERON_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 483;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWEROFF_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 487;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WARMUPTIME_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 491;
        SIMPLSHARPCOMPONENT . SimplWarmUpTime ( (ushort)( WARMUPTIME  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOLDOWNTIME_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 496;
        SIMPLSHARPCOMPONENT . SimplCoolDownTime ( (ushort)( COOLDOWNTIME  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETINPUT_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 502;
        SIMPLSHARPCOMPONENT . SimplSetInputSource ( (uint)( SETINPUT  .UintValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEUP_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 508;
        SIMPLSHARPCOMPONENT . VolUpHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEDOWN_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 512;
        SIMPLSHARPCOMPONENT . VolDownHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTETOGGLE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 516;
        SIMPLSHARPCOMPONENT . SimplMute ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEON_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 520;
        SIMPLSHARPCOMPONENT . SimplMuteOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEOFF_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 524;
        SIMPLSHARPCOMPONENT . SimplMuteOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEUP_OnRelease_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 528;
        SIMPLSHARPCOMPONENT . VolUpRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEDOWN_OnRelease_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 533;
        SIMPLSHARPCOMPONENT . VolDownRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTETOGGLE_OnRelease_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 537;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEON_OnRelease_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 541;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEOFF_OnRelease_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 545;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETVOLUMEUP_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 552;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISETVOLUME < 100 ))  ) ) 
            { 
            __context__.SourceCodeLine = 554;
            ISETVOLUME = (ushort) ( (ISETVOLUME + 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 558;
            ISETVOLUME = (ushort) ( 100 ) ; 
            } 
        
        __context__.SourceCodeLine = 560;
        SIMPLSHARPCOMPONENT . SimplMuteOff ( ) ; 
        __context__.SourceCodeLine = 561;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        __context__.SourceCodeLine = 562;
        SIMPLSHARPCOMPONENT . SimplSetVolume ( (uint)( ISETVOLUME )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETVOLUMEDOWN_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 567;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ISETVOLUME > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 569;
            ISETVOLUME = (ushort) ( (ISETVOLUME - 1) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 573;
            ISETVOLUME = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 575;
        SIMPLSHARPCOMPONENT . SimplMuteOff ( ) ; 
        __context__.SourceCodeLine = 576;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        __context__.SourceCodeLine = 577;
        SIMPLSHARPCOMPONENT . SimplSetVolume ( (uint)( ISETVOLUME )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETVOLUME_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 582;
        ISETVOLUME = (ushort) ( SETVOLUME  .UshortValue ) ; 
        __context__.SourceCodeLine = 583;
        SIMPLSHARPCOMPONENT . SimplSetVolume ( (uint)( ISETVOLUME )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXOUT_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 589;
        SIMPLSHARPCOMPONENT . SimplEnableRxOut ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXOUT_OnRelease_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 594;
        SIMPLSHARPCOMPONENT . SimplDisableRxOut ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CUSTOM_COMMAND_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 600;
        SIMPLSHARPCOMPONENT . SimplSendCustomCommand ( CUSTOM_COMMAND .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CUSTOM_COMMAND_BY_NAME_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 605;
        if ( Functions.TestForTrue  ( ( SIMPLSHARPCOMPONENT.SimplCustomCommandExists( CUSTOM_COMMAND_BY_NAME .ToString() ))  ) ) 
            { 
            __context__.SourceCodeLine = 607;
            SIMPLSHARPCOMPONENT . SimplSendCustomCommandByName ( CUSTOM_COMMAND_BY_NAME .ToString()) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CUSTOM_COMMAND_BY_VALUE_OnChange_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 613;
        SIMPLSHARPCOMPONENT . SimplSendCustomCommandByValue ( CUSTOM_COMMAND_BY_VALUE .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECONNECT_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 619;
        SIMPLSHARPCOMPONENT . SimplReconnect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCONNECT_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 624;
        SIMPLSHARPCOMPONENT . SimplDisconnect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECT_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 629;
        SIMPLSHARPCOMPONENT . SimplConnect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLELOGGING_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 635;
        SIMPLSHARPCOMPONENT . SimplEnableLogging ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLELOGGING_OnRelease_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 639;
        SIMPLSHARPCOMPONENT . SimplDisableLogging ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLETXDEBUG_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 643;
        SIMPLSHARPCOMPONENT . SimplEnableTxDebug ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLETXDEBUG_OnRelease_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 647;
        SIMPLSHARPCOMPONENT . SimplDisableTxDebug ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXDEBUG_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 651;
        SIMPLSHARPCOMPONENT . SimplEnableRxDebug ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXDEBUG_OnRelease_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 655;
        SIMPLSHARPCOMPONENT . SimplDisableRxDebug ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXOUT_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 659;
        SIMPLSHARPCOMPONENT . SimplEnableRxOut ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLERXOUT_OnRelease_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 663;
        SIMPLSHARPCOMPONENT . SimplDisableRxOut ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRIGGERCOMMAND_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDX = 0;
        
        
        __context__.SourceCodeLine = 671;
        IDX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 673;
        SIMPLSHARPCOMPONENT . SimplTriggerCustomCommandPress ( CMDNAMEIN[ (IDX - 1) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRIGGERCOMMAND_OnRelease_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDX = 0;
        
        
        __context__.SourceCodeLine = 679;
        IDX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 681;
        SIMPLSHARPCOMPONENT . SimplTriggerCustomCommandRelease ( CMDNAMEIN[ (IDX - 1) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CMDGROUPUP_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 687;
        SIMPLSHARPCOMPONENT . SimplCustomCommandPageUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CMDGROUPDOWN_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 692;
        SIMPLSHARPCOMPONENT . SimplCustomCommandPageDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEON_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 698;
        SIMPLSHARPCOMPONENT . SimplVideoMuteOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEON_OnRelease_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 703;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEOFF_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 708;
        SIMPLSHARPCOMPONENT . SimplVideoMuteOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTEOFF_OnRelease_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 713;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTETOGGLE_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 718;
        SIMPLSHARPCOMPONENT . SimplVideoMuteToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VIDEOMUTETOGGLE_OnRelease_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 723;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPARROW_OnPush_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 730;
        SIMPLSHARPCOMPONENT . SimplArrowKey ( "Up") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOWNARROW_OnPush_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 735;
        SIMPLSHARPCOMPONENT . SimplArrowKey ( "Down") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LEFTARROW_OnPush_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 740;
        SIMPLSHARPCOMPONENT . SimplArrowKey ( "Left") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RIGHTARROW_OnPush_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 745;
        SIMPLSHARPCOMPONENT . SimplArrowKey ( "Right") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_OnPush_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 750;
        SIMPLSHARPCOMPONENT . SimplSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_OnPush_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 755;
        SIMPLSHARPCOMPONENT . SimplClear ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EXIT_OnPush_56 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 760;
        SIMPLSHARPCOMPONENT . SimplExit ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_OnPush_57 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 765;
        SIMPLSHARPCOMPONENT . SimplHome ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MENU_OnPush_58 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 770;
        SIMPLSHARPCOMPONENT . SimplMenu ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEARCH_OnPush_59 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 775;
        SIMPLSHARPCOMPONENT . SimplSearch ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPARROW_OnRelease_60 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 783;
        SIMPLSHARPCOMPONENT . SimplReleaseArrow ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_OnRelease_61 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 793;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object YOUTUBE_OnPush_62 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 800;
        SIMPLSHARPCOMPONENT . SimplYouTube ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object YOUTUBETV_OnPush_63 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 805;
        SIMPLSHARPCOMPONENT . SimplYouTubeTv ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NETFLIX_OnPush_64 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 810;
        SIMPLSHARPCOMPONENT . SimplNetflix ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HULU_OnPush_65 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 815;
        SIMPLSHARPCOMPONENT . SimplHulu ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECTVNOW_OnPush_66 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 820;
        SIMPLSHARPCOMPONENT . SimplDirecTvNow ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AMAZONVIDEO_OnPush_67 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 825;
        SIMPLSHARPCOMPONENT . SimplAmazonVideo ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYSTATIONVUE_OnPush_68 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 830;
        SIMPLSHARPCOMPONENT . SimplPlaystationVue ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLINGTV_OnPush_69 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 835;
        SIMPLSHARPCOMPONENT . SimplSlingTv ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object YOUTUBE_OnRelease_70 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 847;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORWARDSCAN_OnPush_71 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 855;
        SIMPLSHARPCOMPONENT . SimplForwardScan ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REVERSESCAN_OnPush_72 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 860;
        SIMPLSHARPCOMPONENT . SimplReverseScan ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAY_OnPush_73 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 865;
        SIMPLSHARPCOMPONENT . SimplPlay ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAUSE_OnPush_74 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 870;
        SIMPLSHARPCOMPONENT . SimplPause ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_OnPush_75 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 875;
        SIMPLSHARPCOMPONENT . SimplStop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORWARDSKIP_OnPush_76 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 880;
        SIMPLSHARPCOMPONENT . SimplForwardSkip ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REVERSESKIP_OnPush_77 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 885;
        SIMPLSHARPCOMPONENT . SimplReverseSkip ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REPEAT_OnPush_78 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 890;
        SIMPLSHARPCOMPONENT . SimplRepeat ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RETURNCOMMAND_OnPush_79 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 895;
        SIMPLSHARPCOMPONENT . SimplReturn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BACK_OnPush_80 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 900;
        SIMPLSHARPCOMPONENT . SimplBack ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAYPAUSE_OnPush_81 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 905;
        SIMPLSHARPCOMPONENT . SimplPlayPause ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OPTIONS_OnPush_82 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 910;
        SIMPLSHARPCOMPONENT . SimplOptions ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INFO_OnPush_83 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 915;
        SIMPLSHARPCOMPONENT . SimplInfo ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORWARDSCAN_OnRelease_84 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 932;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object USERATTRIBUTE_SENDITIN_OnPush_85 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort INDEX = 0;
        
        
        __context__.SourceCodeLine = 939;
        INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 941;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)USERATTRIBUTE_DATATYPE[ INDEX ] .Value);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 945;
                    SIMPLSHARPCOMPONENT . SimplSetStringUserAttribute ( (ushort)( INDEX ), USERATTRIBUTE_STRINGVALUE[ INDEX ] .ToString()) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 949;
                    SIMPLSHARPCOMPONENT . SimplSetAnalogUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_ANALOGVALUE[ INDEX ] .UshortValue )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 953;
                    SIMPLSHARPCOMPONENT . SimplSetDigitalUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_DIGITALVALUE[ INDEX ] .Value )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 957;
                    SIMPLSHARPCOMPONENT . SimplSetAnalogUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_ANALOGVALUE[ INDEX ] .UshortValue )) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTMEDIASERVICEBYID_OnChange_86 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 970;
        SIMPLSHARPCOMPONENT . SimplSelectMediaService ( SELECTMEDIASERVICEBYID .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTMEDIASERVICE_OnPush_87 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDX = 0;
        
        ushort OFFSET = 0;
        
        
        __context__.SourceCodeLine = 978;
        OFFSET = (ushort) ( ((MEDIASERVICECURRENTPAGE * 25) - 25) ) ; 
        __context__.SourceCodeLine = 980;
        IDX = (ushort) ( (Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) + OFFSET) ) ; 
        __context__.SourceCodeLine = 982;
        SIMPLSHARPCOMPONENT . SimplSelectMediaService ( SIMPLSHARPCOMPONENT.SimplMediaServiceProviders[ (IDX - 1) ].Id .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEXTMEDIASERVICEPAGE_OnPush_88 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort GOTOPAGE = 0;
        
        
        __context__.SourceCodeLine = 989;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MEDIASERVICENUMPAGES > 1 ))  ) ) 
            { 
            __context__.SourceCodeLine = 991;
            if ( Functions.TestForTrue  ( ( Functions.Not( Functions.BoolToInt ( (MEDIASERVICECURRENTPAGE + 1) > MEDIASERVICENUMPAGES ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 993;
                MEDIASERVICECURRENTPAGE = (ushort) ( (MEDIASERVICECURRENTPAGE + 1) ) ; 
                __context__.SourceCodeLine = 994;
                GOTOPAGE = (ushort) ( MEDIASERVICECURRENTPAGE ) ; 
                __context__.SourceCodeLine = 995;
                CURRENTMEDIASERVICEPAGE  .Value = (ushort) ( GOTOPAGE ) ; 
                __context__.SourceCodeLine = 996;
                OUTPUTMEDIASERVICESPAGE (  __context__ , (ushort)( GOTOPAGE ), (ushort)( MEDIASERVICECOUNT )) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PREVMEDIASERVICEPAGE_OnPush_89 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort GOTOPAGE = 0;
        
        
        __context__.SourceCodeLine = 1005;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MEDIASERVICENUMPAGES > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1007;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (MEDIASERVICECURRENTPAGE - 1) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1009;
                MEDIASERVICECURRENTPAGE = (ushort) ( (MEDIASERVICECURRENTPAGE - 1) ) ; 
                __context__.SourceCodeLine = 1010;
                GOTOPAGE = (ushort) ( MEDIASERVICECURRENTPAGE ) ; 
                __context__.SourceCodeLine = 1011;
                CURRENTMEDIASERVICEPAGE  .Value = (ushort) ( GOTOPAGE ) ; 
                __context__.SourceCodeLine = 1012;
                OUTPUTMEDIASERVICESPAGE (  __context__ , (ushort)( GOTOPAGE ), (ushort)( MEDIASERVICECOUNT )) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ARTWORKON_OnPush_90 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1020;
        SIMPLSHARPCOMPONENT . SimplArtworkOn ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ARTWORKOFF_OnPush_91 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1025;
        SIMPLSHARPCOMPONENT . SimplArtworkOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLEARTWORKONPOWEROFF_OnPush_92 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1030;
        SIMPLSHARPCOMPONENT . SimplEnableArtworkOnPowerOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISABLEARTWORKONPOWEROFF_OnPush_93 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1035;
        SIMPLSHARPCOMPONENT . SimplDisableArtworkOnPowerOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECTDISPLAYMODE_OnPush_94 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1041;
        SIMPLSHARPCOMPONENT . SimplSelectDisplayMode ( SIMPLSHARPCOMPONENT.SimplDisplayModes[ (Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) - 1) ].Id .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_OnPush_95 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1047;
        SIMPLSHARPCOMPONENT . SimplLetterButton ( "A") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object B_OnPush_96 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1051;
        SIMPLSHARPCOMPONENT . SimplLetterButton ( "B") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object C_OnPush_97 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1055;
        SIMPLSHARPCOMPONENT . SimplLetterButton ( "C") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object D_OnPush_98 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1059;
        SIMPLSHARPCOMPONENT . SimplLetterButton ( "D") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RED_OnPush_99 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1064;
        SIMPLSHARPCOMPONENT . SimplColorButton ( "Red") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GREEN_OnPush_100 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1069;
        SIMPLSHARPCOMPONENT . SimplColorButton ( "Green") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLUE_OnPush_101 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1074;
        SIMPLSHARPCOMPONENT . SimplColorButton ( "Blue") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object YELLOW_OnPush_102 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1079;
        SIMPLSHARPCOMPONENT . SimplColorButton ( "Yellow") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_OnRelease_103 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1091;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANDLERXCHANGE ( Object __EventInfo__ ) 
    { 
    GatherEventArgs ARGS = (GatherEventArgs)__EventInfo__;
    CrestronString TEMP__DOLLAR__;
    TEMP__DOLLAR__  = new CrestronString( InheritedStringEncoding, 1000, this );
    
    short RXSTATUS = 0;
    
    short REARMSUCCESS = 0;
    
    short RECREATESUCCESS = 0;
    
    ushort REARMTRIES = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1104;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS.Results == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1106;
            TEMP__DOLLAR__  =  ( ARGS .  RxString  )  .ToString() ; 
            __context__.SourceCodeLine = 1107;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( RX ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1109;
                TEMP__DOLLAR__  =  ( TEMP__DOLLAR__ + Functions.Remove ( Functions.Length( RX ), RX )  )  .ToString() ; 
                } 
            
            __context__.SourceCodeLine = 1111;
            SIMPLSHARPCOMPONENT . ReceiveData ( TEMP__DOLLAR__ .ToString()) ; 
            } 
        
        __context__.SourceCodeLine = 1114;
        REARMTRIES = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1115;
        do 
            { 
            __context__.SourceCodeLine = 1117;
            REARMSUCCESS = (short) ( Functions.RearmGatherAsync( ARGS.Input ) ) ; 
            __context__.SourceCodeLine = 1118;
            REARMTRIES = (ushort) ( (REARMTRIES + 1) ) ; 
            } 
        while (false == ( Functions.TestForTrue  ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( REARMSUCCESS >= 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( REARMTRIES >= 10 ) )) )) )); 
        __context__.SourceCodeLine = 1122;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( REARMTRIES >= 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 1124;
            GenerateUserError ( "({0}) Failed to RearmGatherAsync, Attempting to create new GatherAsync", GetSymbolInstanceName ( ) ) ; 
            __context__.SourceCodeLine = 1125;
            RECREATESUCCESS = (short) ( Functions.GatherAsync( 1 , RX , HANDLERXCHANGE ) ) ; 
            __context__.SourceCodeLine = 1126;
            GenerateUserError ( "({0}) Creating new GatherAsync, result = {1:d}", GetSymbolInstanceName ( ) , (short)RECREATESUCCESS) ; 
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); ARGS.Input.SetCanSpawnEvent(); }
    return this;
    }
    
object _0_OnPush_104 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1133;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _1_OnPush_105 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1137;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _2_OnPush_106 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1141;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _3_OnPush_107 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1145;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _4_OnPush_108 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1149;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _5_OnPush_109 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1153;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _6_OnPush_110 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1157;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _7_OnPush_111 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1161;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _8_OnPush_112 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1165;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 8 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _9_OnPush_113 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1169;
        SIMPLSHARPCOMPONENT . SimplKeypadNumber ( (ushort)( 9 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADPOUND_OnPush_114 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1173;
        SIMPLSHARPCOMPONENT . SimplKeypadPound ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADASTERISK_OnPush_115 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1177;
        SIMPLSHARPCOMPONENT . SimplKeypadAsterisk ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADBACKSPACE_OnPush_116 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1181;
        SIMPLSHARPCOMPONENT . SimplKeypadBackSpace ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PERIOD_OnPush_117 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1185;
        SIMPLSHARPCOMPONENT . SimplPeriod ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DASH_OnPush_118 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1189;
        SIMPLSHARPCOMPONENT . SimplDash ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_OnPush_119 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1193;
        SIMPLSHARPCOMPONENT . SimplEnter ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _0_OnRelease_120 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1198;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _1_OnRelease_121 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1202;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _2_OnRelease_122 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1206;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _3_OnRelease_123 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1210;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _4_OnRelease_124 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1214;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _5_OnRelease_125 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1218;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _6_OnRelease_126 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1222;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _7_OnRelease_127 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1226;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _8_OnRelease_128 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1230;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object _9_OnRelease_129 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1234;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADPOUND_OnRelease_130 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1238;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADASTERISK_OnRelease_131 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1242;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPADBACKSPACE_OnRelease_132 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1246;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PERIOD_OnRelease_133 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1250;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DASH_OnRelease_134 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1254;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_OnRelease_135 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1258;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DVR_OnPush_136 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1264;
        SIMPLSHARPCOMPONENT . SimplDvrCommand ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIVE_OnPush_137 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1268;
        SIMPLSHARPCOMPONENT . SimplLive ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECORD_OnPush_138 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1272;
        SIMPLSHARPCOMPONENT . SimplRecord ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SPEEDSLOW_OnPush_139 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1276;
        SIMPLSHARPCOMPONENT . SimplSpeedSlow ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSUP_OnPush_140 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1280;
        SIMPLSHARPCOMPONENT . SimplThumbsUp ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSDOWN_OnPush_141 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1284;
        SIMPLSHARPCOMPONENT . SimplThumbsDown ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DVR_OnRelease_142 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1288;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIVE_OnRelease_143 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1292;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECORD_OnRelease_144 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1296;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SPEEDSLOW_OnRelease_145 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1300;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSUP_OnRelease_146 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1304;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THUMBSDOWN_OnRelease_147 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1308;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_OnChange_148 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1314;
        SIMPLSHARPCOMPONENT . SimplSetChannel ( SETCHANNEL .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELUP_OnPush_149 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1318;
        SIMPLSHARPCOMPONENT . ChannelUpHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELDOWN_OnPush_150 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1322;
        SIMPLSHARPCOMPONENT . ChannelDownHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUIDE_OnPush_151 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1326;
        SIMPLSHARPCOMPONENT . SimplGuide ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGEUP_OnPush_152 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1330;
        SIMPLSHARPCOMPONENT . PageUpHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGEDOWN_OnPush_153 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1334;
        SIMPLSHARPCOMPONENT . PageDownHold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELUP_OnRelease_154 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1338;
        SIMPLSHARPCOMPONENT . ChannelUpRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELDOWN_OnRelease_155 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1342;
        SIMPLSHARPCOMPONENT . ChannelDownRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUIDE_OnRelease_156 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1346;
        SIMPLSHARPCOMPONENT . SimplRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGEUP_OnRelease_157 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1350;
        SIMPLSHARPCOMPONENT . PageUpRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAGEDOWN_OnRelease_158 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1354;
        SIMPLSHARPCOMPONENT . PageDownRelease ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_SENDENTERAFTERSEQUENCE_OnPush_159 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1359;
        SIMPLSHARPCOMPONENT . SimplSetChannelSendAfterSequence ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_SENDENTERAFTERSEQUENCE_OnRelease_160 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1364;
        SIMPLSHARPCOMPONENT . SimplSetChannelSendAfterSequence ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_TIMEBETWEENSEQUENCESINMS_OnChange_161 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1369;
        SIMPLSHARPCOMPONENT . SimplSetChannelMsBetweenSequences ( (ushort)( SETCHANNEL_TIMEBETWEENSEQUENCESINMS  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_TIMEBETWEENCOMMANDSINMS_OnChange_162 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1374;
        SIMPLSHARPCOMPONENT . SimplSetChannelMsBetweenCommands ( (ushort)( SETCHANNEL_TIMEBETWEENCOMMANDSINMS  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETCHANNEL_IRCOMMANDDURATIONINMS_OnChange_163 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1379;
        SIMPLSHARPCOMPONENT . SimplSetChannelIrCommandDuration ( (ushort)( SETCHANNEL_IRCOMMANDDURATIONINMS  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FILE_OnChange_164 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1385;
        _DRIVERFILENAME  .UpdateValue ( FILE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INITIALIZE_OnPush_165 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString LPATHTODRIVER;
        LPATHTODRIVER  = new CrestronString( InheritedStringEncoding, 200, this );
        
        CrestronString LIPADDRESS;
        LIPADDRESS  = new CrestronString( InheritedStringEncoding, 50, this );
        
        ushort LPORT = 0;
        
        
        __context__.SourceCodeLine = 1394;
        LPATHTODRIVER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1395;
        LIPADDRESS  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1396;
        LPORT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1398;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt (_INITILIZATIONCOMPLETE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1400;
            Functions.Delay (  (int) ( 10 ) ) ; 
            __context__.SourceCodeLine = 1398;
            } 
        
        __context__.SourceCodeLine = 1403;
        SYSTEMMODULE . Initialize ( UNIQUEID  .ToString(), _DRIVERFILENAME .ToString(), (int)( 1 ), IPADDRESS .ToString(), (ushort)( PORT  .UshortValue ), TRANSPORT  .ToString()) ; 
        __context__.SourceCodeLine = 1404;
        LPATHTODRIVER  .UpdateValue ( SYSTEMMODULE . DriverPath  ) ; 
        __context__.SourceCodeLine = 1405;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TRANSPORT  == "Ethernet"))  ) ) 
            { 
            __context__.SourceCodeLine = 1407;
            LIPADDRESS  .UpdateValue ( SYSTEMMODULE . DeviceHostname  ) ; 
            __context__.SourceCodeLine = 1408;
            LPORT = (ushort) ( SYSTEMMODULE.DevicePort ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1412;
            LIPADDRESS  .UpdateValue ( IPADDRESS  ) ; 
            __context__.SourceCodeLine = 1413;
            LPORT = (ushort) ( PORT  .UshortValue ) ; 
            } 
        
        __context__.SourceCodeLine = 1416;
        SIMPLSHARPCOMPONENT . Initialize2 ( LPATHTODRIVER .ToString(), (int)( ID  .IntValue ), LIPADDRESS .ToString(), (int)( LPORT ), (int)( WARMUPTIME  .IntValue ), (int)( COOLDOWNTIME  .IntValue ), (int)( ENABLELOGGING  .Value )) ; 
        __context__.SourceCodeLine = 1417;
        PACKETTX  .UpdateValue ( SIMPLSHARPCOMPONENT . SimplSetComportSpec ( (ushort)( PORT  .UshortValue ))  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void LOADINITIALUSERATTRIBUTES (  SplusExecutionContext __context__ ) 
    { 
    ushort INDEX = 0;
    
    
    __context__.SourceCodeLine = 1424;
    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
    ushort __FN_FOREND_VAL__1 = (ushort)10; 
    int __FN_FORSTEP_VAL__1 = (int)1; 
    for ( INDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INDEX  >= __FN_FORSTART_VAL__1) && (INDEX  <= __FN_FOREND_VAL__1) ) : ( (INDEX  <= __FN_FORSTART_VAL__1) && (INDEX  >= __FN_FOREND_VAL__1) ) ; INDEX  += (ushort)__FN_FORSTEP_VAL__1) 
        { 
        __context__.SourceCodeLine = 1426;
        
            {
            int __SPLS_TMPVAR__SWTCH_2__ = ((int)USERATTRIBUTE_DATATYPE[ INDEX ] .Value);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1430;
                    SIMPLSHARPCOMPONENT . SimplSetStringUserAttribute ( (ushort)( INDEX ), USERATTRIBUTE_STRINGVALUE[ INDEX ] .ToString()) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1434;
                    SIMPLSHARPCOMPONENT . SimplSetAnalogUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_ANALOGVALUE[ INDEX ] .UshortValue )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1438;
                    SIMPLSHARPCOMPONENT . SimplSetDigitalUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_DIGITALVALUE[ INDEX ] .Value )) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1442;
                    SIMPLSHARPCOMPONENT . SimplSetAnalogUserAttribute ( (ushort)( INDEX ), (ushort)( USERATTRIBUTE_ANALOGVALUE[ INDEX ] .UshortValue )) ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 1424;
        } 
    
    
    }
    
public void BASICINFORMATIONCALLBACK ( SimplSharpString SDKVERSIONS , SimplSharpString MANUFACTURERS , SimplSharpString BASEMODELS , SimplSharpString SUPPORTEDMODELSS , SimplSharpString SUPPORTEDSERIESS , SimplSharpString DESCRIPTIONS , SimplSharpString DRIVERVERSIONS , SimplSharpString DRIVERVERSIONDATES , SimplSharpString GUIDS , ushort SUPPORTSFEEDBACKS ) 
    { 
    ushort INDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1455;
        SDKVERSION  .UpdateValue ( SDKVERSIONS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1456;
        MANUFACTURER  .UpdateValue ( MANUFACTURERS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1457;
        BASEMODEL  .UpdateValue ( BASEMODELS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1458;
        SUPPORTEDMODELS  .UpdateValue ( SUPPORTEDMODELSS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1459;
        SUPPORTEDSERIES  .UpdateValue ( SUPPORTEDSERIESS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1460;
        DESCRIPTION  .UpdateValue ( DESCRIPTIONS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1461;
        DRIVERVERSION  .UpdateValue ( DRIVERVERSIONS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1462;
        DRIVERVERSIONDATE  .UpdateValue ( DRIVERVERSIONDATES  .ToString()  ) ; 
        __context__.SourceCodeLine = 1463;
        GUID  .UpdateValue ( GUIDS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1464;
        SUPPORTSFEEDBACK  .Value = (ushort) ( SUPPORTSFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1466;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)10; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INDEX  >= __FN_FORSTART_VAL__1) && (INDEX  <= __FN_FOREND_VAL__1) ) : ( (INDEX  <= __FN_FORSTART_VAL__1) && (INDEX  >= __FN_FOREND_VAL__1) ) ; INDEX  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1468;
            USERATTRIBUTE_ISAVAILABLE [ INDEX]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.UserAttributeIsAvailable[ (INDEX - 1) ] ) ; 
            __context__.SourceCodeLine = 1469;
            USERATTRIBUTE_LABEL [ INDEX]  .UpdateValue ( SIMPLSHARPCOMPONENT . UserAttributeLabels [ (INDEX - 1) ]  ) ; 
            __context__.SourceCodeLine = 1470;
            USERATTRIBUTE_DESCRIPTION [ INDEX]  .UpdateValue ( SIMPLSHARPCOMPONENT . UserAttributeDescriptions [ (INDEX - 1) ]  ) ; 
            __context__.SourceCodeLine = 1471;
            USERATTRIBUTE_TYPE [ INDEX]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.UserAttributeTypes[ (INDEX - 1) ] ) ; 
            __context__.SourceCodeLine = 1472;
            USERATTRIBUTE_DATATYPE [ INDEX]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.UserAttributeDataTypes[ (INDEX - 1) ] ) ; 
            __context__.SourceCodeLine = 1473;
            USERATTRIBUTE_ISPERSISTENT [ INDEX]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.UserAttributeIsPersistent[ (INDEX - 1) ] ) ; 
            __context__.SourceCodeLine = 1474;
            USERATTRIBUTE_REQUIREDFORCONNECTION [ INDEX]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.UserAttributeRequiredForConnection[ (INDEX - 1) ] ) ; 
            __context__.SourceCodeLine = 1466;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void TXCALLBACK ( SimplSharpString MESSAGES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1480;
        TX  .UpdateValue ( MESSAGES  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void PACKETTXCALLBACK ( SimplSharpString MESSAGES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1485;
        PACKETTX  .UpdateValue ( MESSAGES  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void LOGOUTCALLBACK ( SimplSharpString MESSAGES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1490;
        LOG  .UpdateValue ( MESSAGES  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void RXOUTUPDATECALLBACK ( SimplSharpString MESSAGES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1495;
        RXOUT  .UpdateValue ( MESSAGES  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void BASICCONNECTIONSUPPORTSCALLBACK ( ushort SUPPORTSDISCONNECTS , ushort SUPPORTSRECONNECTS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1500;
        SUPPORTSDISCONNECT  .Value = (ushort) ( SUPPORTSDISCONNECTS ) ; 
        __context__.SourceCodeLine = 1501;
        SUPPORTSRECONNECT  .Value = (ushort) ( SUPPORTSRECONNECTS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CUSTOMIRCOMMANDSUPPORTSCALLBACK ( ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1508;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)10; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1510;
            COMMANDEXISTS [ I]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplCustomCommandExists( COMMANDNAME[ I ] .ToString() ) ) ; 
            __context__.SourceCodeLine = 1508;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MANIFESTUPDATEDCALLBACK ( SimplSharpString FILEPATHS , SimplSharpString IPADDRESSS , ushort PORTS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1516;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TRANSPORT  != "Ethernet"))  ) ) 
            { 
            __context__.SourceCodeLine = 1518;
            PORTS = (ushort) ( PORT  .UshortValue ) ; 
            } 
        
        __context__.SourceCodeLine = 1521;
        SIMPLSHARPCOMPONENT . Initialize2 ( FILEPATHS .ToString() .ToString(), (int)( ID  .IntValue ), IPADDRESSS .ToString() .ToString(), (int)( PORTS ), (int)( WARMUPTIME  .IntValue ), (int)( COOLDOWNTIME  .IntValue ), (int)( ENABLELOGGING  .Value )) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DRIVERLOADEDCB ( ushort DRIVERLOADEDS , ushort CURRENTPORTS , ushort REBOOTREQUIREDS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1526;
        LOADINITIALUSERATTRIBUTES (  __context__  ) ; 
        __context__.SourceCodeLine = 1528;
        DRIVERLOADED  .Value = (ushort) ( DRIVERLOADEDS ) ; 
        __context__.SourceCodeLine = 1529;
        CURRENTPORT  .Value = (ushort) ( CURRENTPORTS ) ; 
        __context__.SourceCodeLine = 1530;
        REBOOTREQUIRED  .Value = (ushort) ( REBOOTREQUIREDS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DRIVERAUTHSUPPORTSCALLBACK ( ushort SUPPORTSUSERNM , ushort SUPPORTSPASSWRD , ushort SUPPORTSISREQUIRED ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1535;
        SUPPORTSUSERNAME  .Value = (ushort) ( SUPPORTSUSERNM ) ; 
        __context__.SourceCodeLine = 1536;
        SUPPORTSPASSWORD  .Value = (ushort) ( SUPPORTSPASSWRD ) ; 
        __context__.SourceCodeLine = 1537;
        AUTHENTICATIONISREQUIRED  .Value = (ushort) ( SUPPORTSISREQUIRED ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DRIVERAUTHUPDATECALLBACK ( ushort AUTHSTATUS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1542;
        AUTHENTICATIONSTATUS  .Value = (ushort) ( AUTHSTATUS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DISPLAYSTATUSCALLBACK ( ushort POWERS , ushort WARMINGUPS , ushort COOLINGDOWNS , ushort INPUTTYPES , SimplSharpString INPUTCONNECTORS , SimplSharpString INPUTDESCRIPTIONS , ushort VOLUMES , ushort MUTES , ushort CONNECTIONSTATUSS , ushort VIDEOMUTES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1548;
        POWER_F  .Value = (ushort) ( POWERS ) ; 
        __context__.SourceCodeLine = 1549;
        WARMINGUP  .Value = (ushort) ( WARMINGUPS ) ; 
        __context__.SourceCodeLine = 1550;
        COOLINGDOWN  .Value = (ushort) ( COOLINGDOWNS ) ; 
        __context__.SourceCodeLine = 1551;
        VOLUME_F  .Value = (ushort) ( VOLUMES ) ; 
        __context__.SourceCodeLine = 1552;
        MUTE_F  .Value = (ushort) ( MUTES ) ; 
        __context__.SourceCodeLine = 1553;
        CONNECTION_F  .Value = (ushort) ( CONNECTIONSTATUSS ) ; 
        __context__.SourceCodeLine = 1554;
        VIDEOMUTE_F  .Value = (ushort) ( VIDEOMUTES ) ; 
        __context__.SourceCodeLine = 1556;
        ACTIVEINPUTTYPE  .Value = (ushort) ( INPUTTYPES ) ; 
        __context__.SourceCodeLine = 1557;
        ACTIVEINPUTCONNECTOR  .UpdateValue ( INPUTCONNECTORS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1558;
        ACTIVEINPUTDESCRIPTION  .UpdateValue ( INPUTDESCRIPTIONS  .ToString()  ) ; 
        __context__.SourceCodeLine = 1560;
        ISETVOLUME = (ushort) ( VOLUMES ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DISPLAYSTATUS2CALLBACK ( SimplSharpString INPUTFRIENDLYNAME ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1565;
        ACTIVEINPUTFRIENDLYNAME  .UpdateValue ( INPUTFRIENDLYNAME  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void POWERSUPPORTSCALLBACK ( ushort SUPPORTSDISCRETEPOWERS , ushort SUPPORTSTOGGLEPOWERS , ushort SUPPORTSPOWERFEEDBACKS , ushort SUPPORTSWARMUPTIMES , ushort SUPPORTSCOOLDOWNTIMES , ushort WARMUPTIMEI , ushort COOLDOWNTIMEI ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1570;
        SUPPORTSDISCRETEPOWER  .Value = (ushort) ( SUPPORTSDISCRETEPOWERS ) ; 
        __context__.SourceCodeLine = 1571;
        SUPPORTSTOGGLEPOWER  .Value = (ushort) ( SUPPORTSTOGGLEPOWERS ) ; 
        __context__.SourceCodeLine = 1572;
        SUPPORTSPOWER_F  .Value = (ushort) ( SUPPORTSPOWERFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1573;
        SUPPORTSWARMUPTIME  .Value = (ushort) ( SUPPORTSWARMUPTIMES ) ; 
        __context__.SourceCodeLine = 1574;
        SUPPORTSCOOLDOWNTIME  .Value = (ushort) ( SUPPORTSCOOLDOWNTIMES ) ; 
        __context__.SourceCodeLine = 1575;
        COOLDOWNTIME_F  .Value = (ushort) ( COOLDOWNTIMEI ) ; 
        __context__.SourceCodeLine = 1576;
        WARMUPTIME_F  .Value = (ushort) ( WARMUPTIMEI ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void BASICINPUTSSUPPORTSCALLBACK ( ushort SETINPUTS , ushort SUPPORTSINPUTFEEDBACKS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1581;
        SUPPORTSSETINPUT  .Value = (ushort) ( SETINPUTS ) ; 
        __context__.SourceCodeLine = 1582;
        SUPPORTSINPUT_F  .Value = (ushort) ( SUPPORTSINPUTFEEDBACKS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void VOLUMESUPPORTSCALLBACK ( ushort SUPPORTSVOLUMEFEEDBACKS , ushort SUPPORTSMUTEFEEDBACKS , ushort SUPPORTSDISCRETEMUTES , ushort SUPPORTSMUTES , ushort SUPPORTSSETVOLUMES , ushort SUPPORTSCHANGEVOLUMES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1587;
        SUPPORTSVOLUME_F  .Value = (ushort) ( SUPPORTSVOLUMEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1588;
        SUPPORTSMUTE_F  .Value = (ushort) ( SUPPORTSMUTEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1589;
        SUPPORTSDISCRETEMUTE  .Value = (ushort) ( SUPPORTSDISCRETEMUTES ) ; 
        __context__.SourceCodeLine = 1590;
        SUPPORTSMUTE  .Value = (ushort) ( SUPPORTSMUTES ) ; 
        __context__.SourceCodeLine = 1591;
        SUPPORTSSETVOLUME  .Value = (ushort) ( SUPPORTSSETVOLUMES ) ; 
        __context__.SourceCodeLine = 1592;
        SUPPORTSCHANGEVOLUME  .Value = (ushort) ( SUPPORTSCHANGEVOLUMES ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void INPUTDETAILSCALLBACK ( ) 
    { 
    ushort COUNT = 0;
    
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1599;
        COUNT = (ushort) ( SIMPLSHARPCOMPONENT.NumberOfInputs ) ; 
        __context__.SourceCodeLine = 1600;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)COUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1602;
            DISPLAYINPUTDESCRIPTION [ I]  .UpdateValue ( SIMPLSHARPCOMPONENT . SimplInputDescriptions [ (I - 1) ]  ) ; 
            __context__.SourceCodeLine = 1603;
            DISPLAYINPUTCONNECTOR [ I]  .UpdateValue ( SIMPLSHARPCOMPONENT . SimplInputConnectors [ (I - 1) ]  ) ; 
            __context__.SourceCodeLine = 1604;
            DISPLAYINPUTTYPE [ I]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplInputTypes[ (I - 1) ] ) ; 
            __context__.SourceCodeLine = 1600;
            } 
        
        __context__.SourceCodeLine = 1607;
        NUMBEROFINPUTS  .Value = (ushort) ( COUNT ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void INPUTDETAILS2CALLBACK ( ) 
    { 
    ushort COUNT = 0;
    
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1615;
        COUNT = (ushort) ( SIMPLSHARPCOMPONENT.NumberOfInputs ) ; 
        __context__.SourceCodeLine = 1617;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)COUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1619;
            DISPLAYINPUTFRIENDLYNAME [ I]  .UpdateValue ( SIMPLSHARPCOMPONENT . SimplInputFriendlyNames [ (I - 1) ]  ) ; 
            __context__.SourceCodeLine = 1617;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void VIDEODISPLAYSUPPORTSCALLBACK ( ushort LAMPHOURSS , ushort DISCRETEVIDEOMUTES , ushort TOGGLEVIDEOMUTES , ushort VIDEOMUTEFEEDBACKS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1625;
        SUPPORTSLAMPHOURS  .Value = (ushort) ( LAMPHOURSS ) ; 
        __context__.SourceCodeLine = 1626;
        SUPPORTSTOGGLEVIDEOMUTE  .Value = (ushort) ( TOGGLEVIDEOMUTES ) ; 
        __context__.SourceCodeLine = 1627;
        SUPPORTSDISCRETEVIDEOMUTE  .Value = (ushort) ( DISCRETEVIDEOMUTES ) ; 
        __context__.SourceCodeLine = 1628;
        SUPPORTSVIDEOMUTE_F  .Value = (ushort) ( VIDEOMUTEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1630;
        SUPPORTSRED  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplColorKeysSupported[ 0 ] ) ; 
        __context__.SourceCodeLine = 1631;
        SUPPORTSGREEN  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplColorKeysSupported[ 1 ] ) ; 
        __context__.SourceCodeLine = 1632;
        SUPPORTSBLUE  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplColorKeysSupported[ 2 ] ) ; 
        __context__.SourceCodeLine = 1633;
        SUPPORTSYELLOW  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplColorKeysSupported[ 3 ] ) ; 
        __context__.SourceCodeLine = 1635;
        SUPPORTSA  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplLetterKeysSupported[ 0 ] ) ; 
        __context__.SourceCodeLine = 1636;
        SUPPORTSB  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplLetterKeysSupported[ 1 ] ) ; 
        __context__.SourceCodeLine = 1637;
        SUPPORTSC  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplLetterKeysSupported[ 2 ] ) ; 
        __context__.SourceCodeLine = 1638;
        SUPPORTSD  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplLetterKeysSupported[ 3 ] ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void LAMPHOURSCALLBACK ( ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1645;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)4; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1647;
            LAMPHOURS [ I]  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplLampHours[ (I - 1) ] ) ; 
            __context__.SourceCodeLine = 1645;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void NAVIGATIONSUPPORTSCALLBACK ( ushort ARROWKEYSS , ushort CLEARS , ushort EXITS , ushort HOMES , ushort MENUS , ushort SELECTS , ushort SEARCHS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1653;
        SUPPORTSARROWKEYS  .Value = (ushort) ( ARROWKEYSS ) ; 
        __context__.SourceCodeLine = 1654;
        SUPPORTSCLEAR  .Value = (ushort) ( CLEARS ) ; 
        __context__.SourceCodeLine = 1655;
        SUPPORTSEXIT  .Value = (ushort) ( EXITS ) ; 
        __context__.SourceCodeLine = 1656;
        SUPPORTSHOME  .Value = (ushort) ( HOMES ) ; 
        __context__.SourceCodeLine = 1657;
        SUPPORTSMENU  .Value = (ushort) ( MENUS ) ; 
        __context__.SourceCodeLine = 1658;
        SUPPORTSSELECT  .Value = (ushort) ( SELECTS ) ; 
        __context__.SourceCodeLine = 1659;
        SUPPORTSSEARCH  .Value = (ushort) ( SEARCHS ) ; 
        __context__.SourceCodeLine = 1661;
        SUPPORTSARROWUP  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplArrowDirectionsSupported[ 0 ] ) ; 
        __context__.SourceCodeLine = 1662;
        SUPPORTSARROWDOWN  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplArrowDirectionsSupported[ 1 ] ) ; 
        __context__.SourceCodeLine = 1663;
        SUPPORTSARROWLEFT  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplArrowDirectionsSupported[ 2 ] ) ; 
        __context__.SourceCodeLine = 1664;
        SUPPORTSARROWRIGHT  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplArrowDirectionsSupported[ 3 ] ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIASUPPORTSCALLBACK ( ushort YOUTUBES , ushort YOUTUBETVS , ushort NETFLIXS , ushort HULUS , ushort DIRECTVNOWS , ushort AMAZONVIDEOS , ushort PLAYSTATIONVUES , ushort SLINGTVS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1669;
        SUPPORTSYOUTUBE  .Value = (ushort) ( YOUTUBES ) ; 
        __context__.SourceCodeLine = 1670;
        SUPPORTSYOUTUBETV  .Value = (ushort) ( YOUTUBETVS ) ; 
        __context__.SourceCodeLine = 1671;
        SUPPORTSNETFLIX  .Value = (ushort) ( NETFLIXS ) ; 
        __context__.SourceCodeLine = 1672;
        SUPPORTSHULU  .Value = (ushort) ( HULUS ) ; 
        __context__.SourceCodeLine = 1673;
        SUPPORTSDIRECTVNOW  .Value = (ushort) ( DIRECTVNOWS ) ; 
        __context__.SourceCodeLine = 1674;
        SUPPORTSAMAZONVIDEO  .Value = (ushort) ( AMAZONVIDEOS ) ; 
        __context__.SourceCodeLine = 1675;
        SUPPORTSPLAYSTATIONVUE  .Value = (ushort) ( PLAYSTATIONVUES ) ; 
        __context__.SourceCodeLine = 1676;
        SUPPORTSSLINGTV  .Value = (ushort) ( SLINGTVS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIATRANSPORTSCALLBACK ( ushort FORWARDSCANS , ushort REVERSESCANS , ushort PLAYS , ushort PAUSES , ushort STOPS , ushort FORWARDSKIPS , ushort REVERSESKIPS , ushort REPEATS , ushort RETURNS , ushort BACKS , ushort PLAYPAUSES , ushort OPTIONSS , ushort INFOS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1681;
        SUPPORTSFORWARDSCAN  .Value = (ushort) ( FORWARDSCANS ) ; 
        __context__.SourceCodeLine = 1682;
        SUPPORTSREVERSESCAN  .Value = (ushort) ( REVERSESCANS ) ; 
        __context__.SourceCodeLine = 1683;
        SUPPORTSPLAY  .Value = (ushort) ( PLAYS ) ; 
        __context__.SourceCodeLine = 1684;
        SUPPORTSPAUSE  .Value = (ushort) ( PAUSES ) ; 
        __context__.SourceCodeLine = 1685;
        SUPPORTSSTOP  .Value = (ushort) ( STOPS ) ; 
        __context__.SourceCodeLine = 1686;
        SUPPORTSFORWARDSKIP  .Value = (ushort) ( FORWARDSKIPS ) ; 
        __context__.SourceCodeLine = 1687;
        SUPPORTSREVERSESKIP  .Value = (ushort) ( REVERSESKIPS ) ; 
        __context__.SourceCodeLine = 1688;
        SUPPORTSREPEAT  .Value = (ushort) ( REPEATS ) ; 
        __context__.SourceCodeLine = 1689;
        SUPPORTSRETURN  .Value = (ushort) ( RETURNS ) ; 
        __context__.SourceCodeLine = 1690;
        SUPPORTSBACK  .Value = (ushort) ( BACKS ) ; 
        __context__.SourceCodeLine = 1691;
        SUPPORTSPLAYPAUSE  .Value = (ushort) ( PLAYPAUSES ) ; 
        __context__.SourceCodeLine = 1692;
        SUPPORTSOPTIONS  .Value = (ushort) ( OPTIONSS ) ; 
        __context__.SourceCodeLine = 1693;
        SUPPORTSINFO  .Value = (ushort) ( INFOS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ENERGYSTARSUPPORTSCALLBACK ( ushort DISCRETEENERGYSTAR , ushort TOGGLEENERGYSTAR , ushort ENERGYSTARFEEDBACK ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void MEDIASERVICEPROVIDERCALLBACK ( ushort SUPPORTSMEDIASERVICESS , ushort HASDIRECTACCESSS , ushort SUPPORTSACTIVEMEDIASERVICEFEEDBACKS , ushort SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACKS , ushort SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACKS , ushort MEDIASERVICECOUNTS ) 
    { 
    ushort MEDIASERVICEINDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1706;
        SUPPORTSMEDIASERVICES  .Value = (ushort) ( SUPPORTSMEDIASERVICESS ) ; 
        __context__.SourceCodeLine = 1707;
        HASDIRECTACCESSTOSERVICES  .Value = (ushort) ( HASDIRECTACCESSS ) ; 
        __context__.SourceCodeLine = 1708;
        SUPPORTSACTIVEMEDIASERVICEFEEDBACK  .Value = (ushort) ( SUPPORTSACTIVEMEDIASERVICEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1709;
        SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK  .Value = (ushort) ( SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1710;
        SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK  .Value = (ushort) ( SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1712;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)MEDIASERVICECOUNTS; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( MEDIASERVICEINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (MEDIASERVICEINDEX  >= __FN_FORSTART_VAL__1) && (MEDIASERVICEINDEX  <= __FN_FOREND_VAL__1) ) : ( (MEDIASERVICEINDEX  <= __FN_FORSTART_VAL__1) && (MEDIASERVICEINDEX  >= __FN_FOREND_VAL__1) ) ; MEDIASERVICEINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1715;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISAVAILABLE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1716;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISSELECTABLE = (ushort) ( SIMPLSHARPCOMPONENT.SimplMediaServiceProviders[ (MEDIASERVICEINDEX - 1) ].SimplIsSelectable ) ; 
            __context__.SourceCodeLine = 1717;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISBRANDED = (ushort) ( SIMPLSHARPCOMPONENT.SimplMediaServiceProviders[ (MEDIASERVICEINDEX - 1) ].SimplIsBranded ) ; 
            __context__.SourceCodeLine = 1718;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . FRIENDLYNAME  =  ( SIMPLSHARPCOMPONENT . SimplMediaServiceProviders [ (MEDIASERVICEINDEX - 1)] . FriendlyName  )  .ToString() ; 
            __context__.SourceCodeLine = 1719;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . STATE = (ushort) ( SIMPLSHARPCOMPONENT.SimplMediaServiceProviders[ (MEDIASERVICEINDEX - 1) ].SimplState ) ; 
            __context__.SourceCodeLine = 1720;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . SUBSCRIPTIONSTATE = (ushort) ( SIMPLSHARPCOMPONENT.SimplMediaServiceProviders[ (MEDIASERVICEINDEX - 1) ].SimplSubscriptionStatus ) ; 
            __context__.SourceCodeLine = 1721;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . SMALLIMAGEURL  =  ( SIMPLSHARPCOMPONENT . SimplMediaServiceProviders [ (MEDIASERVICEINDEX - 1)] . SimplSmallImageUrl  )  .ToString() ; 
            __context__.SourceCodeLine = 1722;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . MEDIUMIMAGEURL  =  ( SIMPLSHARPCOMPONENT . SimplMediaServiceProviders [ (MEDIASERVICEINDEX - 1)] . SimplMediumImageUrl  )  .ToString() ; 
            __context__.SourceCodeLine = 1723;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . LARGEIMAGEURL  =  ( SIMPLSHARPCOMPONENT . SimplMediaServiceProviders [ (MEDIASERVICEINDEX - 1)] . SimplLargeImageUrl  )  .ToString() ; 
            __context__.SourceCodeLine = 1712;
            } 
        
        __context__.SourceCodeLine = 1725;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( (MEDIASERVICECOUNTS + 1) ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)100; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( MEDIASERVICEINDEX  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (MEDIASERVICEINDEX  >= __FN_FORSTART_VAL__2) && (MEDIASERVICEINDEX  <= __FN_FOREND_VAL__2) ) : ( (MEDIASERVICEINDEX  <= __FN_FORSTART_VAL__2) && (MEDIASERVICEINDEX  >= __FN_FOREND_VAL__2) ) ; MEDIASERVICEINDEX  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 1727;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISAVAILABLE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1728;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISSELECTABLE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1729;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . ISBRANDED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1730;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . FRIENDLYNAME  =  ( ""  )  .ToString() ; 
            __context__.SourceCodeLine = 1731;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . STATE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1732;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . SUBSCRIPTIONSTATE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1733;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . SMALLIMAGEURL  =  ( ""  )  .ToString() ; 
            __context__.SourceCodeLine = 1734;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . MEDIUMIMAGEURL  =  ( ""  )  .ToString() ; 
            __context__.SourceCodeLine = 1735;
            CCD_MEDIASERVICES [ MEDIASERVICEINDEX] . LARGEIMAGEURL  =  ( ""  )  .ToString() ; 
            __context__.SourceCodeLine = 1725;
            } 
        
        __context__.SourceCodeLine = 1737;
        MEDIASERVICECOUNT = (ushort) ( MEDIASERVICECOUNTS ) ; 
        __context__.SourceCodeLine = 1738;
        NUMMEDIASERVICEPAGES  .Value = (ushort) ( CALCPAGENUMBERS( __context__ , (ushort)( MEDIASERVICECOUNTS ) ) ) ; 
        __context__.SourceCodeLine = 1739;
        MEDIASERVICECURRENTPAGE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1741;
        CURRENTMEDIASERVICEPAGE  .Value = (ushort) ( MEDIASERVICECURRENTPAGE ) ; 
        __context__.SourceCodeLine = 1743;
        OUTPUTMEDIASERVICESPAGE (  __context__ , (ushort)( 1 ), (ushort)( MEDIASERVICECOUNT )) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ACTIVEMEDIASERVICEPROVIDERCALLBACK ( SimplSharpString FRIENDLYNAME , ushort STATE , ushort SUBSCRIPTIONSTATE , SimplSharpString SMALLIMAGEURL , SimplSharpString MEDIUMIMAGEURL , SimplSharpString LARGEIMAGEURL ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1748;
        ACTIVEMEDIASERVICE_FRIENDLYNAME  .UpdateValue ( FRIENDLYNAME  .ToString()  ) ; 
        __context__.SourceCodeLine = 1749;
        ACTIVEMEDIASERVICE_STATE  .Value = (ushort) ( STATE ) ; 
        __context__.SourceCodeLine = 1750;
        ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE  .Value = (ushort) ( SUBSCRIPTIONSTATE ) ; 
        __context__.SourceCodeLine = 1751;
        ACTIVEMEDIASERVICE_SMALLIMAGEURL  .UpdateValue ( SMALLIMAGEURL  .ToString()  ) ; 
        __context__.SourceCodeLine = 1752;
        ACTIVEMEDIASERVICE_MEDIUMIMAGEURL  .UpdateValue ( MEDIUMIMAGEURL  .ToString()  ) ; 
        __context__.SourceCodeLine = 1753;
        ACTIVEMEDIASERVICE_LARGEIMAGEURL  .UpdateValue ( LARGEIMAGEURL  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ACTIVEMEDIASERVICEPROVIDERCALLBACK2 ( ushort ISSELECTABLE , ushort ISBRANDED ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1758;
        ACTIVEMEDIASERVICE_ISSELECTABLE  .Value = (ushort) ( ISSELECTABLE ) ; 
        __context__.SourceCodeLine = 1759;
        ACTIVEMEDIASERVICE_ISBRANDED  .Value = (ushort) ( ISBRANDED ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void ARTWORKCALLBACK ( ushort SUPPORTSARTWORKMODES , ushort SUPPORTSARWORKMODEONPOWEROFFS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1764;
        SUPPORTSARTWORKMODE  .Value = (ushort) ( SUPPORTSARTWORKMODES ) ; 
        __context__.SourceCodeLine = 1765;
        SUPPORTSARWORKMODEONPOWEROFF  .Value = (ushort) ( SUPPORTSARWORKMODEONPOWEROFFS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void VIDEOCONFIGURATIONCALLBACK ( ushort SUPPORTSDISPLAYMODESS , ushort DISPLAYMODECOUNT ) 
    { 
    ushort DISPLAYMODEINDEX = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1772;
        SUPPORTSDISPLAYMODES  .Value = (ushort) ( SUPPORTSDISPLAYMODESS ) ; 
        __context__.SourceCodeLine = 1774;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)DISPLAYMODECOUNT; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( DISPLAYMODEINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (DISPLAYMODEINDEX  >= __FN_FORSTART_VAL__1) && (DISPLAYMODEINDEX  <= __FN_FOREND_VAL__1) ) : ( (DISPLAYMODEINDEX  <= __FN_FORSTART_VAL__1) && (DISPLAYMODEINDEX  >= __FN_FOREND_VAL__1) ) ; DISPLAYMODEINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1776;
            DISPLAYMODE_ISAVAILABLE [ DISPLAYMODEINDEX]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1777;
            DISPLAYMODE_FRIENDLYNAME [ DISPLAYMODEINDEX]  .UpdateValue ( SIMPLSHARPCOMPONENT . SimplDisplayModes [ (DISPLAYMODEINDEX - 1)] . FriendlyName  ) ; 
            __context__.SourceCodeLine = 1774;
            } 
        
        __context__.SourceCodeLine = 1779;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( (DISPLAYMODECOUNT + 1) ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)15; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( DISPLAYMODEINDEX  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (DISPLAYMODEINDEX  >= __FN_FORSTART_VAL__2) && (DISPLAYMODEINDEX  <= __FN_FOREND_VAL__2) ) : ( (DISPLAYMODEINDEX  <= __FN_FORSTART_VAL__2) && (DISPLAYMODEINDEX  >= __FN_FOREND_VAL__2) ) ; DISPLAYMODEINDEX  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 1781;
            DISPLAYMODE_ISAVAILABLE [ DISPLAYMODEINDEX]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1782;
            DISPLAYMODE_FRIENDLYNAME [ DISPLAYMODEINDEX]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1779;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void DVRSUPPORTSCALLBACK ( ushort DVRCOMMANDS , ushort LIVES , ushort RECORDS , ushort SPEEDSLOWS , ushort THUMBSUPS , ushort THUMBSDOWNS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1788;
        SUPPORTSDVR  .Value = (ushort) ( DVRCOMMANDS ) ; 
        __context__.SourceCodeLine = 1789;
        SUPPORTSLIVE  .Value = (ushort) ( LIVES ) ; 
        __context__.SourceCodeLine = 1790;
        SUPPORTSRECORD  .Value = (ushort) ( RECORDS ) ; 
        __context__.SourceCodeLine = 1791;
        SUPPORTSSPEEDSLOW  .Value = (ushort) ( SPEEDSLOWS ) ; 
        __context__.SourceCodeLine = 1792;
        SUPPORTSTHUMBSUP  .Value = (ushort) ( THUMBSUPS ) ; 
        __context__.SourceCodeLine = 1793;
        SUPPORTSTHUMBSDOWN  .Value = (ushort) ( THUMBSDOWNS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CHANNELSUPPORTSCALLBACK ( ushort CHANNELFEEDBACKS , ushort CHANGECHANNELS , ushort SETCHANNELS , ushort GUIDES , ushort PAGECHANGES ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1798;
        SUPPORTSCHANNELFEEDBACK  .Value = (ushort) ( CHANNELFEEDBACKS ) ; 
        __context__.SourceCodeLine = 1799;
        SUPPORTSCHANGECHANNEL  .Value = (ushort) ( CHANGECHANNELS ) ; 
        __context__.SourceCodeLine = 1800;
        SUPPORTSSETCHANNEL  .Value = (ushort) ( SETCHANNELS ) ; 
        __context__.SourceCodeLine = 1801;
        SUPPORTSGUIDE  .Value = (ushort) ( GUIDES ) ; 
        __context__.SourceCodeLine = 1802;
        SUPPORTSPAGECHANGE  .Value = (ushort) ( PAGECHANGES ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CHANNELFEEDBACKCALLBACK ( SimplSharpString CHANNELIS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1807;
        CHANNEL_F  .UpdateValue ( CHANNELIS  .ToString()  ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void KEYPADSUPPORTSCALLBACK ( ushort KEYPADNUMBERS , ushort KEYPADPOUNDS , ushort KEYPADASTERISKS , ushort KEYPADBACKSPACES , ushort DASHS , ushort PERIODS , ushort ENTERS ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1812;
        SUPPORTSKEYPADNUMBER  .Value = (ushort) ( KEYPADNUMBERS ) ; 
        __context__.SourceCodeLine = 1813;
        SUPPORTSKEYPADPOUND  .Value = (ushort) ( KEYPADPOUNDS ) ; 
        __context__.SourceCodeLine = 1814;
        SUPPORTSKEYPADASTERISK  .Value = (ushort) ( KEYPADASTERISKS ) ; 
        __context__.SourceCodeLine = 1815;
        SUPPORTSKEYPADBACKSPACE  .Value = (ushort) ( KEYPADBACKSPACES ) ; 
        __context__.SourceCodeLine = 1816;
        SUPPORTSPERIOD  .Value = (ushort) ( DASHS ) ; 
        __context__.SourceCodeLine = 1817;
        SUPPORTSDASH  .Value = (ushort) ( PERIODS ) ; 
        __context__.SourceCodeLine = 1818;
        SUPPORTSENTER  .Value = (ushort) ( ENTERS ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void CUSTOMCOMMANDCALLBACK ( ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 1826;
        Functions.SetArray ( COMMANDEXISTS , (ushort)0) ; 
        __context__.SourceCodeLine = 1828;
        NUMCUSTOMCOMMANDS  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplNumCustomCommands ) ; 
        __context__.SourceCodeLine = 1829;
        NUMPAGES  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplNumPages ) ; 
        __context__.SourceCodeLine = 1830;
        CUSTOMCOMMANDPAGENUM  .Value = (ushort) ( SIMPLSHARPCOMPONENT.SimplCurrentPage ) ; 
        __context__.SourceCodeLine = 1832;
        CMDNAMEIN [ 0 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 0 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1833;
        CMDNAMEIN [ 1 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 1 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1834;
        CMDNAMEIN [ 2 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 2 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1835;
        CMDNAMEIN [ 3 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 3 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1836;
        CMDNAMEIN [ 4 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 4 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1837;
        CMDNAMEIN [ 5 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 5 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1838;
        CMDNAMEIN [ 6 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 6 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1839;
        CMDNAMEIN [ 7 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 7 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1840;
        CMDNAMEIN [ 8 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 8 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1841;
        CMDNAMEIN [ 9 ]  =  ( SIMPLSHARPCOMPONENT . SimplCustomCommandNames [ 9 ]  )  .ToString() ; 
        __context__.SourceCodeLine = 1844;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)9; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1846;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( CMDNAMEIN[ I ] ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (CMDNAMEIN[ I ] != "-") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1848;
                COMMANDEXISTS [ (I + 1)]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 1849;
                COMMANDNAMEOUT [ (I + 1)]  .UpdateValue ( CMDNAMEIN [ I ]  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1853;
                COMMANDNAMEOUT [ (I + 1)]  .UpdateValue ( ""  ) ; 
                } 
            
            __context__.SourceCodeLine = 1844;
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
private void REGISTERDELEGATES (  SplusExecutionContext __context__ ) 
    { 
    
    __context__.SourceCodeLine = 1862;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , BASICINFORMATIONUPDATED , BASICINFORMATIONCALLBACK ) 
    SIMPLSHARPCOMPONENT .BasicInformationUpdated  = BASICINFORMATIONCALLBACK; ; 
    __context__.SourceCodeLine = 1863;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , TXUPDATED , TXCALLBACK ) 
    SIMPLSHARPCOMPONENT .TxUpdated  = TXCALLBACK; ; 
    __context__.SourceCodeLine = 1864;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , PACKETTXUPDATED , PACKETTXCALLBACK ) 
    SIMPLSHARPCOMPONENT .PacketTxUpdated  = PACKETTXCALLBACK; ; 
    __context__.SourceCodeLine = 1865;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , LOGOUT , LOGOUTCALLBACK ) 
    SIMPLSHARPCOMPONENT .LogOut  = LOGOUTCALLBACK; ; 
    __context__.SourceCodeLine = 1866;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , RXOUT , RXOUTUPDATECALLBACK ) 
    SIMPLSHARPCOMPONENT .RxOut  = RXOUTUPDATECALLBACK; ; 
    __context__.SourceCodeLine = 1867;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , BASICCONNECTIONSUPPORTSUPDATED , BASICCONNECTIONSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .BasicConnectionSupportsUpdated  = BASICCONNECTIONSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1868;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , CUSTOMIRCOMMANDSUPPORTSUPDATEAD , CUSTOMIRCOMMANDSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .CustomIrCommandSupportsUpdatead  = CUSTOMIRCOMMANDSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1869;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DRIVERLOADEDCALLBACK , DRIVERLOADEDCB ) 
    SIMPLSHARPCOMPONENT .DriverLoadedCallback  = DRIVERLOADEDCB; ; 
    __context__.SourceCodeLine = 1870;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DRIVERAUTHENTICATIONSUPPORTSCALLBACK , DRIVERAUTHSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .DriverAuthenticationSupportsCallback  = DRIVERAUTHSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1871;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DRIVERAUTHENTICATIONUPDATECALLBACK , DRIVERAUTHUPDATECALLBACK ) 
    SIMPLSHARPCOMPONENT .DriverAuthenticationUpdateCallback  = DRIVERAUTHUPDATECALLBACK; ; 
    __context__.SourceCodeLine = 1872;
    // RegisterDelegate( SYSTEMMODULE , MANIFESTUPDATED , MANIFESTUPDATEDCALLBACK ) 
    SYSTEMMODULE .ManifestUpdated  = MANIFESTUPDATEDCALLBACK; ; 
    __context__.SourceCodeLine = 1873;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DRIVERCUSTOMCOMMANDCALLBACK , CUSTOMCOMMANDCALLBACK ) 
    SIMPLSHARPCOMPONENT .DriverCustomCommandCallback  = CUSTOMCOMMANDCALLBACK; ; 
    __context__.SourceCodeLine = 1876;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DISPLAYSTATUSUPDATED , DISPLAYSTATUSCALLBACK ) 
    SIMPLSHARPCOMPONENT .DisplayStatusUpdated  = DISPLAYSTATUSCALLBACK; ; 
    __context__.SourceCodeLine = 1877;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , POWERSUPPORTSUPDATED , POWERSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .PowerSupportsUpdated  = POWERSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1878;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , INPUTSSUPPORTSUPDATED , BASICINPUTSSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .InputsSupportsUpdated  = BASICINPUTSSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1879;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , VOLUMESUPPORTSUPDATED , VOLUMESUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .VolumeSupportsUpdated  = VOLUMESUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1880;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , INPUTDETAILSUPDATED , INPUTDETAILSCALLBACK ) 
    SIMPLSHARPCOMPONENT .InputDetailsUpdated  = INPUTDETAILSCALLBACK; ; 
    __context__.SourceCodeLine = 1881;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , VIDEODISPLAYSUPPORTSUPDATED , VIDEODISPLAYSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .VideoDisplaySupportsUpdated  = VIDEODISPLAYSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1882;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , LAMPHOURSUPDATED , LAMPHOURSCALLBACK ) 
    SIMPLSHARPCOMPONENT .LampHoursUpdated  = LAMPHOURSCALLBACK; ; 
    __context__.SourceCodeLine = 1883;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , NAVIGATIONSUPPORTSUPDATED , NAVIGATIONSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .NavigationSupportsUpdated  = NAVIGATIONSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1884;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , MEDIASUPPORTSUPDATED , MEDIASUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .MediaSupportsUpdated  = MEDIASUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1885;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , MEDIATRANSPORTSUPDATED , MEDIATRANSPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .MediaTransportsUpdated  = MEDIATRANSPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1886;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , ENERGYSTARSUPPORTSUPDATED , ENERGYSTARSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .EnergyStarSupportsUpdated  = ENERGYSTARSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1888;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , MEDIASERVICEPROVIDERUPDATED , MEDIASERVICEPROVIDERCALLBACK ) 
    SIMPLSHARPCOMPONENT .MediaServiceProviderUpdated  = MEDIASERVICEPROVIDERCALLBACK; ; 
    __context__.SourceCodeLine = 1889;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , ACTIVEMEDIASERVICEPROVIDERUPDATED , ACTIVEMEDIASERVICEPROVIDERCALLBACK ) 
    SIMPLSHARPCOMPONENT .ActiveMediaServiceProviderUpdated  = ACTIVEMEDIASERVICEPROVIDERCALLBACK; ; 
    __context__.SourceCodeLine = 1890;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , ACTIVEMEDIASERVICEPROVIDERUPDATED2 , ACTIVEMEDIASERVICEPROVIDERCALLBACK2 ) 
    SIMPLSHARPCOMPONENT .ActiveMediaServiceProviderUpdated2  = ACTIVEMEDIASERVICEPROVIDERCALLBACK2; ; 
    __context__.SourceCodeLine = 1891;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , ARTWORKUPDATED , ARTWORKCALLBACK ) 
    SIMPLSHARPCOMPONENT .ArtworkUpdated  = ARTWORKCALLBACK; ; 
    __context__.SourceCodeLine = 1892;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , VIDEOCONFIGURATIONUPDATED , VIDEOCONFIGURATIONCALLBACK ) 
    SIMPLSHARPCOMPONENT .VideoConfigurationUpdated  = VIDEOCONFIGURATIONCALLBACK; ; 
    __context__.SourceCodeLine = 1894;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , CHANNELSUPPORTSUPDATED , CHANNELSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .ChannelSupportsUpdated  = CHANNELSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1895;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , CHANNELFEEDBACKUPDATED , CHANNELFEEDBACKCALLBACK ) 
    SIMPLSHARPCOMPONENT .ChannelFeedbackUpdated  = CHANNELFEEDBACKCALLBACK; ; 
    __context__.SourceCodeLine = 1896;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , KEYPADSUPPORTSUPDATED , KEYPADSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .KeypadSupportsUpdated  = KEYPADSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1897;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DVRSUPPORTSUPDATED , DVRSUPPORTSCALLBACK ) 
    SIMPLSHARPCOMPONENT .DvrSupportsUpdated  = DVRSUPPORTSCALLBACK; ; 
    __context__.SourceCodeLine = 1898;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , DISPLAYSTATUS2UPDATED , DISPLAYSTATUS2CALLBACK ) 
    SIMPLSHARPCOMPONENT .DisplayStatus2Updated  = DISPLAYSTATUS2CALLBACK; ; 
    __context__.SourceCodeLine = 1899;
    // RegisterDelegate( SIMPLSHARPCOMPONENT , INPUTDETAILS2UPDATED , INPUTDETAILS2CALLBACK ) 
    SIMPLSHARPCOMPONENT .InputDetails2Updated  = INPUTDETAILS2CALLBACK; ; 
    
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 1905;
        _INITILIZATIONCOMPLETE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1906;
        _DRIVERFILENAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1908;
        ACTIVEINPUTTYPE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1910;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 1912;
        REGISTERDELEGATES (  __context__  ) ; 
        __context__.SourceCodeLine = 1913;
        Functions.GatherAsync ( 1, RX , HANDLERXCHANGE ) ; 
        __context__.SourceCodeLine = 1914;
        _INITILIZATIONCOMPLETE = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _DRIVERFILENAME  = new CrestronString( InheritedStringEncoding, 200, this );
    CMDNAMEIN  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        CMDNAMEIN [i] = new CrestronString( InheritedStringEncoding, 200, this );
    CCD_MEDIASERVICES  = new MEDIASERVICESTRUC[ 101 ];
    for( uint i = 0; i < 101; i++ )
    {
        CCD_MEDIASERVICES [i] = new MEDIASERVICESTRUC( this, true );
        CCD_MEDIASERVICES [i].PopulateCustomAttributeList( false );
        
    }
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    CECINITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( CECINITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( CECINITIALIZE__DigitalInput__, CECINITIALIZE );
    
    POWERON = new Crestron.Logos.SplusObjects.DigitalInput( POWERON__DigitalInput__, this );
    m_DigitalInputList.Add( POWERON__DigitalInput__, POWERON );
    
    POWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( POWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWEROFF__DigitalInput__, POWEROFF );
    
    POWERTOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( POWERTOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( POWERTOGGLE__DigitalInput__, POWERTOGGLE );
    
    UPARROW = new Crestron.Logos.SplusObjects.DigitalInput( UPARROW__DigitalInput__, this );
    m_DigitalInputList.Add( UPARROW__DigitalInput__, UPARROW );
    
    DOWNARROW = new Crestron.Logos.SplusObjects.DigitalInput( DOWNARROW__DigitalInput__, this );
    m_DigitalInputList.Add( DOWNARROW__DigitalInput__, DOWNARROW );
    
    LEFTARROW = new Crestron.Logos.SplusObjects.DigitalInput( LEFTARROW__DigitalInput__, this );
    m_DigitalInputList.Add( LEFTARROW__DigitalInput__, LEFTARROW );
    
    RIGHTARROW = new Crestron.Logos.SplusObjects.DigitalInput( RIGHTARROW__DigitalInput__, this );
    m_DigitalInputList.Add( RIGHTARROW__DigitalInput__, RIGHTARROW );
    
    SELECT = new Crestron.Logos.SplusObjects.DigitalInput( SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT__DigitalInput__, SELECT );
    
    CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR__DigitalInput__, CLEAR );
    
    EXIT = new Crestron.Logos.SplusObjects.DigitalInput( EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( EXIT__DigitalInput__, EXIT );
    
    HOME = new Crestron.Logos.SplusObjects.DigitalInput( HOME__DigitalInput__, this );
    m_DigitalInputList.Add( HOME__DigitalInput__, HOME );
    
    MENU = new Crestron.Logos.SplusObjects.DigitalInput( MENU__DigitalInput__, this );
    m_DigitalInputList.Add( MENU__DigitalInput__, MENU );
    
    SEARCH = new Crestron.Logos.SplusObjects.DigitalInput( SEARCH__DigitalInput__, this );
    m_DigitalInputList.Add( SEARCH__DigitalInput__, SEARCH );
    
    YOUTUBE = new Crestron.Logos.SplusObjects.DigitalInput( YOUTUBE__DigitalInput__, this );
    m_DigitalInputList.Add( YOUTUBE__DigitalInput__, YOUTUBE );
    
    YOUTUBETV = new Crestron.Logos.SplusObjects.DigitalInput( YOUTUBETV__DigitalInput__, this );
    m_DigitalInputList.Add( YOUTUBETV__DigitalInput__, YOUTUBETV );
    
    NETFLIX = new Crestron.Logos.SplusObjects.DigitalInput( NETFLIX__DigitalInput__, this );
    m_DigitalInputList.Add( NETFLIX__DigitalInput__, NETFLIX );
    
    HULU = new Crestron.Logos.SplusObjects.DigitalInput( HULU__DigitalInput__, this );
    m_DigitalInputList.Add( HULU__DigitalInput__, HULU );
    
    DIRECTVNOW = new Crestron.Logos.SplusObjects.DigitalInput( DIRECTVNOW__DigitalInput__, this );
    m_DigitalInputList.Add( DIRECTVNOW__DigitalInput__, DIRECTVNOW );
    
    AMAZONVIDEO = new Crestron.Logos.SplusObjects.DigitalInput( AMAZONVIDEO__DigitalInput__, this );
    m_DigitalInputList.Add( AMAZONVIDEO__DigitalInput__, AMAZONVIDEO );
    
    PLAYSTATIONVUE = new Crestron.Logos.SplusObjects.DigitalInput( PLAYSTATIONVUE__DigitalInput__, this );
    m_DigitalInputList.Add( PLAYSTATIONVUE__DigitalInput__, PLAYSTATIONVUE );
    
    SLINGTV = new Crestron.Logos.SplusObjects.DigitalInput( SLINGTV__DigitalInput__, this );
    m_DigitalInputList.Add( SLINGTV__DigitalInput__, SLINGTV );
    
    FORWARDSCAN = new Crestron.Logos.SplusObjects.DigitalInput( FORWARDSCAN__DigitalInput__, this );
    m_DigitalInputList.Add( FORWARDSCAN__DigitalInput__, FORWARDSCAN );
    
    REVERSESCAN = new Crestron.Logos.SplusObjects.DigitalInput( REVERSESCAN__DigitalInput__, this );
    m_DigitalInputList.Add( REVERSESCAN__DigitalInput__, REVERSESCAN );
    
    PLAY = new Crestron.Logos.SplusObjects.DigitalInput( PLAY__DigitalInput__, this );
    m_DigitalInputList.Add( PLAY__DigitalInput__, PLAY );
    
    PAUSE = new Crestron.Logos.SplusObjects.DigitalInput( PAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( PAUSE__DigitalInput__, PAUSE );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    FORWARDSKIP = new Crestron.Logos.SplusObjects.DigitalInput( FORWARDSKIP__DigitalInput__, this );
    m_DigitalInputList.Add( FORWARDSKIP__DigitalInput__, FORWARDSKIP );
    
    REVERSESKIP = new Crestron.Logos.SplusObjects.DigitalInput( REVERSESKIP__DigitalInput__, this );
    m_DigitalInputList.Add( REVERSESKIP__DigitalInput__, REVERSESKIP );
    
    REPEAT = new Crestron.Logos.SplusObjects.DigitalInput( REPEAT__DigitalInput__, this );
    m_DigitalInputList.Add( REPEAT__DigitalInput__, REPEAT );
    
    RETURNCOMMAND = new Crestron.Logos.SplusObjects.DigitalInput( RETURNCOMMAND__DigitalInput__, this );
    m_DigitalInputList.Add( RETURNCOMMAND__DigitalInput__, RETURNCOMMAND );
    
    BACK = new Crestron.Logos.SplusObjects.DigitalInput( BACK__DigitalInput__, this );
    m_DigitalInputList.Add( BACK__DigitalInput__, BACK );
    
    PLAYPAUSE = new Crestron.Logos.SplusObjects.DigitalInput( PLAYPAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( PLAYPAUSE__DigitalInput__, PLAYPAUSE );
    
    OPTIONS = new Crestron.Logos.SplusObjects.DigitalInput( OPTIONS__DigitalInput__, this );
    m_DigitalInputList.Add( OPTIONS__DigitalInput__, OPTIONS );
    
    INFO = new Crestron.Logos.SplusObjects.DigitalInput( INFO__DigitalInput__, this );
    m_DigitalInputList.Add( INFO__DigitalInput__, INFO );
    
    MUTEON = new Crestron.Logos.SplusObjects.DigitalInput( MUTEON__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEON__DigitalInput__, MUTEON );
    
    MUTEOFF = new Crestron.Logos.SplusObjects.DigitalInput( MUTEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEOFF__DigitalInput__, MUTEOFF );
    
    MUTETOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( MUTETOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTETOGGLE__DigitalInput__, MUTETOGGLE );
    
    VOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEUP__DigitalInput__, VOLUMEUP );
    
    VOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEDOWN__DigitalInput__, VOLUMEDOWN );
    
    SETVOLUMEUP = new Crestron.Logos.SplusObjects.DigitalInput( SETVOLUMEUP__DigitalInput__, this );
    m_DigitalInputList.Add( SETVOLUMEUP__DigitalInput__, SETVOLUMEUP );
    
    SETVOLUMEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( SETVOLUMEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SETVOLUMEDOWN__DigitalInput__, SETVOLUMEDOWN );
    
    VIDEOMUTEON = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTEON__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTEON__DigitalInput__, VIDEOMUTEON );
    
    VIDEOMUTEOFF = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTEOFF__DigitalInput__, VIDEOMUTEOFF );
    
    VIDEOMUTETOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( VIDEOMUTETOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( VIDEOMUTETOGGLE__DigitalInput__, VIDEOMUTETOGGLE );
    
    ENABLERXOUT = new Crestron.Logos.SplusObjects.DigitalInput( ENABLERXOUT__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLERXOUT__DigitalInput__, ENABLERXOUT );
    
    DISCONNECT = new Crestron.Logos.SplusObjects.DigitalInput( DISCONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( DISCONNECT__DigitalInput__, DISCONNECT );
    
    RECONNECT = new Crestron.Logos.SplusObjects.DigitalInput( RECONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( RECONNECT__DigitalInput__, RECONNECT );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalInput( CONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECT__DigitalInput__, CONNECT );
    
    ENABLELOGGING = new Crestron.Logos.SplusObjects.DigitalInput( ENABLELOGGING__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLELOGGING__DigitalInput__, ENABLELOGGING );
    
    ENABLETXDEBUG = new Crestron.Logos.SplusObjects.DigitalInput( ENABLETXDEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLETXDEBUG__DigitalInput__, ENABLETXDEBUG );
    
    ENABLERXDEBUG = new Crestron.Logos.SplusObjects.DigitalInput( ENABLERXDEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLERXDEBUG__DigitalInput__, ENABLERXDEBUG );
    
    DVR = new Crestron.Logos.SplusObjects.DigitalInput( DVR__DigitalInput__, this );
    m_DigitalInputList.Add( DVR__DigitalInput__, DVR );
    
    LIVE = new Crestron.Logos.SplusObjects.DigitalInput( LIVE__DigitalInput__, this );
    m_DigitalInputList.Add( LIVE__DigitalInput__, LIVE );
    
    RECORD = new Crestron.Logos.SplusObjects.DigitalInput( RECORD__DigitalInput__, this );
    m_DigitalInputList.Add( RECORD__DigitalInput__, RECORD );
    
    SPEEDSLOW = new Crestron.Logos.SplusObjects.DigitalInput( SPEEDSLOW__DigitalInput__, this );
    m_DigitalInputList.Add( SPEEDSLOW__DigitalInput__, SPEEDSLOW );
    
    THUMBSUP = new Crestron.Logos.SplusObjects.DigitalInput( THUMBSUP__DigitalInput__, this );
    m_DigitalInputList.Add( THUMBSUP__DigitalInput__, THUMBSUP );
    
    THUMBSDOWN = new Crestron.Logos.SplusObjects.DigitalInput( THUMBSDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( THUMBSDOWN__DigitalInput__, THUMBSDOWN );
    
    CHANNELDOWN = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELDOWN__DigitalInput__, CHANNELDOWN );
    
    CHANNELUP = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELUP__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELUP__DigitalInput__, CHANNELUP );
    
    GUIDE = new Crestron.Logos.SplusObjects.DigitalInput( GUIDE__DigitalInput__, this );
    m_DigitalInputList.Add( GUIDE__DigitalInput__, GUIDE );
    
    PAGEDOWN = new Crestron.Logos.SplusObjects.DigitalInput( PAGEDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( PAGEDOWN__DigitalInput__, PAGEDOWN );
    
    PAGEUP = new Crestron.Logos.SplusObjects.DigitalInput( PAGEUP__DigitalInput__, this );
    m_DigitalInputList.Add( PAGEUP__DigitalInput__, PAGEUP );
    
    SETCHANNEL_SENDENTERAFTERSEQUENCE = new Crestron.Logos.SplusObjects.DigitalInput( SETCHANNEL_SENDENTERAFTERSEQUENCE__DigitalInput__, this );
    m_DigitalInputList.Add( SETCHANNEL_SENDENTERAFTERSEQUENCE__DigitalInput__, SETCHANNEL_SENDENTERAFTERSEQUENCE );
    
    _0 = new Crestron.Logos.SplusObjects.DigitalInput( _0__DigitalInput__, this );
    m_DigitalInputList.Add( _0__DigitalInput__, _0 );
    
    _1 = new Crestron.Logos.SplusObjects.DigitalInput( _1__DigitalInput__, this );
    m_DigitalInputList.Add( _1__DigitalInput__, _1 );
    
    _2 = new Crestron.Logos.SplusObjects.DigitalInput( _2__DigitalInput__, this );
    m_DigitalInputList.Add( _2__DigitalInput__, _2 );
    
    _3 = new Crestron.Logos.SplusObjects.DigitalInput( _3__DigitalInput__, this );
    m_DigitalInputList.Add( _3__DigitalInput__, _3 );
    
    _4 = new Crestron.Logos.SplusObjects.DigitalInput( _4__DigitalInput__, this );
    m_DigitalInputList.Add( _4__DigitalInput__, _4 );
    
    _5 = new Crestron.Logos.SplusObjects.DigitalInput( _5__DigitalInput__, this );
    m_DigitalInputList.Add( _5__DigitalInput__, _5 );
    
    _6 = new Crestron.Logos.SplusObjects.DigitalInput( _6__DigitalInput__, this );
    m_DigitalInputList.Add( _6__DigitalInput__, _6 );
    
    _7 = new Crestron.Logos.SplusObjects.DigitalInput( _7__DigitalInput__, this );
    m_DigitalInputList.Add( _7__DigitalInput__, _7 );
    
    _8 = new Crestron.Logos.SplusObjects.DigitalInput( _8__DigitalInput__, this );
    m_DigitalInputList.Add( _8__DigitalInput__, _8 );
    
    _9 = new Crestron.Logos.SplusObjects.DigitalInput( _9__DigitalInput__, this );
    m_DigitalInputList.Add( _9__DigitalInput__, _9 );
    
    KEYPADPOUND = new Crestron.Logos.SplusObjects.DigitalInput( KEYPADPOUND__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPADPOUND__DigitalInput__, KEYPADPOUND );
    
    KEYPADASTERISK = new Crestron.Logos.SplusObjects.DigitalInput( KEYPADASTERISK__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPADASTERISK__DigitalInput__, KEYPADASTERISK );
    
    KEYPADBACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( KEYPADBACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPADBACKSPACE__DigitalInput__, KEYPADBACKSPACE );
    
    PERIOD = new Crestron.Logos.SplusObjects.DigitalInput( PERIOD__DigitalInput__, this );
    m_DigitalInputList.Add( PERIOD__DigitalInput__, PERIOD );
    
    DASH = new Crestron.Logos.SplusObjects.DigitalInput( DASH__DigitalInput__, this );
    m_DigitalInputList.Add( DASH__DigitalInput__, DASH );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalInput( ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER__DigitalInput__, ENTER );
    
    ARTWORKON = new Crestron.Logos.SplusObjects.DigitalInput( ARTWORKON__DigitalInput__, this );
    m_DigitalInputList.Add( ARTWORKON__DigitalInput__, ARTWORKON );
    
    ARTWORKOFF = new Crestron.Logos.SplusObjects.DigitalInput( ARTWORKOFF__DigitalInput__, this );
    m_DigitalInputList.Add( ARTWORKOFF__DigitalInput__, ARTWORKOFF );
    
    ENABLEARTWORKONPOWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( ENABLEARTWORKONPOWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLEARTWORKONPOWEROFF__DigitalInput__, ENABLEARTWORKONPOWEROFF );
    
    DISABLEARTWORKONPOWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( DISABLEARTWORKONPOWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( DISABLEARTWORKONPOWEROFF__DigitalInput__, DISABLEARTWORKONPOWEROFF );
    
    A = new Crestron.Logos.SplusObjects.DigitalInput( A__DigitalInput__, this );
    m_DigitalInputList.Add( A__DigitalInput__, A );
    
    B = new Crestron.Logos.SplusObjects.DigitalInput( B__DigitalInput__, this );
    m_DigitalInputList.Add( B__DigitalInput__, B );
    
    C = new Crestron.Logos.SplusObjects.DigitalInput( C__DigitalInput__, this );
    m_DigitalInputList.Add( C__DigitalInput__, C );
    
    D = new Crestron.Logos.SplusObjects.DigitalInput( D__DigitalInput__, this );
    m_DigitalInputList.Add( D__DigitalInput__, D );
    
    RED = new Crestron.Logos.SplusObjects.DigitalInput( RED__DigitalInput__, this );
    m_DigitalInputList.Add( RED__DigitalInput__, RED );
    
    GREEN = new Crestron.Logos.SplusObjects.DigitalInput( GREEN__DigitalInput__, this );
    m_DigitalInputList.Add( GREEN__DigitalInput__, GREEN );
    
    BLUE = new Crestron.Logos.SplusObjects.DigitalInput( BLUE__DigitalInput__, this );
    m_DigitalInputList.Add( BLUE__DigitalInput__, BLUE );
    
    YELLOW = new Crestron.Logos.SplusObjects.DigitalInput( YELLOW__DigitalInput__, this );
    m_DigitalInputList.Add( YELLOW__DigitalInput__, YELLOW );
    
    CMDGROUPUP = new Crestron.Logos.SplusObjects.DigitalInput( CMDGROUPUP__DigitalInput__, this );
    m_DigitalInputList.Add( CMDGROUPUP__DigitalInput__, CMDGROUPUP );
    
    CMDGROUPDOWN = new Crestron.Logos.SplusObjects.DigitalInput( CMDGROUPDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CMDGROUPDOWN__DigitalInput__, CMDGROUPDOWN );
    
    NEXTMEDIASERVICEPAGE = new Crestron.Logos.SplusObjects.DigitalInput( NEXTMEDIASERVICEPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( NEXTMEDIASERVICEPAGE__DigitalInput__, NEXTMEDIASERVICEPAGE );
    
    PREVMEDIASERVICEPAGE = new Crestron.Logos.SplusObjects.DigitalInput( PREVMEDIASERVICEPAGE__DigitalInput__, this );
    m_DigitalInputList.Add( PREVMEDIASERVICEPAGE__DigitalInput__, PREVMEDIASERVICEPAGE );
    
    TRIGGERCOMMAND = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        TRIGGERCOMMAND[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TRIGGERCOMMAND__DigitalInput__ + i, TRIGGERCOMMAND__DigitalInput__, this );
        m_DigitalInputList.Add( TRIGGERCOMMAND__DigitalInput__ + i, TRIGGERCOMMAND[i+1] );
    }
    
    USERATTRIBUTE_SENDITIN = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_SENDITIN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( USERATTRIBUTE_SENDITIN__DigitalInput__ + i, USERATTRIBUTE_SENDITIN__DigitalInput__, this );
        m_DigitalInputList.Add( USERATTRIBUTE_SENDITIN__DigitalInput__ + i, USERATTRIBUTE_SENDITIN[i+1] );
    }
    
    USERATTRIBUTE_DIGITALVALUE = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_DIGITALVALUE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( USERATTRIBUTE_DIGITALVALUE__DigitalInput__ + i, USERATTRIBUTE_DIGITALVALUE__DigitalInput__, this );
        m_DigitalInputList.Add( USERATTRIBUTE_DIGITALVALUE__DigitalInput__ + i, USERATTRIBUTE_DIGITALVALUE[i+1] );
    }
    
    SELECTMEDIASERVICE = new InOutArray<DigitalInput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        SELECTMEDIASERVICE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SELECTMEDIASERVICE__DigitalInput__ + i, SELECTMEDIASERVICE__DigitalInput__, this );
        m_DigitalInputList.Add( SELECTMEDIASERVICE__DigitalInput__ + i, SELECTMEDIASERVICE[i+1] );
    }
    
    SELECTDISPLAYMODE = new InOutArray<DigitalInput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        SELECTDISPLAYMODE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SELECTDISPLAYMODE__DigitalInput__ + i, SELECTDISPLAYMODE__DigitalInput__, this );
        m_DigitalInputList.Add( SELECTDISPLAYMODE__DigitalInput__ + i, SELECTDISPLAYMODE[i+1] );
    }
    
    DRIVERLOADED = new Crestron.Logos.SplusObjects.DigitalOutput( DRIVERLOADED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DRIVERLOADED__DigitalOutput__, DRIVERLOADED );
    
    REBOOTREQUIRED = new Crestron.Logos.SplusObjects.DigitalOutput( REBOOTREQUIRED__DigitalOutput__, this );
    m_DigitalOutputList.Add( REBOOTREQUIRED__DigitalOutput__, REBOOTREQUIRED );
    
    SUPPORTSFEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSFEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSFEEDBACK__DigitalOutput__, SUPPORTSFEEDBACK );
    
    SUPPORTSUSERNAME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSUSERNAME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSUSERNAME__DigitalOutput__, SUPPORTSUSERNAME );
    
    SUPPORTSPASSWORD = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPASSWORD__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPASSWORD__DigitalOutput__, SUPPORTSPASSWORD );
    
    AUTHENTICATIONISREQUIRED = new Crestron.Logos.SplusObjects.DigitalOutput( AUTHENTICATIONISREQUIRED__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTHENTICATIONISREQUIRED__DigitalOutput__, AUTHENTICATIONISREQUIRED );
    
    SUPPORTSPOWER_F = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPOWER_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPOWER_F__DigitalOutput__, SUPPORTSPOWER_F );
    
    POWER_F = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_F__DigitalOutput__, POWER_F );
    
    SUPPORTSDISCRETEPOWER = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDISCRETEPOWER__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDISCRETEPOWER__DigitalOutput__, SUPPORTSDISCRETEPOWER );
    
    SUPPORTSTOGGLEPOWER = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSTOGGLEPOWER__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSTOGGLEPOWER__DigitalOutput__, SUPPORTSTOGGLEPOWER );
    
    SUPPORTSWARMUPTIME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSWARMUPTIME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSWARMUPTIME__DigitalOutput__, SUPPORTSWARMUPTIME );
    
    SUPPORTSCOOLDOWNTIME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSCOOLDOWNTIME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSCOOLDOWNTIME__DigitalOutput__, SUPPORTSCOOLDOWNTIME );
    
    WARMINGUP = new Crestron.Logos.SplusObjects.DigitalOutput( WARMINGUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( WARMINGUP__DigitalOutput__, WARMINGUP );
    
    COOLINGDOWN = new Crestron.Logos.SplusObjects.DigitalOutput( COOLINGDOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( COOLINGDOWN__DigitalOutput__, COOLINGDOWN );
    
    SUPPORTSINPUT_F = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSINPUT_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSINPUT_F__DigitalOutput__, SUPPORTSINPUT_F );
    
    SUPPORTSSETINPUT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSETINPUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSETINPUT__DigitalOutput__, SUPPORTSSETINPUT );
    
    SUPPORTSARROWKEYS = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARROWKEYS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARROWKEYS__DigitalOutput__, SUPPORTSARROWKEYS );
    
    SUPPORTSARROWUP = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARROWUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARROWUP__DigitalOutput__, SUPPORTSARROWUP );
    
    SUPPORTSARROWDOWN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARROWDOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARROWDOWN__DigitalOutput__, SUPPORTSARROWDOWN );
    
    SUPPORTSARROWLEFT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARROWLEFT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARROWLEFT__DigitalOutput__, SUPPORTSARROWLEFT );
    
    SUPPORTSARROWRIGHT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARROWRIGHT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARROWRIGHT__DigitalOutput__, SUPPORTSARROWRIGHT );
    
    SUPPORTSSELECT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSELECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSELECT__DigitalOutput__, SUPPORTSSELECT );
    
    SUPPORTSCLEAR = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSCLEAR__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSCLEAR__DigitalOutput__, SUPPORTSCLEAR );
    
    SUPPORTSEXIT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSEXIT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSEXIT__DigitalOutput__, SUPPORTSEXIT );
    
    SUPPORTSHOME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSHOME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSHOME__DigitalOutput__, SUPPORTSHOME );
    
    SUPPORTSMENU = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSMENU__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSMENU__DigitalOutput__, SUPPORTSMENU );
    
    SUPPORTSSEARCH = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSEARCH__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSEARCH__DigitalOutput__, SUPPORTSSEARCH );
    
    SUPPORTSYOUTUBE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSYOUTUBE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSYOUTUBE__DigitalOutput__, SUPPORTSYOUTUBE );
    
    SUPPORTSYOUTUBETV = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSYOUTUBETV__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSYOUTUBETV__DigitalOutput__, SUPPORTSYOUTUBETV );
    
    SUPPORTSNETFLIX = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSNETFLIX__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSNETFLIX__DigitalOutput__, SUPPORTSNETFLIX );
    
    SUPPORTSHULU = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSHULU__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSHULU__DigitalOutput__, SUPPORTSHULU );
    
    SUPPORTSDIRECTVNOW = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDIRECTVNOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDIRECTVNOW__DigitalOutput__, SUPPORTSDIRECTVNOW );
    
    SUPPORTSAMAZONVIDEO = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSAMAZONVIDEO__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSAMAZONVIDEO__DigitalOutput__, SUPPORTSAMAZONVIDEO );
    
    SUPPORTSPLAYSTATIONVUE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPLAYSTATIONVUE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPLAYSTATIONVUE__DigitalOutput__, SUPPORTSPLAYSTATIONVUE );
    
    SUPPORTSSLINGTV = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSLINGTV__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSLINGTV__DigitalOutput__, SUPPORTSSLINGTV );
    
    SUPPORTSFORWARDSCAN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSFORWARDSCAN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSFORWARDSCAN__DigitalOutput__, SUPPORTSFORWARDSCAN );
    
    SUPPORTSREVERSESCAN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSREVERSESCAN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSREVERSESCAN__DigitalOutput__, SUPPORTSREVERSESCAN );
    
    SUPPORTSPLAY = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPLAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPLAY__DigitalOutput__, SUPPORTSPLAY );
    
    SUPPORTSPAUSE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPAUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPAUSE__DigitalOutput__, SUPPORTSPAUSE );
    
    SUPPORTSSTOP = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSTOP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSTOP__DigitalOutput__, SUPPORTSSTOP );
    
    SUPPORTSFORWARDSKIP = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSFORWARDSKIP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSFORWARDSKIP__DigitalOutput__, SUPPORTSFORWARDSKIP );
    
    SUPPORTSREVERSESKIP = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSREVERSESKIP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSREVERSESKIP__DigitalOutput__, SUPPORTSREVERSESKIP );
    
    SUPPORTSREPEAT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSREPEAT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSREPEAT__DigitalOutput__, SUPPORTSREPEAT );
    
    SUPPORTSRETURN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSRETURN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSRETURN__DigitalOutput__, SUPPORTSRETURN );
    
    SUPPORTSBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSBACK__DigitalOutput__, SUPPORTSBACK );
    
    SUPPORTSPLAYPAUSE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPLAYPAUSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPLAYPAUSE__DigitalOutput__, SUPPORTSPLAYPAUSE );
    
    SUPPORTSOPTIONS = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSOPTIONS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSOPTIONS__DigitalOutput__, SUPPORTSOPTIONS );
    
    SUPPORTSINFO = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSINFO__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSINFO__DigitalOutput__, SUPPORTSINFO );
    
    SUPPORTSVOLUME_F = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSVOLUME_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSVOLUME_F__DigitalOutput__, SUPPORTSVOLUME_F );
    
    SUPPORTSMUTE_F = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSMUTE_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSMUTE_F__DigitalOutput__, SUPPORTSMUTE_F );
    
    MUTE_F = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_F__DigitalOutput__, MUTE_F );
    
    SUPPORTSDISCRETEMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDISCRETEMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDISCRETEMUTE__DigitalOutput__, SUPPORTSDISCRETEMUTE );
    
    SUPPORTSMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSMUTE__DigitalOutput__, SUPPORTSMUTE );
    
    SUPPORTSSETVOLUME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSETVOLUME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSETVOLUME__DigitalOutput__, SUPPORTSSETVOLUME );
    
    SUPPORTSCHANGEVOLUME = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSCHANGEVOLUME__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSCHANGEVOLUME__DigitalOutput__, SUPPORTSCHANGEVOLUME );
    
    SUPPORTSVIDEOMUTE_F = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSVIDEOMUTE_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSVIDEOMUTE_F__DigitalOutput__, SUPPORTSVIDEOMUTE_F );
    
    VIDEOMUTE_F = new Crestron.Logos.SplusObjects.DigitalOutput( VIDEOMUTE_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( VIDEOMUTE_F__DigitalOutput__, VIDEOMUTE_F );
    
    SUPPORTSDISCRETEVIDEOMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDISCRETEVIDEOMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDISCRETEVIDEOMUTE__DigitalOutput__, SUPPORTSDISCRETEVIDEOMUTE );
    
    SUPPORTSTOGGLEVIDEOMUTE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSTOGGLEVIDEOMUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSTOGGLEVIDEOMUTE__DigitalOutput__, SUPPORTSTOGGLEVIDEOMUTE );
    
    CONNECTION_F = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECTION_F__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECTION_F__DigitalOutput__, CONNECTION_F );
    
    SUPPORTSDISCONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDISCONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDISCONNECT__DigitalOutput__, SUPPORTSDISCONNECT );
    
    SUPPORTSRECONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSRECONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSRECONNECT__DigitalOutput__, SUPPORTSRECONNECT );
    
    SUPPORTSMEDIASERVICES = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSMEDIASERVICES__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSMEDIASERVICES__DigitalOutput__, SUPPORTSMEDIASERVICES );
    
    HASDIRECTACCESSTOSERVICES = new Crestron.Logos.SplusObjects.DigitalOutput( HASDIRECTACCESSTOSERVICES__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASDIRECTACCESSTOSERVICES__DigitalOutput__, HASDIRECTACCESSTOSERVICES );
    
    SUPPORTSACTIVEMEDIASERVICEFEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSACTIVEMEDIASERVICEFEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSACTIVEMEDIASERVICEFEEDBACK__DigitalOutput__, SUPPORTSACTIVEMEDIASERVICEFEEDBACK );
    
    SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK__DigitalOutput__, SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK );
    
    SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK__DigitalOutput__, SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK );
    
    ACTIVEMEDIASERVICE_ISSELECTABLE = new Crestron.Logos.SplusObjects.DigitalOutput( ACTIVEMEDIASERVICE_ISSELECTABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ACTIVEMEDIASERVICE_ISSELECTABLE__DigitalOutput__, ACTIVEMEDIASERVICE_ISSELECTABLE );
    
    ACTIVEMEDIASERVICE_ISBRANDED = new Crestron.Logos.SplusObjects.DigitalOutput( ACTIVEMEDIASERVICE_ISBRANDED__DigitalOutput__, this );
    m_DigitalOutputList.Add( ACTIVEMEDIASERVICE_ISBRANDED__DigitalOutput__, ACTIVEMEDIASERVICE_ISBRANDED );
    
    SUPPORTSDVR = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDVR__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDVR__DigitalOutput__, SUPPORTSDVR );
    
    SUPPORTSLIVE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSLIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSLIVE__DigitalOutput__, SUPPORTSLIVE );
    
    SUPPORTSRECORD = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSRECORD__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSRECORD__DigitalOutput__, SUPPORTSRECORD );
    
    SUPPORTSSPEEDSLOW = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSPEEDSLOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSPEEDSLOW__DigitalOutput__, SUPPORTSSPEEDSLOW );
    
    SUPPORTSTHUMBSUP = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSTHUMBSUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSTHUMBSUP__DigitalOutput__, SUPPORTSTHUMBSUP );
    
    SUPPORTSTHUMBSDOWN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSTHUMBSDOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSTHUMBSDOWN__DigitalOutput__, SUPPORTSTHUMBSDOWN );
    
    SUPPORTSCHANNELFEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSCHANNELFEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSCHANNELFEEDBACK__DigitalOutput__, SUPPORTSCHANNELFEEDBACK );
    
    SUPPORTSCHANGECHANNEL = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSCHANGECHANNEL__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSCHANGECHANNEL__DigitalOutput__, SUPPORTSCHANGECHANNEL );
    
    SUPPORTSSETCHANNEL = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSSETCHANNEL__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSSETCHANNEL__DigitalOutput__, SUPPORTSSETCHANNEL );
    
    SUPPORTSGUIDE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSGUIDE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSGUIDE__DigitalOutput__, SUPPORTSGUIDE );
    
    SUPPORTSPAGECHANGE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPAGECHANGE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPAGECHANGE__DigitalOutput__, SUPPORTSPAGECHANGE );
    
    SUPPORTSKEYPADNUMBER = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSKEYPADNUMBER__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSKEYPADNUMBER__DigitalOutput__, SUPPORTSKEYPADNUMBER );
    
    SUPPORTSKEYPADPOUND = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSKEYPADPOUND__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSKEYPADPOUND__DigitalOutput__, SUPPORTSKEYPADPOUND );
    
    SUPPORTSKEYPADASTERISK = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSKEYPADASTERISK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSKEYPADASTERISK__DigitalOutput__, SUPPORTSKEYPADASTERISK );
    
    SUPPORTSKEYPADBACKSPACE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSKEYPADBACKSPACE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSKEYPADBACKSPACE__DigitalOutput__, SUPPORTSKEYPADBACKSPACE );
    
    SUPPORTSPERIOD = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSPERIOD__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSPERIOD__DigitalOutput__, SUPPORTSPERIOD );
    
    SUPPORTSDASH = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDASH__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDASH__DigitalOutput__, SUPPORTSDASH );
    
    SUPPORTSENTER = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSENTER__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSENTER__DigitalOutput__, SUPPORTSENTER );
    
    SUPPORTSARTWORKMODE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARTWORKMODE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARTWORKMODE__DigitalOutput__, SUPPORTSARTWORKMODE );
    
    SUPPORTSARWORKMODEONPOWEROFF = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSARWORKMODEONPOWEROFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSARWORKMODEONPOWEROFF__DigitalOutput__, SUPPORTSARWORKMODEONPOWEROFF );
    
    SUPPORTSDISPLAYMODES = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSDISPLAYMODES__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSDISPLAYMODES__DigitalOutput__, SUPPORTSDISPLAYMODES );
    
    SUPPORTSA = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSA__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSA__DigitalOutput__, SUPPORTSA );
    
    SUPPORTSB = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSB__DigitalOutput__, SUPPORTSB );
    
    SUPPORTSC = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSC__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSC__DigitalOutput__, SUPPORTSC );
    
    SUPPORTSD = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSD__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSD__DigitalOutput__, SUPPORTSD );
    
    SUPPORTSRED = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSRED__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSRED__DigitalOutput__, SUPPORTSRED );
    
    SUPPORTSGREEN = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSGREEN__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSGREEN__DigitalOutput__, SUPPORTSGREEN );
    
    SUPPORTSBLUE = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSBLUE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSBLUE__DigitalOutput__, SUPPORTSBLUE );
    
    SUPPORTSYELLOW = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSYELLOW__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSYELLOW__DigitalOutput__, SUPPORTSYELLOW );
    
    SUPPORTSLAMPHOURS = new Crestron.Logos.SplusObjects.DigitalOutput( SUPPORTSLAMPHOURS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SUPPORTSLAMPHOURS__DigitalOutput__, SUPPORTSLAMPHOURS );
    
    COMMANDEXISTS = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        COMMANDEXISTS[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( COMMANDEXISTS__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( COMMANDEXISTS__DigitalOutput__ + i, COMMANDEXISTS[i+1] );
    }
    
    USERATTRIBUTE_ISAVAILABLE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_ISAVAILABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( USERATTRIBUTE_ISAVAILABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( USERATTRIBUTE_ISAVAILABLE__DigitalOutput__ + i, USERATTRIBUTE_ISAVAILABLE[i+1] );
    }
    
    USERATTRIBUTE_ISPERSISTENT = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_ISPERSISTENT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( USERATTRIBUTE_ISPERSISTENT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( USERATTRIBUTE_ISPERSISTENT__DigitalOutput__ + i, USERATTRIBUTE_ISPERSISTENT[i+1] );
    }
    
    MEDIASERVICE_ISAVAILABLE = new InOutArray<DigitalOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_ISAVAILABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( MEDIASERVICE_ISAVAILABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( MEDIASERVICE_ISAVAILABLE__DigitalOutput__ + i, MEDIASERVICE_ISAVAILABLE[i+1] );
    }
    
    MEDIASERVICE_ISSELECTABLE = new InOutArray<DigitalOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_ISSELECTABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( MEDIASERVICE_ISSELECTABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( MEDIASERVICE_ISSELECTABLE__DigitalOutput__ + i, MEDIASERVICE_ISSELECTABLE[i+1] );
    }
    
    MEDIASERVICE_ISBRANDED = new InOutArray<DigitalOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_ISBRANDED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( MEDIASERVICE_ISBRANDED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( MEDIASERVICE_ISBRANDED__DigitalOutput__ + i, MEDIASERVICE_ISBRANDED[i+1] );
    }
    
    DISPLAYMODE_ISAVAILABLE = new InOutArray<DigitalOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DISPLAYMODE_ISAVAILABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAYMODE_ISAVAILABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DISPLAYMODE_ISAVAILABLE__DigitalOutput__ + i, DISPLAYMODE_ISAVAILABLE[i+1] );
    }
    
    PORT = new Crestron.Logos.SplusObjects.AnalogInput( PORT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PORT__AnalogSerialInput__, PORT );
    
    ID = new Crestron.Logos.SplusObjects.AnalogInput( ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ID__AnalogSerialInput__, ID );
    
    WARMUPTIME = new Crestron.Logos.SplusObjects.AnalogInput( WARMUPTIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( WARMUPTIME__AnalogSerialInput__, WARMUPTIME );
    
    COOLDOWNTIME = new Crestron.Logos.SplusObjects.AnalogInput( COOLDOWNTIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( COOLDOWNTIME__AnalogSerialInput__, COOLDOWNTIME );
    
    SETINPUT = new Crestron.Logos.SplusObjects.AnalogInput( SETINPUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETINPUT__AnalogSerialInput__, SETINPUT );
    
    SETVOLUME = new Crestron.Logos.SplusObjects.AnalogInput( SETVOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVOLUME__AnalogSerialInput__, SETVOLUME );
    
    SETCHANNEL_TIMEBETWEENSEQUENCESINMS = new Crestron.Logos.SplusObjects.AnalogInput( SETCHANNEL_TIMEBETWEENSEQUENCESINMS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETCHANNEL_TIMEBETWEENSEQUENCESINMS__AnalogSerialInput__, SETCHANNEL_TIMEBETWEENSEQUENCESINMS );
    
    SETCHANNEL_TIMEBETWEENCOMMANDSINMS = new Crestron.Logos.SplusObjects.AnalogInput( SETCHANNEL_TIMEBETWEENCOMMANDSINMS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETCHANNEL_TIMEBETWEENCOMMANDSINMS__AnalogSerialInput__, SETCHANNEL_TIMEBETWEENCOMMANDSINMS );
    
    SETCHANNEL_IRCOMMANDDURATIONINMS = new Crestron.Logos.SplusObjects.AnalogInput( SETCHANNEL_IRCOMMANDDURATIONINMS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETCHANNEL_IRCOMMANDDURATIONINMS__AnalogSerialInput__, SETCHANNEL_IRCOMMANDDURATIONINMS );
    
    USERATTRIBUTE_ANALOGVALUE = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_ANALOGVALUE[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( USERATTRIBUTE_ANALOGVALUE__AnalogSerialInput__ + i, USERATTRIBUTE_ANALOGVALUE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( USERATTRIBUTE_ANALOGVALUE__AnalogSerialInput__ + i, USERATTRIBUTE_ANALOGVALUE[i+1] );
    }
    
    CURRENTPORT = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTPORT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENTPORT__AnalogSerialOutput__, CURRENTPORT );
    
    AUTHENTICATIONSTATUS = new Crestron.Logos.SplusObjects.AnalogOutput( AUTHENTICATIONSTATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUTHENTICATIONSTATUS__AnalogSerialOutput__, AUTHENTICATIONSTATUS );
    
    WARMUPTIME_F = new Crestron.Logos.SplusObjects.AnalogOutput( WARMUPTIME_F__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WARMUPTIME_F__AnalogSerialOutput__, WARMUPTIME_F );
    
    COOLDOWNTIME_F = new Crestron.Logos.SplusObjects.AnalogOutput( COOLDOWNTIME_F__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COOLDOWNTIME_F__AnalogSerialOutput__, COOLDOWNTIME_F );
    
    ACTIVEINPUTTYPE = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIVEINPUTTYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIVEINPUTTYPE__AnalogSerialOutput__, ACTIVEINPUTTYPE );
    
    NUMBEROFINPUTS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMBEROFINPUTS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMBEROFINPUTS__AnalogSerialOutput__, NUMBEROFINPUTS );
    
    VOLUME_F = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_F__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_F__AnalogSerialOutput__, VOLUME_F );
    
    ACTIVEMEDIASERVICE_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIVEMEDIASERVICE_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIVEMEDIASERVICE_STATE__AnalogSerialOutput__, ACTIVEMEDIASERVICE_STATE );
    
    ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE = new Crestron.Logos.SplusObjects.AnalogOutput( ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__, ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE );
    
    NUMCUSTOMCOMMANDS = new Crestron.Logos.SplusObjects.AnalogOutput( NUMCUSTOMCOMMANDS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMCUSTOMCOMMANDS__AnalogSerialOutput__, NUMCUSTOMCOMMANDS );
    
    NUMPAGES = new Crestron.Logos.SplusObjects.AnalogOutput( NUMPAGES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMPAGES__AnalogSerialOutput__, NUMPAGES );
    
    CUSTOMCOMMANDPAGENUM = new Crestron.Logos.SplusObjects.AnalogOutput( CUSTOMCOMMANDPAGENUM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CUSTOMCOMMANDPAGENUM__AnalogSerialOutput__, CUSTOMCOMMANDPAGENUM );
    
    NUMMEDIASERVICEPAGES = new Crestron.Logos.SplusObjects.AnalogOutput( NUMMEDIASERVICEPAGES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUMMEDIASERVICEPAGES__AnalogSerialOutput__, NUMMEDIASERVICEPAGES );
    
    CURRENTMEDIASERVICEPAGE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENTMEDIASERVICEPAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENTMEDIASERVICEPAGE__AnalogSerialOutput__, CURRENTMEDIASERVICEPAGE );
    
    SETNUMITEMS = new Crestron.Logos.SplusObjects.AnalogOutput( SETNUMITEMS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SETNUMITEMS__AnalogSerialOutput__, SETNUMITEMS );
    
    LAMPHOURS = new InOutArray<AnalogOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        LAMPHOURS[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( LAMPHOURS__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( LAMPHOURS__AnalogSerialOutput__ + i, LAMPHOURS[i+1] );
    }
    
    USERATTRIBUTE_TYPE = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_TYPE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( USERATTRIBUTE_TYPE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( USERATTRIBUTE_TYPE__AnalogSerialOutput__ + i, USERATTRIBUTE_TYPE[i+1] );
    }
    
    USERATTRIBUTE_DATATYPE = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_DATATYPE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( USERATTRIBUTE_DATATYPE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( USERATTRIBUTE_DATATYPE__AnalogSerialOutput__ + i, USERATTRIBUTE_DATATYPE[i+1] );
    }
    
    USERATTRIBUTE_REQUIREDFORCONNECTION = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_REQUIREDFORCONNECTION[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( USERATTRIBUTE_REQUIREDFORCONNECTION__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( USERATTRIBUTE_REQUIREDFORCONNECTION__AnalogSerialOutput__ + i, USERATTRIBUTE_REQUIREDFORCONNECTION[i+1] );
    }
    
    MEDIASERVICE_STATE = new InOutArray<AnalogOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_STATE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MEDIASERVICE_STATE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MEDIASERVICE_STATE__AnalogSerialOutput__ + i, MEDIASERVICE_STATE[i+1] );
    }
    
    MEDIASERVICE_SUBSCRIPTIONSTATE = new InOutArray<AnalogOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_SUBSCRIPTIONSTATE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__ + i, MEDIASERVICE_SUBSCRIPTIONSTATE[i+1] );
    }
    
    DISPLAYINPUTTYPE = new InOutArray<AnalogOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        DISPLAYINPUTTYPE[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAYINPUTTYPE__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( DISPLAYINPUTTYPE__AnalogSerialOutput__ + i, DISPLAYINPUTTYPE[i+1] );
    }
    
    FILE = new Crestron.Logos.SplusObjects.StringInput( FILE__AnalogSerialInput__, 2000, this );
    m_StringInputList.Add( FILE__AnalogSerialInput__, FILE );
    
    IPADDRESS = new Crestron.Logos.SplusObjects.StringInput( IPADDRESS__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( IPADDRESS__AnalogSerialInput__, IPADDRESS );
    
    USERNAME = new Crestron.Logos.SplusObjects.StringInput( USERNAME__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( USERNAME__AnalogSerialInput__, USERNAME );
    
    PASSWORD = new Crestron.Logos.SplusObjects.StringInput( PASSWORD__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( PASSWORD__AnalogSerialInput__, PASSWORD );
    
    CUSTOM_COMMAND = new Crestron.Logos.SplusObjects.StringInput( CUSTOM_COMMAND__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( CUSTOM_COMMAND__AnalogSerialInput__, CUSTOM_COMMAND );
    
    CUSTOM_COMMAND_BY_NAME = new Crestron.Logos.SplusObjects.StringInput( CUSTOM_COMMAND_BY_NAME__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( CUSTOM_COMMAND_BY_NAME__AnalogSerialInput__, CUSTOM_COMMAND_BY_NAME );
    
    CUSTOM_COMMAND_BY_VALUE = new Crestron.Logos.SplusObjects.StringInput( CUSTOM_COMMAND_BY_VALUE__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( CUSTOM_COMMAND_BY_VALUE__AnalogSerialInput__, CUSTOM_COMMAND_BY_VALUE );
    
    SELECTMEDIASERVICEBYID = new Crestron.Logos.SplusObjects.StringInput( SELECTMEDIASERVICEBYID__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( SELECTMEDIASERVICEBYID__AnalogSerialInput__, SELECTMEDIASERVICEBYID );
    
    SETCHANNEL = new Crestron.Logos.SplusObjects.StringInput( SETCHANNEL__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( SETCHANNEL__AnalogSerialInput__, SETCHANNEL );
    
    COMMANDNAME = new InOutArray<StringInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        COMMANDNAME[i+1] = new Crestron.Logos.SplusObjects.StringInput( COMMANDNAME__AnalogSerialInput__ + i, COMMANDNAME__AnalogSerialInput__, 200, this );
        m_StringInputList.Add( COMMANDNAME__AnalogSerialInput__ + i, COMMANDNAME[i+1] );
    }
    
    USERATTRIBUTE_STRINGVALUE = new InOutArray<StringInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_STRINGVALUE[i+1] = new Crestron.Logos.SplusObjects.StringInput( USERATTRIBUTE_STRINGVALUE__AnalogSerialInput__ + i, USERATTRIBUTE_STRINGVALUE__AnalogSerialInput__, 50, this );
        m_StringInputList.Add( USERATTRIBUTE_STRINGVALUE__AnalogSerialInput__ + i, USERATTRIBUTE_STRINGVALUE[i+1] );
    }
    
    TX = new Crestron.Logos.SplusObjects.StringOutput( TX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__AnalogSerialOutput__, TX );
    
    PACKETTX = new Crestron.Logos.SplusObjects.StringOutput( PACKETTX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PACKETTX__AnalogSerialOutput__, PACKETTX );
    
    SDKVERSION = new Crestron.Logos.SplusObjects.StringOutput( SDKVERSION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SDKVERSION__AnalogSerialOutput__, SDKVERSION );
    
    MANUFACTURER = new Crestron.Logos.SplusObjects.StringOutput( MANUFACTURER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MANUFACTURER__AnalogSerialOutput__, MANUFACTURER );
    
    BASEMODEL = new Crestron.Logos.SplusObjects.StringOutput( BASEMODEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( BASEMODEL__AnalogSerialOutput__, BASEMODEL );
    
    SUPPORTEDMODELS = new Crestron.Logos.SplusObjects.StringOutput( SUPPORTEDMODELS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUPPORTEDMODELS__AnalogSerialOutput__, SUPPORTEDMODELS );
    
    SUPPORTEDSERIES = new Crestron.Logos.SplusObjects.StringOutput( SUPPORTEDSERIES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUPPORTEDSERIES__AnalogSerialOutput__, SUPPORTEDSERIES );
    
    DESCRIPTION = new Crestron.Logos.SplusObjects.StringOutput( DESCRIPTION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DESCRIPTION__AnalogSerialOutput__, DESCRIPTION );
    
    DRIVERVERSION = new Crestron.Logos.SplusObjects.StringOutput( DRIVERVERSION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DRIVERVERSION__AnalogSerialOutput__, DRIVERVERSION );
    
    DRIVERVERSIONDATE = new Crestron.Logos.SplusObjects.StringOutput( DRIVERVERSIONDATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DRIVERVERSIONDATE__AnalogSerialOutput__, DRIVERVERSIONDATE );
    
    GUID = new Crestron.Logos.SplusObjects.StringOutput( GUID__AnalogSerialOutput__, this );
    m_StringOutputList.Add( GUID__AnalogSerialOutput__, GUID );
    
    ACTIVEINPUTCONNECTOR = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEINPUTCONNECTOR__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEINPUTCONNECTOR__AnalogSerialOutput__, ACTIVEINPUTCONNECTOR );
    
    ACTIVEINPUTDESCRIPTION = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEINPUTDESCRIPTION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEINPUTDESCRIPTION__AnalogSerialOutput__, ACTIVEINPUTDESCRIPTION );
    
    ACTIVEINPUTFRIENDLYNAME = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEINPUTFRIENDLYNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEINPUTFRIENDLYNAME__AnalogSerialOutput__, ACTIVEINPUTFRIENDLYNAME );
    
    RXOUT = new Crestron.Logos.SplusObjects.StringOutput( RXOUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RXOUT__AnalogSerialOutput__, RXOUT );
    
    LOG = new Crestron.Logos.SplusObjects.StringOutput( LOG__AnalogSerialOutput__, this );
    m_StringOutputList.Add( LOG__AnalogSerialOutput__, LOG );
    
    ACTIVEMEDIASERVICE_FRIENDLYNAME = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEMEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEMEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__, ACTIVEMEDIASERVICE_FRIENDLYNAME );
    
    ACTIVEMEDIASERVICE_SMALLIMAGEURL = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEMEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEMEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__, ACTIVEMEDIASERVICE_SMALLIMAGEURL );
    
    ACTIVEMEDIASERVICE_MEDIUMIMAGEURL = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEMEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEMEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__, ACTIVEMEDIASERVICE_MEDIUMIMAGEURL );
    
    ACTIVEMEDIASERVICE_LARGEIMAGEURL = new Crestron.Logos.SplusObjects.StringOutput( ACTIVEMEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ACTIVEMEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__, ACTIVEMEDIASERVICE_LARGEIMAGEURL );
    
    CHANNEL_F = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_F__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHANNEL_F__AnalogSerialOutput__, CHANNEL_F );
    
    COMMANDNAMEOUT = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        COMMANDNAMEOUT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( COMMANDNAMEOUT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( COMMANDNAMEOUT__AnalogSerialOutput__ + i, COMMANDNAMEOUT[i+1] );
    }
    
    USERATTRIBUTE_LABEL = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_LABEL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( USERATTRIBUTE_LABEL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( USERATTRIBUTE_LABEL__AnalogSerialOutput__ + i, USERATTRIBUTE_LABEL[i+1] );
    }
    
    USERATTRIBUTE_DESCRIPTION = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        USERATTRIBUTE_DESCRIPTION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( USERATTRIBUTE_DESCRIPTION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( USERATTRIBUTE_DESCRIPTION__AnalogSerialOutput__ + i, USERATTRIBUTE_DESCRIPTION[i+1] );
    }
    
    MEDIASERVICE_FRIENDLYNAME = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_FRIENDLYNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__ + i, MEDIASERVICE_FRIENDLYNAME[i+1] );
    }
    
    MEDIASERVICE_SMALLIMAGEURL = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_SMALLIMAGEURL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__ + i, MEDIASERVICE_SMALLIMAGEURL[i+1] );
    }
    
    MEDIASERVICE_MEDIUMIMAGEURL = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_MEDIUMIMAGEURL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__ + i, MEDIASERVICE_MEDIUMIMAGEURL[i+1] );
    }
    
    MEDIASERVICE_LARGEIMAGEURL = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        MEDIASERVICE_LARGEIMAGEURL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__ + i, MEDIASERVICE_LARGEIMAGEURL[i+1] );
    }
    
    DISPLAYMODE_FRIENDLYNAME = new InOutArray<StringOutput>( 15, this );
    for( uint i = 0; i < 15; i++ )
    {
        DISPLAYMODE_FRIENDLYNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYMODE_FRIENDLYNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( DISPLAYMODE_FRIENDLYNAME__AnalogSerialOutput__ + i, DISPLAYMODE_FRIENDLYNAME[i+1] );
    }
    
    DISPLAYINPUTDESCRIPTION = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        DISPLAYINPUTDESCRIPTION[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYINPUTDESCRIPTION__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( DISPLAYINPUTDESCRIPTION__AnalogSerialOutput__ + i, DISPLAYINPUTDESCRIPTION[i+1] );
    }
    
    DISPLAYINPUTCONNECTOR = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        DISPLAYINPUTCONNECTOR[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYINPUTCONNECTOR__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( DISPLAYINPUTCONNECTOR__AnalogSerialOutput__ + i, DISPLAYINPUTCONNECTOR[i+1] );
    }
    
    DISPLAYINPUTFRIENDLYNAME = new InOutArray<StringOutput>( 25, this );
    for( uint i = 0; i < 25; i++ )
    {
        DISPLAYINPUTFRIENDLYNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYINPUTFRIENDLYNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( DISPLAYINPUTFRIENDLYNAME__AnalogSerialOutput__ + i, DISPLAYINPUTFRIENDLYNAME[i+1] );
    }
    
    RX = new Crestron.Logos.SplusObjects.BufferInput( RX__AnalogSerialInput__, 65534, this );
    m_StringInputList.Add( RX__AnalogSerialInput__, RX );
    
    UNIQUEID = new StringParameter( UNIQUEID__Parameter__, this );
    m_ParameterList.Add( UNIQUEID__Parameter__, UNIQUEID );
    
    TRANSPORT = new StringParameter( TRANSPORT__Parameter__, this );
    m_ParameterList.Add( TRANSPORT__Parameter__, TRANSPORT );
    
    
    USERNAME.OnSerialChange.Add( new InputChangeHandlerWrapper( USERNAME_OnChange_0, false ) );
    PASSWORD.OnSerialChange.Add( new InputChangeHandlerWrapper( PASSWORD_OnChange_1, false ) );
    POWERTOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERTOGGLE_OnPush_2, false ) );
    POWERON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERON_OnPush_3, false ) );
    POWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWEROFF_OnPush_4, false ) );
    POWERTOGGLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWERTOGGLE_OnRelease_5, false ) );
    POWERON.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWERON_OnRelease_6, false ) );
    POWEROFF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWEROFF_OnRelease_7, false ) );
    WARMUPTIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( WARMUPTIME_OnChange_8, false ) );
    COOLDOWNTIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( COOLDOWNTIME_OnChange_9, false ) );
    SETINPUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETINPUT_OnChange_10, false ) );
    VOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEUP_OnPush_11, false ) );
    VOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEDOWN_OnPush_12, false ) );
    MUTETOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTETOGGLE_OnPush_13, false ) );
    MUTEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEON_OnPush_14, false ) );
    MUTEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEOFF_OnPush_15, false ) );
    VOLUMEUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUMEUP_OnRelease_16, false ) );
    VOLUMEDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUMEDOWN_OnRelease_17, false ) );
    MUTETOGGLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( MUTETOGGLE_OnRelease_18, false ) );
    MUTEON.OnDigitalRelease.Add( new InputChangeHandlerWrapper( MUTEON_OnRelease_19, false ) );
    MUTEOFF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( MUTEOFF_OnRelease_20, false ) );
    SETVOLUMEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETVOLUMEUP_OnPush_21, false ) );
    SETVOLUMEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETVOLUMEDOWN_OnPush_22, false ) );
    SETVOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVOLUME_OnChange_23, false ) );
    ENABLERXOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLERXOUT_OnPush_24, false ) );
    ENABLERXOUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLERXOUT_OnRelease_25, false ) );
    CUSTOM_COMMAND.OnSerialChange.Add( new InputChangeHandlerWrapper( CUSTOM_COMMAND_OnChange_26, false ) );
    CUSTOM_COMMAND_BY_NAME.OnSerialChange.Add( new InputChangeHandlerWrapper( CUSTOM_COMMAND_BY_NAME_OnChange_27, false ) );
    CUSTOM_COMMAND_BY_VALUE.OnSerialChange.Add( new InputChangeHandlerWrapper( CUSTOM_COMMAND_BY_VALUE_OnChange_28, false ) );
    RECONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECONNECT_OnPush_29, false ) );
    DISCONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCONNECT_OnPush_30, false ) );
    CONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECT_OnPush_31, false ) );
    ENABLELOGGING.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLELOGGING_OnPush_32, false ) );
    ENABLELOGGING.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLELOGGING_OnRelease_33, false ) );
    ENABLETXDEBUG.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLETXDEBUG_OnPush_34, false ) );
    ENABLETXDEBUG.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLETXDEBUG_OnRelease_35, false ) );
    ENABLERXDEBUG.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLERXDEBUG_OnPush_36, false ) );
    ENABLERXDEBUG.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLERXDEBUG_OnRelease_37, false ) );
    ENABLERXOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLERXOUT_OnPush_38, false ) );
    ENABLERXOUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLERXOUT_OnRelease_39, false ) );
    for( uint i = 0; i < 10; i++ )
        TRIGGERCOMMAND[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIGGERCOMMAND_OnPush_40, false ) );
        
    for( uint i = 0; i < 10; i++ )
        TRIGGERCOMMAND[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( TRIGGERCOMMAND_OnRelease_41, false ) );
        
    CMDGROUPUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CMDGROUPUP_OnPush_42, false ) );
    CMDGROUPDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CMDGROUPDOWN_OnPush_43, false ) );
    VIDEOMUTEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTEON_OnPush_44, false ) );
    VIDEOMUTEON.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VIDEOMUTEON_OnRelease_45, false ) );
    VIDEOMUTEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTEOFF_OnPush_46, false ) );
    VIDEOMUTEOFF.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VIDEOMUTEOFF_OnRelease_47, false ) );
    VIDEOMUTETOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( VIDEOMUTETOGGLE_OnPush_48, false ) );
    VIDEOMUTETOGGLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VIDEOMUTETOGGLE_OnRelease_49, false ) );
    UPARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPARROW_OnPush_50, false ) );
    DOWNARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOWNARROW_OnPush_51, false ) );
    LEFTARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEFTARROW_OnPush_52, false ) );
    RIGHTARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( RIGHTARROW_OnPush_53, false ) );
    SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_OnPush_54, false ) );
    CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_OnPush_55, false ) );
    EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXIT_OnPush_56, false ) );
    HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOME_OnPush_57, false ) );
    MENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( MENU_OnPush_58, false ) );
    SEARCH.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEARCH_OnPush_59, false ) );
    UPARROW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( UPARROW_OnRelease_60, false ) );
    DOWNARROW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( UPARROW_OnRelease_60, false ) );
    LEFTARROW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( UPARROW_OnRelease_60, false ) );
    RIGHTARROW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( UPARROW_OnRelease_60, false ) );
    SELECT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    CLEAR.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    EXIT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    HOME.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    MENU.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    SEARCH.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SELECT_OnRelease_61, false ) );
    YOUTUBE.OnDigitalPush.Add( new InputChangeHandlerWrapper( YOUTUBE_OnPush_62, false ) );
    YOUTUBETV.OnDigitalPush.Add( new InputChangeHandlerWrapper( YOUTUBETV_OnPush_63, false ) );
    NETFLIX.OnDigitalPush.Add( new InputChangeHandlerWrapper( NETFLIX_OnPush_64, false ) );
    HULU.OnDigitalPush.Add( new InputChangeHandlerWrapper( HULU_OnPush_65, false ) );
    DIRECTVNOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIRECTVNOW_OnPush_66, false ) );
    AMAZONVIDEO.OnDigitalPush.Add( new InputChangeHandlerWrapper( AMAZONVIDEO_OnPush_67, false ) );
    PLAYSTATIONVUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAYSTATIONVUE_OnPush_68, false ) );
    SLINGTV.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLINGTV_OnPush_69, false ) );
    YOUTUBE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    YOUTUBETV.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    NETFLIX.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    HULU.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    DIRECTVNOW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    AMAZONVIDEO.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    PLAYSTATIONVUE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    SLINGTV.OnDigitalRelease.Add( new InputChangeHandlerWrapper( YOUTUBE_OnRelease_70, false ) );
    FORWARDSCAN.OnDigitalPush.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnPush_71, false ) );
    REVERSESCAN.OnDigitalPush.Add( new InputChangeHandlerWrapper( REVERSESCAN_OnPush_72, false ) );
    PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAY_OnPush_73, false ) );
    PAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAUSE_OnPush_74, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_75, false ) );
    FORWARDSKIP.OnDigitalPush.Add( new InputChangeHandlerWrapper( FORWARDSKIP_OnPush_76, false ) );
    REVERSESKIP.OnDigitalPush.Add( new InputChangeHandlerWrapper( REVERSESKIP_OnPush_77, false ) );
    REPEAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REPEAT_OnPush_78, false ) );
    RETURNCOMMAND.OnDigitalPush.Add( new InputChangeHandlerWrapper( RETURNCOMMAND_OnPush_79, false ) );
    BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACK_OnPush_80, false ) );
    PLAYPAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAYPAUSE_OnPush_81, false ) );
    OPTIONS.OnDigitalPush.Add( new InputChangeHandlerWrapper( OPTIONS_OnPush_82, false ) );
    INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( INFO_OnPush_83, false ) );
    FORWARDSCAN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    REVERSESCAN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    PLAY.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    PAUSE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    STOP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    FORWARDSKIP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    REVERSESKIP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    REPEAT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    RETURNCOMMAND.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    BACK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    PLAYPAUSE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    OPTIONS.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    INFO.OnDigitalRelease.Add( new InputChangeHandlerWrapper( FORWARDSCAN_OnRelease_84, false ) );
    for( uint i = 0; i < 10; i++ )
        USERATTRIBUTE_SENDITIN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( USERATTRIBUTE_SENDITIN_OnPush_85, false ) );
        
    SELECTMEDIASERVICEBYID.OnSerialChange.Add( new InputChangeHandlerWrapper( SELECTMEDIASERVICEBYID_OnChange_86, false ) );
    for( uint i = 0; i < 25; i++ )
        SELECTMEDIASERVICE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECTMEDIASERVICE_OnPush_87, false ) );
        
    NEXTMEDIASERVICEPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NEXTMEDIASERVICEPAGE_OnPush_88, false ) );
    PREVMEDIASERVICEPAGE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PREVMEDIASERVICEPAGE_OnPush_89, false ) );
    ARTWORKON.OnDigitalPush.Add( new InputChangeHandlerWrapper( ARTWORKON_OnPush_90, false ) );
    ARTWORKOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ARTWORKOFF_OnPush_91, false ) );
    ENABLEARTWORKONPOWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLEARTWORKONPOWEROFF_OnPush_92, false ) );
    DISABLEARTWORKONPOWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISABLEARTWORKONPOWEROFF_OnPush_93, false ) );
    for( uint i = 0; i < 15; i++ )
        SELECTDISPLAYMODE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECTDISPLAYMODE_OnPush_94, false ) );
        
    A.OnDigitalPush.Add( new InputChangeHandlerWrapper( A_OnPush_95, false ) );
    B.OnDigitalPush.Add( new InputChangeHandlerWrapper( B_OnPush_96, false ) );
    C.OnDigitalPush.Add( new InputChangeHandlerWrapper( C_OnPush_97, false ) );
    D.OnDigitalPush.Add( new InputChangeHandlerWrapper( D_OnPush_98, false ) );
    RED.OnDigitalPush.Add( new InputChangeHandlerWrapper( RED_OnPush_99, false ) );
    GREEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( GREEN_OnPush_100, false ) );
    BLUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLUE_OnPush_101, false ) );
    YELLOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( YELLOW_OnPush_102, false ) );
    A.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    B.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    C.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    D.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    RED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    GREEN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    BLUE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    YELLOW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( A_OnRelease_103, false ) );
    _0.OnDigitalPush.Add( new InputChangeHandlerWrapper( _0_OnPush_104, false ) );
    _1.OnDigitalPush.Add( new InputChangeHandlerWrapper( _1_OnPush_105, false ) );
    _2.OnDigitalPush.Add( new InputChangeHandlerWrapper( _2_OnPush_106, false ) );
    _3.OnDigitalPush.Add( new InputChangeHandlerWrapper( _3_OnPush_107, false ) );
    _4.OnDigitalPush.Add( new InputChangeHandlerWrapper( _4_OnPush_108, false ) );
    _5.OnDigitalPush.Add( new InputChangeHandlerWrapper( _5_OnPush_109, false ) );
    _6.OnDigitalPush.Add( new InputChangeHandlerWrapper( _6_OnPush_110, false ) );
    _7.OnDigitalPush.Add( new InputChangeHandlerWrapper( _7_OnPush_111, false ) );
    _8.OnDigitalPush.Add( new InputChangeHandlerWrapper( _8_OnPush_112, false ) );
    _9.OnDigitalPush.Add( new InputChangeHandlerWrapper( _9_OnPush_113, false ) );
    KEYPADPOUND.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPADPOUND_OnPush_114, false ) );
    KEYPADASTERISK.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPADASTERISK_OnPush_115, false ) );
    KEYPADBACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPADBACKSPACE_OnPush_116, false ) );
    PERIOD.OnDigitalPush.Add( new InputChangeHandlerWrapper( PERIOD_OnPush_117, false ) );
    DASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( DASH_OnPush_118, false ) );
    ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_OnPush_119, false ) );
    _0.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _0_OnRelease_120, false ) );
    _1.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _1_OnRelease_121, false ) );
    _2.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _2_OnRelease_122, false ) );
    _3.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _3_OnRelease_123, false ) );
    _4.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _4_OnRelease_124, false ) );
    _5.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _5_OnRelease_125, false ) );
    _6.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _6_OnRelease_126, false ) );
    _7.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _7_OnRelease_127, false ) );
    _8.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _8_OnRelease_128, false ) );
    _9.OnDigitalRelease.Add( new InputChangeHandlerWrapper( _9_OnRelease_129, false ) );
    KEYPADPOUND.OnDigitalRelease.Add( new InputChangeHandlerWrapper( KEYPADPOUND_OnRelease_130, false ) );
    KEYPADASTERISK.OnDigitalRelease.Add( new InputChangeHandlerWrapper( KEYPADASTERISK_OnRelease_131, false ) );
    KEYPADBACKSPACE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( KEYPADBACKSPACE_OnRelease_132, false ) );
    PERIOD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PERIOD_OnRelease_133, false ) );
    DASH.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DASH_OnRelease_134, false ) );
    ENTER.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENTER_OnRelease_135, false ) );
    DVR.OnDigitalPush.Add( new InputChangeHandlerWrapper( DVR_OnPush_136, false ) );
    LIVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIVE_OnPush_137, false ) );
    RECORD.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECORD_OnPush_138, false ) );
    SPEEDSLOW.OnDigitalPush.Add( new InputChangeHandlerWrapper( SPEEDSLOW_OnPush_139, false ) );
    THUMBSUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( THUMBSUP_OnPush_140, false ) );
    THUMBSDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( THUMBSDOWN_OnPush_141, false ) );
    DVR.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DVR_OnRelease_142, false ) );
    LIVE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LIVE_OnRelease_143, false ) );
    RECORD.OnDigitalRelease.Add( new InputChangeHandlerWrapper( RECORD_OnRelease_144, false ) );
    SPEEDSLOW.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SPEEDSLOW_OnRelease_145, false ) );
    THUMBSUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( THUMBSUP_OnRelease_146, false ) );
    THUMBSDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( THUMBSDOWN_OnRelease_147, false ) );
    SETCHANNEL.OnSerialChange.Add( new InputChangeHandlerWrapper( SETCHANNEL_OnChange_148, false ) );
    CHANNELUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELUP_OnPush_149, false ) );
    CHANNELDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELDOWN_OnPush_150, false ) );
    GUIDE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUIDE_OnPush_151, false ) );
    PAGEUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGEUP_OnPush_152, false ) );
    PAGEDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAGEDOWN_OnPush_153, false ) );
    CHANNELUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CHANNELUP_OnRelease_154, false ) );
    CHANNELDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CHANNELDOWN_OnRelease_155, false ) );
    GUIDE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( GUIDE_OnRelease_156, false ) );
    PAGEUP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAGEUP_OnRelease_157, false ) );
    PAGEDOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAGEDOWN_OnRelease_158, false ) );
    SETCHANNEL_SENDENTERAFTERSEQUENCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETCHANNEL_SENDENTERAFTERSEQUENCE_OnPush_159, false ) );
    SETCHANNEL_SENDENTERAFTERSEQUENCE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SETCHANNEL_SENDENTERAFTERSEQUENCE_OnRelease_160, false ) );
    SETCHANNEL_TIMEBETWEENSEQUENCESINMS.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETCHANNEL_TIMEBETWEENSEQUENCESINMS_OnChange_161, false ) );
    SETCHANNEL_TIMEBETWEENCOMMANDSINMS.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETCHANNEL_TIMEBETWEENCOMMANDSINMS_OnChange_162, false ) );
    SETCHANNEL_IRCOMMANDDURATIONINMS.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETCHANNEL_IRCOMMANDDURATIONINMS_OnChange_163, false ) );
    FILE.OnSerialChange.Add( new InputChangeHandlerWrapper( FILE_OnChange_164, false ) );
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_165, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new Crestron.RAD.DeviceTypes.Display.SimplDisplay();
    SYSTEMMODULE  = new Crestron.RAD.SystemManager.SMWrapper();
    
    
}

public CrestronModuleClass_CRESTRONCERTIFIEDDRIVERSVIDEODISPLAYMODULE_V1_11 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INITIALIZE__DigitalInput__ = 0;
const uint CECINITIALIZE__DigitalInput__ = 1;
const uint FILE__AnalogSerialInput__ = 0;
const uint RX__AnalogSerialInput__ = 1;
const uint IPADDRESS__AnalogSerialInput__ = 2;
const uint PORT__AnalogSerialInput__ = 3;
const uint TX__AnalogSerialOutput__ = 0;
const uint PACKETTX__AnalogSerialOutput__ = 1;
const uint DRIVERLOADED__DigitalOutput__ = 0;
const uint CURRENTPORT__AnalogSerialOutput__ = 2;
const uint REBOOTREQUIRED__DigitalOutput__ = 1;
const uint ID__AnalogSerialInput__ = 4;
const uint SDKVERSION__AnalogSerialOutput__ = 3;
const uint MANUFACTURER__AnalogSerialOutput__ = 4;
const uint BASEMODEL__AnalogSerialOutput__ = 5;
const uint SUPPORTEDMODELS__AnalogSerialOutput__ = 6;
const uint SUPPORTEDSERIES__AnalogSerialOutput__ = 7;
const uint DESCRIPTION__AnalogSerialOutput__ = 8;
const uint DRIVERVERSION__AnalogSerialOutput__ = 9;
const uint DRIVERVERSIONDATE__AnalogSerialOutput__ = 10;
const uint GUID__AnalogSerialOutput__ = 11;
const uint SUPPORTSFEEDBACK__DigitalOutput__ = 2;
const uint USERNAME__AnalogSerialInput__ = 5;
const uint PASSWORD__AnalogSerialInput__ = 6;
const uint AUTHENTICATIONSTATUS__AnalogSerialOutput__ = 12;
const uint SUPPORTSUSERNAME__DigitalOutput__ = 3;
const uint SUPPORTSPASSWORD__DigitalOutput__ = 4;
const uint AUTHENTICATIONISREQUIRED__DigitalOutput__ = 5;
const uint SUPPORTSPOWER_F__DigitalOutput__ = 6;
const uint POWER_F__DigitalOutput__ = 7;
const uint SUPPORTSDISCRETEPOWER__DigitalOutput__ = 8;
const uint POWERON__DigitalInput__ = 2;
const uint POWEROFF__DigitalInput__ = 3;
const uint SUPPORTSTOGGLEPOWER__DigitalOutput__ = 9;
const uint POWERTOGGLE__DigitalInput__ = 4;
const uint SUPPORTSWARMUPTIME__DigitalOutput__ = 10;
const uint SUPPORTSCOOLDOWNTIME__DigitalOutput__ = 11;
const uint WARMUPTIME__AnalogSerialInput__ = 7;
const uint COOLDOWNTIME__AnalogSerialInput__ = 8;
const uint WARMINGUP__DigitalOutput__ = 12;
const uint COOLINGDOWN__DigitalOutput__ = 13;
const uint WARMUPTIME_F__AnalogSerialOutput__ = 13;
const uint COOLDOWNTIME_F__AnalogSerialOutput__ = 14;
const uint SUPPORTSINPUT_F__DigitalOutput__ = 14;
const uint ACTIVEINPUTTYPE__AnalogSerialOutput__ = 15;
const uint ACTIVEINPUTCONNECTOR__AnalogSerialOutput__ = 16;
const uint ACTIVEINPUTDESCRIPTION__AnalogSerialOutput__ = 17;
const uint ACTIVEINPUTFRIENDLYNAME__AnalogSerialOutput__ = 18;
const uint NUMBEROFINPUTS__AnalogSerialOutput__ = 19;
const uint SUPPORTSSETINPUT__DigitalOutput__ = 15;
const uint SETINPUT__AnalogSerialInput__ = 9;
const uint SUPPORTSARROWKEYS__DigitalOutput__ = 16;
const uint SUPPORTSARROWUP__DigitalOutput__ = 17;
const uint SUPPORTSARROWDOWN__DigitalOutput__ = 18;
const uint SUPPORTSARROWLEFT__DigitalOutput__ = 19;
const uint SUPPORTSARROWRIGHT__DigitalOutput__ = 20;
const uint SUPPORTSSELECT__DigitalOutput__ = 21;
const uint UPARROW__DigitalInput__ = 5;
const uint DOWNARROW__DigitalInput__ = 6;
const uint LEFTARROW__DigitalInput__ = 7;
const uint RIGHTARROW__DigitalInput__ = 8;
const uint SELECT__DigitalInput__ = 9;
const uint SUPPORTSCLEAR__DigitalOutput__ = 22;
const uint CLEAR__DigitalInput__ = 10;
const uint SUPPORTSEXIT__DigitalOutput__ = 23;
const uint EXIT__DigitalInput__ = 11;
const uint SUPPORTSHOME__DigitalOutput__ = 24;
const uint HOME__DigitalInput__ = 12;
const uint SUPPORTSMENU__DigitalOutput__ = 25;
const uint MENU__DigitalInput__ = 13;
const uint SUPPORTSSEARCH__DigitalOutput__ = 26;
const uint SEARCH__DigitalInput__ = 14;
const uint SUPPORTSYOUTUBE__DigitalOutput__ = 27;
const uint SUPPORTSYOUTUBETV__DigitalOutput__ = 28;
const uint SUPPORTSNETFLIX__DigitalOutput__ = 29;
const uint SUPPORTSHULU__DigitalOutput__ = 30;
const uint SUPPORTSDIRECTVNOW__DigitalOutput__ = 31;
const uint SUPPORTSAMAZONVIDEO__DigitalOutput__ = 32;
const uint SUPPORTSPLAYSTATIONVUE__DigitalOutput__ = 33;
const uint SUPPORTSSLINGTV__DigitalOutput__ = 34;
const uint YOUTUBE__DigitalInput__ = 15;
const uint YOUTUBETV__DigitalInput__ = 16;
const uint NETFLIX__DigitalInput__ = 17;
const uint HULU__DigitalInput__ = 18;
const uint DIRECTVNOW__DigitalInput__ = 19;
const uint AMAZONVIDEO__DigitalInput__ = 20;
const uint PLAYSTATIONVUE__DigitalInput__ = 21;
const uint SLINGTV__DigitalInput__ = 22;
const uint SUPPORTSFORWARDSCAN__DigitalOutput__ = 35;
const uint SUPPORTSREVERSESCAN__DigitalOutput__ = 36;
const uint SUPPORTSPLAY__DigitalOutput__ = 37;
const uint SUPPORTSPAUSE__DigitalOutput__ = 38;
const uint SUPPORTSSTOP__DigitalOutput__ = 39;
const uint SUPPORTSFORWARDSKIP__DigitalOutput__ = 40;
const uint SUPPORTSREVERSESKIP__DigitalOutput__ = 41;
const uint SUPPORTSREPEAT__DigitalOutput__ = 42;
const uint SUPPORTSRETURN__DigitalOutput__ = 43;
const uint SUPPORTSBACK__DigitalOutput__ = 44;
const uint SUPPORTSPLAYPAUSE__DigitalOutput__ = 45;
const uint SUPPORTSOPTIONS__DigitalOutput__ = 46;
const uint SUPPORTSINFO__DigitalOutput__ = 47;
const uint FORWARDSCAN__DigitalInput__ = 23;
const uint REVERSESCAN__DigitalInput__ = 24;
const uint PLAY__DigitalInput__ = 25;
const uint PAUSE__DigitalInput__ = 26;
const uint STOP__DigitalInput__ = 27;
const uint FORWARDSKIP__DigitalInput__ = 28;
const uint REVERSESKIP__DigitalInput__ = 29;
const uint REPEAT__DigitalInput__ = 30;
const uint RETURNCOMMAND__DigitalInput__ = 31;
const uint BACK__DigitalInput__ = 32;
const uint PLAYPAUSE__DigitalInput__ = 33;
const uint OPTIONS__DigitalInput__ = 34;
const uint INFO__DigitalInput__ = 35;
const uint SUPPORTSVOLUME_F__DigitalOutput__ = 48;
const uint VOLUME_F__AnalogSerialOutput__ = 20;
const uint SUPPORTSMUTE_F__DigitalOutput__ = 49;
const uint MUTE_F__DigitalOutput__ = 50;
const uint SUPPORTSDISCRETEMUTE__DigitalOutput__ = 51;
const uint MUTEON__DigitalInput__ = 36;
const uint MUTEOFF__DigitalInput__ = 37;
const uint SUPPORTSMUTE__DigitalOutput__ = 52;
const uint MUTETOGGLE__DigitalInput__ = 38;
const uint SUPPORTSSETVOLUME__DigitalOutput__ = 53;
const uint SETVOLUME__AnalogSerialInput__ = 10;
const uint SUPPORTSCHANGEVOLUME__DigitalOutput__ = 54;
const uint VOLUMEUP__DigitalInput__ = 39;
const uint VOLUMEDOWN__DigitalInput__ = 40;
const uint SETVOLUMEUP__DigitalInput__ = 41;
const uint SETVOLUMEDOWN__DigitalInput__ = 42;
const uint SUPPORTSVIDEOMUTE_F__DigitalOutput__ = 55;
const uint VIDEOMUTE_F__DigitalOutput__ = 56;
const uint SUPPORTSDISCRETEVIDEOMUTE__DigitalOutput__ = 57;
const uint VIDEOMUTEON__DigitalInput__ = 43;
const uint VIDEOMUTEOFF__DigitalInput__ = 44;
const uint SUPPORTSTOGGLEVIDEOMUTE__DigitalOutput__ = 58;
const uint VIDEOMUTETOGGLE__DigitalInput__ = 45;
const uint CUSTOM_COMMAND__AnalogSerialInput__ = 11;
const uint CUSTOM_COMMAND_BY_NAME__AnalogSerialInput__ = 12;
const uint CUSTOM_COMMAND_BY_VALUE__AnalogSerialInput__ = 13;
const uint ENABLERXOUT__DigitalInput__ = 46;
const uint RXOUT__AnalogSerialOutput__ = 21;
const uint CONNECTION_F__DigitalOutput__ = 59;
const uint SUPPORTSDISCONNECT__DigitalOutput__ = 60;
const uint DISCONNECT__DigitalInput__ = 47;
const uint SUPPORTSRECONNECT__DigitalOutput__ = 61;
const uint RECONNECT__DigitalInput__ = 48;
const uint CONNECT__DigitalInput__ = 49;
const uint ENABLELOGGING__DigitalInput__ = 50;
const uint ENABLETXDEBUG__DigitalInput__ = 51;
const uint ENABLERXDEBUG__DigitalInput__ = 52;
const uint LOG__AnalogSerialOutput__ = 22;
const uint SELECTMEDIASERVICEBYID__AnalogSerialInput__ = 14;
const uint SUPPORTSMEDIASERVICES__DigitalOutput__ = 62;
const uint HASDIRECTACCESSTOSERVICES__DigitalOutput__ = 63;
const uint SUPPORTSACTIVEMEDIASERVICEFEEDBACK__DigitalOutput__ = 64;
const uint SUPPORTSACTIVEMEDIASERVICESTATEFEEDBACK__DigitalOutput__ = 65;
const uint SUPPORTSMEDIASERVICESUBSCRIPTIONSTATEFEEDBACK__DigitalOutput__ = 66;
const uint ACTIVEMEDIASERVICE_ISSELECTABLE__DigitalOutput__ = 67;
const uint ACTIVEMEDIASERVICE_ISBRANDED__DigitalOutput__ = 68;
const uint ACTIVEMEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__ = 23;
const uint ACTIVEMEDIASERVICE_STATE__AnalogSerialOutput__ = 24;
const uint ACTIVEMEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__ = 25;
const uint ACTIVEMEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__ = 26;
const uint ACTIVEMEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__ = 27;
const uint ACTIVEMEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__ = 28;
const uint SUPPORTSDVR__DigitalOutput__ = 69;
const uint DVR__DigitalInput__ = 53;
const uint SUPPORTSLIVE__DigitalOutput__ = 70;
const uint LIVE__DigitalInput__ = 54;
const uint SUPPORTSRECORD__DigitalOutput__ = 71;
const uint RECORD__DigitalInput__ = 55;
const uint SUPPORTSSPEEDSLOW__DigitalOutput__ = 72;
const uint SPEEDSLOW__DigitalInput__ = 56;
const uint SUPPORTSTHUMBSUP__DigitalOutput__ = 73;
const uint THUMBSUP__DigitalInput__ = 57;
const uint SUPPORTSTHUMBSDOWN__DigitalOutput__ = 74;
const uint THUMBSDOWN__DigitalInput__ = 58;
const uint SUPPORTSCHANNELFEEDBACK__DigitalOutput__ = 75;
const uint CHANNEL_F__AnalogSerialOutput__ = 29;
const uint SUPPORTSCHANGECHANNEL__DigitalOutput__ = 76;
const uint CHANNELDOWN__DigitalInput__ = 59;
const uint CHANNELUP__DigitalInput__ = 60;
const uint SUPPORTSSETCHANNEL__DigitalOutput__ = 77;
const uint SETCHANNEL__AnalogSerialInput__ = 15;
const uint SUPPORTSGUIDE__DigitalOutput__ = 78;
const uint GUIDE__DigitalInput__ = 61;
const uint SUPPORTSPAGECHANGE__DigitalOutput__ = 79;
const uint PAGEDOWN__DigitalInput__ = 62;
const uint PAGEUP__DigitalInput__ = 63;
const uint SETCHANNEL_SENDENTERAFTERSEQUENCE__DigitalInput__ = 64;
const uint SETCHANNEL_TIMEBETWEENSEQUENCESINMS__AnalogSerialInput__ = 16;
const uint SETCHANNEL_TIMEBETWEENCOMMANDSINMS__AnalogSerialInput__ = 17;
const uint SETCHANNEL_IRCOMMANDDURATIONINMS__AnalogSerialInput__ = 18;
const uint SUPPORTSKEYPADNUMBER__DigitalOutput__ = 80;
const uint _0__DigitalInput__ = 65;
const uint _1__DigitalInput__ = 66;
const uint _2__DigitalInput__ = 67;
const uint _3__DigitalInput__ = 68;
const uint _4__DigitalInput__ = 69;
const uint _5__DigitalInput__ = 70;
const uint _6__DigitalInput__ = 71;
const uint _7__DigitalInput__ = 72;
const uint _8__DigitalInput__ = 73;
const uint _9__DigitalInput__ = 74;
const uint SUPPORTSKEYPADPOUND__DigitalOutput__ = 81;
const uint KEYPADPOUND__DigitalInput__ = 75;
const uint SUPPORTSKEYPADASTERISK__DigitalOutput__ = 82;
const uint KEYPADASTERISK__DigitalInput__ = 76;
const uint SUPPORTSKEYPADBACKSPACE__DigitalOutput__ = 83;
const uint KEYPADBACKSPACE__DigitalInput__ = 77;
const uint SUPPORTSPERIOD__DigitalOutput__ = 84;
const uint PERIOD__DigitalInput__ = 78;
const uint SUPPORTSDASH__DigitalOutput__ = 85;
const uint DASH__DigitalInput__ = 79;
const uint SUPPORTSENTER__DigitalOutput__ = 86;
const uint ENTER__DigitalInput__ = 80;
const uint SUPPORTSARTWORKMODE__DigitalOutput__ = 87;
const uint ARTWORKON__DigitalInput__ = 81;
const uint ARTWORKOFF__DigitalInput__ = 82;
const uint SUPPORTSARWORKMODEONPOWEROFF__DigitalOutput__ = 88;
const uint ENABLEARTWORKONPOWEROFF__DigitalInput__ = 83;
const uint DISABLEARTWORKONPOWEROFF__DigitalInput__ = 84;
const uint SUPPORTSDISPLAYMODES__DigitalOutput__ = 89;
const uint SUPPORTSA__DigitalOutput__ = 90;
const uint SUPPORTSB__DigitalOutput__ = 91;
const uint SUPPORTSC__DigitalOutput__ = 92;
const uint SUPPORTSD__DigitalOutput__ = 93;
const uint A__DigitalInput__ = 85;
const uint B__DigitalInput__ = 86;
const uint C__DigitalInput__ = 87;
const uint D__DigitalInput__ = 88;
const uint SUPPORTSRED__DigitalOutput__ = 94;
const uint SUPPORTSGREEN__DigitalOutput__ = 95;
const uint SUPPORTSBLUE__DigitalOutput__ = 96;
const uint SUPPORTSYELLOW__DigitalOutput__ = 97;
const uint RED__DigitalInput__ = 89;
const uint GREEN__DigitalInput__ = 90;
const uint BLUE__DigitalInput__ = 91;
const uint YELLOW__DigitalInput__ = 92;
const uint CMDGROUPUP__DigitalInput__ = 93;
const uint CMDGROUPDOWN__DigitalInput__ = 94;
const uint NUMCUSTOMCOMMANDS__AnalogSerialOutput__ = 30;
const uint NUMPAGES__AnalogSerialOutput__ = 31;
const uint CUSTOMCOMMANDPAGENUM__AnalogSerialOutput__ = 32;
const uint NUMMEDIASERVICEPAGES__AnalogSerialOutput__ = 33;
const uint CURRENTMEDIASERVICEPAGE__AnalogSerialOutput__ = 34;
const uint SETNUMITEMS__AnalogSerialOutput__ = 35;
const uint NEXTMEDIASERVICEPAGE__DigitalInput__ = 95;
const uint PREVMEDIASERVICEPAGE__DigitalInput__ = 96;
const uint SUPPORTSLAMPHOURS__DigitalOutput__ = 98;
const uint LAMPHOURS__AnalogSerialOutput__ = 36;
const uint TRIGGERCOMMAND__DigitalInput__ = 97;
const uint COMMANDEXISTS__DigitalOutput__ = 99;
const uint COMMANDNAME__AnalogSerialInput__ = 19;
const uint COMMANDNAMEOUT__AnalogSerialOutput__ = 40;
const uint USERATTRIBUTE_SENDITIN__DigitalInput__ = 107;
const uint USERATTRIBUTE_STRINGVALUE__AnalogSerialInput__ = 29;
const uint USERATTRIBUTE_ANALOGVALUE__AnalogSerialInput__ = 39;
const uint USERATTRIBUTE_DIGITALVALUE__DigitalInput__ = 117;
const uint USERATTRIBUTE_ISAVAILABLE__DigitalOutput__ = 109;
const uint USERATTRIBUTE_ISPERSISTENT__DigitalOutput__ = 119;
const uint USERATTRIBUTE_LABEL__AnalogSerialOutput__ = 50;
const uint USERATTRIBUTE_DESCRIPTION__AnalogSerialOutput__ = 60;
const uint USERATTRIBUTE_TYPE__AnalogSerialOutput__ = 70;
const uint USERATTRIBUTE_DATATYPE__AnalogSerialOutput__ = 80;
const uint USERATTRIBUTE_REQUIREDFORCONNECTION__AnalogSerialOutput__ = 90;
const uint SELECTMEDIASERVICE__DigitalInput__ = 127;
const uint MEDIASERVICE_ISAVAILABLE__DigitalOutput__ = 129;
const uint MEDIASERVICE_ISSELECTABLE__DigitalOutput__ = 154;
const uint MEDIASERVICE_ISBRANDED__DigitalOutput__ = 179;
const uint MEDIASERVICE_FRIENDLYNAME__AnalogSerialOutput__ = 100;
const uint MEDIASERVICE_STATE__AnalogSerialOutput__ = 125;
const uint MEDIASERVICE_SUBSCRIPTIONSTATE__AnalogSerialOutput__ = 150;
const uint MEDIASERVICE_SMALLIMAGEURL__AnalogSerialOutput__ = 175;
const uint MEDIASERVICE_MEDIUMIMAGEURL__AnalogSerialOutput__ = 200;
const uint MEDIASERVICE_LARGEIMAGEURL__AnalogSerialOutput__ = 225;
const uint SELECTDISPLAYMODE__DigitalInput__ = 152;
const uint DISPLAYMODE_ISAVAILABLE__DigitalOutput__ = 204;
const uint DISPLAYMODE_FRIENDLYNAME__AnalogSerialOutput__ = 250;
const uint UNIQUEID__Parameter__ = 10;
const uint TRANSPORT__Parameter__ = 11;
const uint DISPLAYINPUTDESCRIPTION__AnalogSerialOutput__ = 265;
const uint DISPLAYINPUTCONNECTOR__AnalogSerialOutput__ = 290;
const uint DISPLAYINPUTFRIENDLYNAME__AnalogSerialOutput__ = 315;
const uint DISPLAYINPUTTYPE__AnalogSerialOutput__ = 340;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}

[SplusStructAttribute(-1, true, false)]
public class MEDIASERVICESTRUC : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public ushort  ISAVAILABLE = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  ISSELECTABLE = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  ISBRANDED = 0;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  FRIENDLYNAME;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  STATE = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  SUBSCRIPTIONSTATE = 0;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  SMALLIMAGEURL;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  MEDIUMIMAGEURL;
    
    [SplusStructAttribute(8, false, false)]
    public CrestronString  LARGEIMAGEURL;
    
    
    public MEDIASERVICESTRUC( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        FRIENDLYNAME  = new CrestronString( Owner.InheritedStringEncoding, 50, Owner );
        SMALLIMAGEURL  = new CrestronString( Owner.InheritedStringEncoding, 250, Owner );
        MEDIUMIMAGEURL  = new CrestronString( Owner.InheritedStringEncoding, 250, Owner );
        LARGEIMAGEURL  = new CrestronString( Owner.InheritedStringEncoding, 250, Owner );
        
        
    }
    
}

}
