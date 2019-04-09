﻿using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using Microshaoft;
using System.Collections.Generic;
using System.Threading;
using System.Activities.Tracking;

namespace WorkflowConsoleApplication
{

    class Program
    {
        private const string _xaml = @"
<Activity mc:Ignorable=""sap sap2010 sads"" x:Class=""WorkFlows.WorkFlow1"" sap2010:ExpressionActivityEditor.ExpressionActivityEditor=""C#"" sap2010:WorkflowViewState.IdRef=""WorkFlows.WorkFlow1_1""
 xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities""
 xmlns:a=""clr-namespace:ActivityLibrary1;assembly=ActivityLibrary1""
 xmlns:a1=""clr-namespace:ActivityLibrary2;assembly=ActivityLibrary2""
 xmlns:av=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
 xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006""
 xmlns:sads=""http://schemas.microsoft.com/netfx/2010/xaml/activities/debugger""
 xmlns:sap=""http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation""
 xmlns:sap2010=""http://schemas.microsoft.com/netfx/2010/xaml/activities/presentation""
 xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib""
 xmlns:sco=""clr-namespace:System.Collections.ObjectModel;assembly=mscorlib""
 xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
  <TextExpression.NamespacesForImplementation>
    <sco:Collection x:TypeArguments=""x:String"">
      <x:String>System</x:String>
      <x:String>System.Collections.Generic</x:String>
      <x:String>System.Data</x:String>
      <x:String>System.Linq</x:String>
      <x:String>System.Text</x:String>
    </sco:Collection>
  </TextExpression.NamespacesForImplementation>
  <TextExpression.ReferencesForImplementation>
    <sco:Collection x:TypeArguments=""AssemblyReference"">
      <AssemblyReference>mscorlib</AssemblyReference>
      <AssemblyReference>System</AssemblyReference>
      <AssemblyReference>System.Core</AssemblyReference>
      <AssemblyReference>System.Data</AssemblyReference>
      <AssemblyReference>System.ServiceModel</AssemblyReference>
      <AssemblyReference>System.Xml</AssemblyReference>
    </sco:Collection>
  </TextExpression.ReferencesForImplementation>
  <Flowchart sap2010:WorkflowViewState.IdRef=""Flowchart_1"">
    <Flowchart.StartNode>
      <FlowStep x:Name=""__ReferenceID0"" sap2010:WorkflowViewState.IdRef=""FlowStep_1"">
        <a:Activity1 sap2010:WorkflowViewState.IdRef=""Activity1_1"" />
        <FlowStep.Next>
          <FlowStep x:Name=""__ReferenceID1"">
            <a:CodeActivity1 Text=""{x:Null}"" sap2010:WorkflowViewState.IdRef=""CodeActivity1_1"" />
            <FlowStep.Next>
              <FlowStep x:Name=""__ReferenceID2"">
                <a1:Activity2 sap2010:WorkflowViewState.IdRef=""Activity2_1"" />
                <FlowStep.Next>
                  <FlowStep x:Name=""__ReferenceID3"">
                    <a1:CodeActivity2 Text=""{x:Null}"" sap2010:WorkflowViewState.IdRef=""CodeActivity2_1"" />
                    <sap2010:WorkflowViewState.IdRef>FlowStep_2</sap2010:WorkflowViewState.IdRef>
                  </FlowStep>
                </FlowStep.Next>
                <sap2010:WorkflowViewState.IdRef>FlowStep_3</sap2010:WorkflowViewState.IdRef>
              </FlowStep>
            </FlowStep.Next>
            <sap2010:WorkflowViewState.IdRef>FlowStep_4</sap2010:WorkflowViewState.IdRef>
          </FlowStep>
        </FlowStep.Next>
      </FlowStep>
    </Flowchart.StartNode>
    <x:Reference>__ReferenceID0</x:Reference>
    <x:Reference>__ReferenceID1</x:Reference>
    <x:Reference>__ReferenceID2</x:Reference>
    <x:Reference>__ReferenceID3</x:Reference>
    <sads:DebugSymbol.Symbol>dz9EOlxNeUdpdEh1YlxXb3JrRmxvd0NvbnNvbGVBcHBsaWNhdGlvblxXb3JrRmxvd3NcV29ya0Zsb3cxLnhhbWwFIAM9DwIBASMJI0YCAQUmDSZiAgEEKREpTwIBAywVLGsCAQI=</sads:DebugSymbol.Symbol>
  </Flowchart>
  <sap2010:WorkflowViewState.ViewStateManager>
    <sap2010:ViewStateManager>
      <sap2010:ViewStateData Id=""Activity1_1"" sap:VirtualizedContainerService.HintSize=""200,22"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""CodeActivity1_1"" sap:VirtualizedContainerService.HintSize=""200,22"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""Activity2_1"" sap:VirtualizedContainerService.HintSize=""200,22"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""CodeActivity2_1"" sap:VirtualizedContainerService.HintSize=""200,22"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">True</x:Boolean>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""FlowStep_2"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <av:Point x:Key=""ShapeLocation"">390,320</av:Point>
            <av:Size x:Key=""ShapeSize"">200,22</av:Size>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""FlowStep_3"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <av:Point x:Key=""ShapeLocation"">290,250</av:Point>
            <av:Size x:Key=""ShapeSize"">200,22</av:Size>
            <av:PointCollection x:Key=""ConnectorLocation"">390,272 390,302 490,302 490,320</av:PointCollection>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""FlowStep_4"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <av:Point x:Key=""ShapeLocation"">180,169</av:Point>
            <av:Size x:Key=""ShapeSize"">200,22</av:Size>
            <av:PointCollection x:Key=""ConnectorLocation"">280,191 280,221 390,221 390,250</av:PointCollection>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""FlowStep_1"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <av:Point x:Key=""ShapeLocation"">200,109</av:Point>
            <av:Size x:Key=""ShapeSize"">200,22</av:Size>
            <av:PointCollection x:Key=""ConnectorLocation"">300,131 300,161 280,161 280,169</av:PointCollection>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""Flowchart_1"" sap:VirtualizedContainerService.HintSize=""614,636"">
        <sap:WorkflowViewStateService.ViewState>
          <scg:Dictionary x:TypeArguments=""x:String, x:Object"">
            <x:Boolean x:Key=""IsExpanded"">False</x:Boolean>
            <av:Point x:Key=""ShapeLocation"">270,2.5</av:Point>
            <av:Size x:Key=""ShapeSize"">60,74.6666666666667</av:Size>
            <av:PointCollection x:Key=""ConnectorLocation"">300,77.1666666666667 300,109</av:PointCollection>
          </scg:Dictionary>
        </sap:WorkflowViewStateService.ViewState>
      </sap2010:ViewStateData>
      <sap2010:ViewStateData Id=""WorkFlows.WorkFlow1_1"" sap:VirtualizedContainerService.HintSize=""654,716"" />
    </sap2010:ViewStateManager>
  </sap2010:WorkflowViewState.ViewStateManager>
</Activity>

";











        static void Main(string[] args)
        {
           

            //WorkflowApplication wfApp =
            //    new WorkflowApplication(new FlowchartNumberGuessWorkflow(), inputs);

            /*
            xmlns:local=""clr-namespace:NumberGuessWorkflowActivities;assembly=NumberGuessWorkflowActivities""
            */
            var wfApp = WorkFlowHelper
                            .CreateWorkflowApplication
                                (
                                    "aa"
                                    , () =>
                                    {
                                        return
                                            _xaml;
                                    }
                                );
            wfApp.Completed = (e) =>
            {
                
            };

            wfApp.Aborted = (e) =>
            {
              
            };

            //wfApp.OnUnhandledException = (e) =>
            //{
            //    Console.WriteLine(e.UnhandledException.ToString());
            //    return UnhandledExceptionAction.Terminate;
            //};

            //wfApp.Idle = (e) =>
            //{
            //    idleEvent.Set();
            //};


            var config = @"{
                                ""WorkflowInstanceQuery"" :
                                                            [{
                                                                ""States"":
                                                                            [
                                                                                ""*""
                                                                            ]
                                                                , ""QueryAnnotations"": {}
                                                            }]
                               , ""ActivityStateQuery"" :
                                                            [{
                                                                ""ActivityName"": ""*""
                                                                , ""Arguments"": []
                                                                , ""Variables"": []
                                                                , ""States"": [""*""]
                                                                , ""QueryAnnotations"": {}
                                                            }]
                                ,
                                ""CustomTrackingQuery"": [{
                                                                ""Name"": ""*"",
                                                                ""ActivityName"": ""*"",
                                                                ""QueryAnnotations"": {}
                                                            }]
                                ,
                                ""FaultPropagationQuery"": [{
                                                                ""FaultHandlerActivityName"": ""*"",
                                                                ""FaultSourceActivityName"": ""*"",
                                                                ""QueryAnnotations"": {}
                                                                }],
                                ""BookmarkResumptionQuery"": [{
                                                                    ""Name"": ""*"",
                                                                    ""QueryAnnotations"": {}
                                                                    }],
                                ""ActivityScheduledQuery"": [{
                                                                ""ActivityName"": ""*"",
                                                                ""ChildActivityName"": ""*"",
                                                                ""QueryAnnotations"": {}
                                                                }],
                                ""CancelRequestedQuery"": [{
                                                                ""ActivityName"": ""*"",
                                                                ""ChildActivityName"": ""*"",
                                                                ""QueryAnnotations"": {}
                                                                }]
                            }";
            var trackingProfile = WorkFlowHelper
                                        .GetTrackingProfileFromJson
                                                (
                                                    config
                                                    , true
                                                );
            var etwTrackingParticipant = new EtwTrackingParticipant();
            etwTrackingParticipant.TrackingProfile = trackingProfile;
            var commonTrackingParticipant = new CommonTrackingParticipant()
            {
                TrackingProfile = trackingProfile
                ,
                OnTrackingRecordReceived = (x, y) =>
                {
                    //Console.WriteLine("{1}{0}{2}", ",", x, y);
                    return true;
                }
            };

            wfApp
                .Extensions
                .Add
                    (
                        etwTrackingParticipant
                    );
            wfApp
                .Extensions
                .Add
                    (
                        commonTrackingParticipant
                    );

            wfApp.Run();

            // Loop until the workflow completes.
            //WaitHandle[] handles = new WaitHandle[] { syncEvent, idleEvent };
            //while (WaitHandle.WaitAny(handles) != 0)
            //{
            //    // Gather the user input and resume the bookmark.
            //    bool validEntry = false;
            //    while (!validEntry)
            //    {
            //        int Guess;
            //        if (!int.TryParse(Console.ReadLine(), out Guess))
            //        {
            //            Console.WriteLine("Please enter an integer.");
            //        }
            //        else
            //        {
            //            validEntry = true;
            //            wfApp.ResumeBookmark("EnterGuess", Guess);
            //        }
            //    }
            //}
            Console.ReadLine();
        }
    }
}
