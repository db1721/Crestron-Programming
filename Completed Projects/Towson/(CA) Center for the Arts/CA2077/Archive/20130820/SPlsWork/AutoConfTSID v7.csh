[BEGIN]
  Version=1
[END]
[BEGIN]
  ObjTp=FSgntr
  Sgntr=CresSPlus
  RelVrs=1
  IntStrVrs=1
  SPlusVrs=4.02.20
  CrossCplrVrs=1.3
[END]
[BEGIN]
  ObjTp=Symbol
  Exclusions=1,19,20,21,88,89,167,168,179,213,214,215,216,217,225,226,248,249,266,267,310,718,756,854,
  Exclusions_CDS=6
  Inclusions_CDS=5
  Name=AutoConfTSID v7 (cm)
  SmplCName=AutoConfTSID v7.csp
  Code=1
  SysRev5=3.137
  SMWRev=2.02.05
  InputCue1=Enable
  InputSigType1=Digital
  InputCue2=run
  InputSigType2=Digital
  InputCue3=setOneId
  InputSigType3=Digital
  InputCue4=WipeOutAll
  InputSigType4=Digital
  InputCue5=KeepAutoSetTable
  InputSigType5=Digital
  InputCue6=ppnDiscover
  InputSigType6=Digital
  InputCue7=SetAAETo31
  InputSigType7=Digital
  OutputCue1=waitConsole
  OutputSigType1=Digital
  OutputCue2=busy
  OutputSigType2=Digital
  InputList2Cue1=Id2set
  InputList2SigType1=Analog
  InputList2Cue2=debug_level
  InputList2SigType2=Analog
  InputList2Cue3=type$
  InputList2SigType3=Serial
  InputList2Cue4=cmdIn$
  InputList2SigType4=Serial
  InputList2Cue5=consIn$
  InputList2SigType5=Serial
  InputList2Cue6=Prompt$
  InputList2SigType6=Serial
  OutputList2Cue1=error
  OutputList2SigType1=Analog
  OutputList2Cue2=IdDone
  OutputList2SigType2=Analog
  OutputList2Cue3=consOut$
  OutputList2SigType3=Serial
  OutputList2Cue4=msgOut$
  OutputList2SigType4=Serial
  OutputList2Cue5=response$
  OutputList2SigType5=Serial
  OutputList2Cue6=debOut$
  OutputList2SigType6=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=7
  MaxVariableInputs=7
  MinVariableInputsList2=6
  MaxVariableInputsList2=6
  MinVariableOutputs=2
  MaxVariableOutputs=2
  MinVariableOutputsList2=6
  MaxVariableOutputsList2=6
  MinVariableParams=0
  MaxVariableParams=0
  Expand=expand_separately
  Expand2=expand_separately
  ProgramTree=Logic
  SymbolTree=0
  Hint=
  PdfHelp=
  HelpID= 
  Render=4
  Smpl-C=16
  CompilerCode=-48
  CompilerParamCode=27
  CompilerParamCode5=14
  NumFixedParams=1
  Pp1=1
  MPp=1
  NVStorage=10
  ParamSigType1=String
  SmplCInputCue1=o#
  SmplCOutputCue1=i#
  SmplCInputList2Cue1=an#
  SmplCOutputList2Cue1=ai#
  SPlus2CompiledName=S2_AutoConfTSID_v7
  SymJam=NonExclusive
  FileName=AutoConfTSID v7.csh
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]