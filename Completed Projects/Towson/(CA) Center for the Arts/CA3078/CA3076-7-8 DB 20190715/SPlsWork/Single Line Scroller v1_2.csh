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
  Name=Single Line Scroller v1_2 (cm)
  SmplCName=Single Line Scroller v1_2.csp
  Code=1
  SysRev5=4.000
  SMWRev=2.02.05
  InputCue1=diClearBuff
  InputSigType1=Digital
  InputCue2=diScrollUp
  InputSigType2=Digital
  InputCue3=diScrollDn
  InputSigType3=Digital
  InputCue4=diScrollLeft
  InputSigType4=Digital
  InputCue5=diScrollRight
  InputSigType5=Digital
  InputCue6=diJumpToTop
  InputSigType6=Digital
  InputCue7=diJumpToBottom
  InputSigType7=Digital
  OutputCue1=atTop
  OutputSigType1=Digital
  OutputCue2=atBottom
  OutputSigType2=Digital
  InputList2Cue1=aiScrollHorizontalBy
  InputList2SigType1=Analog
  InputList2Cue2=aiNumCharactersOnDisplay
  InputList2SigType2=Analog
  InputList2Cue3=siConsoleCommand$
  InputList2SigType3=Serial
  InputList2Cue4=biFromConsole$
  InputList2SigType4=Serial
  OutputList2Cue1=soToDisplay$
  OutputList2SigType1=Serial
  OutputList2Cue2=soToConsole$
  OutputList2SigType2=Serial
  ParamCue1=[Reference Name]
  MinVariableInputs=7
  MaxVariableInputs=7
  MinVariableInputsList2=4
  MaxVariableInputsList2=4
  MinVariableOutputs=2
  MaxVariableOutputs=2
  MinVariableOutputsList2=2
  MaxVariableOutputsList2=2
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
  SPlus2CompiledName=S2_Single_Line_Scroller_v1_2
  SymJam=NonExclusive
  FileName=Single Line Scroller v1_2.csh
[END]
[BEGIN]
  ObjTp=Dp
  H=1
  Tp=1
  NoS=False
[END]
