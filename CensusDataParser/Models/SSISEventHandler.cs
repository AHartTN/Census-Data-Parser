#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 10:45 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SSISEventHandler.cs
// 
// Anthony Hart ("ANTHONY") CONFIDENTIAL
// 
// Unpublished Copyright (c) 1985-2016 Anthony Hart, All Rights Reserved.
// 
// === NOTICE ===
// All information contained herein is, and remains the property of ANTHONY. The intellectual and technical concepts contained
// herein are proprietary to ANTHONY and may be covered by U.S. and Foreign Patents, patents in process, and are protected by trade secret or copyright law.
// Dissemination of this information or reproduction of this material is strictly forbidden unless prior written permission is obtained
// from ANTHONY. Access to the source code contained herein is hereby forbidden to anyone except current ANTHONY employees, managers or contractors who have executed 
// Confidentiality and Non-disclosure agreements explicitly covering such access. 
// 
// The copyright notice above does not evidence any actual or intended publication or disclosure of this source code, which includes 
// information that is confidential and/or proprietary, and is a trade secret, of ANTHONY. ANY REPRODUCTION, MODIFICATION, DISTRIBUTION, PUBLIC PERFORMANCE, 
// OR PUBLIC DISPLAY OF OR THROUGH USE OF THIS SOURCE CODE WITHOUT THE EXPRESS WRITTEN CONSENT OF ANTHONY IS STRICTLY PROHIBITED, AND IN VIOLATION OF APPLICABLE 
// LAWS AND INTERNATIONAL TREATIES. THE RECEIPT OR POSSESSION OF THIS SOURCE CODE AND/OR RELATED INFORMATION DOES NOT CONVEY OR IMPLY ANY RIGHTS 
// TO REPRODUCE, DISCLOSE OR DISTRIBUTE ITS CONTENTS, OR TO MANUFACTURE, USE, OR SELL ANYTHING THAT IT MAY DESCRIBE, IN WHOLE OR IN PART.
// 
// ANTHONY reserves the right to make public any and all contents of this file at the sole discretion of ANTHONY. In such case, licensing included with said publication(s) will supercede this notice only if made public by ANTHONY.
// 
// DISCLAIMERS (When Implemented):
// MAF/TIGER SHAPEFILES AND CENSUS DATA OBTAINED FROM THE US CENSUS BUREAU VIA FTP.
// http://www.census.gov
// ftp://ftp.census.gov
// 
// CRIME/POLICE INFORMATION OBTAINED FROM THE FEDERAL BUREAU OF INVESTIGATIONS VIA HTTP
// http://www.fbi.gov
#endregion

namespace CensusDataParser.Models
{
    #region Using Directives
    using System;
    using Microsoft.SqlServer.Dts.Runtime;
    #endregion

    public class SSISEventHandler : IDTSEvents
    {
        #region Implementation of IDTSEvents
        /// <summary>
        ///     Called when the actual validation logic of the task starts. This event is raised when the validation of the task
        ///     host or container begins.
        /// </summary>
        /// <param name="exec">The task for which this is being called.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnPreValidate(Executable exec, ref bool fireAgain)
        {
            TaskHost task = exec as TaskHost;
            Console.WriteLine($"Pre-Validation for {task?.Name ?? "Unknown Executable"} | Fire Again?: {fireAgain}");
        }

        /// <summary>
        ///     Called immediately after the validation logic of the task completes. This event is raised by a task after the task
        ///     is validated.
        /// </summary>
        /// <param name="exec">The task raising the event.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnPostValidate(Executable exec, ref bool fireAgain)
        {
            TaskHost task = exec as TaskHost;
            Console.WriteLine($"Post-Validation for {task?.Name ?? "Unknown Executable"} | Fire Again?: {fireAgain}");
        }

        /// <summary>
        ///     Called when a task is about to execute. This event is raised by a task or a container immediately before it runs.
        /// </summary>
        /// <param name="exec">The task that is to execute next.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnPreExecute(Executable exec, ref bool fireAgain)
        {
            TaskHost task = exec as TaskHost;
            Console.WriteLine($"Pre-Execution for {task?.Name ?? "Unknown Executable"} | Fire Again?: {fireAgain}");
        }

        /// <summary>
        ///     Called immediately after the execution logic of the task completes. This event is raised by a task or container
        ///     immediately after it runs.
        /// </summary>
        /// <param name="exec">The task that is to execute next.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnPostExecute(Executable exec, ref bool fireAgain)
        {
            TaskHost task = exec as TaskHost;
            Console.WriteLine($"Post-Execution for {task?.Name ?? "Unknown Executable"} | Fire Again?: {fireAgain}");
        }

        /// <summary>
        ///     Called any time the task is in a state that does not justify an error, but does warrant alerting the client.
        /// </summary>
        /// <param name="source">The object that caused the event.</param>
        /// <param name="warningCode">
        ///     An Integer that identifies the warning message. This identifier should be unique when
        ///     combined with the <paramref name="source" /> parameter, so the <paramref name="source" /> and
        ///     <paramref name="warningCode" /> combination should be unique. However, the <paramref name="warningCode" /> alone is
        ///     not expected to be unique.
        /// </param>
        /// <param name="subComponent">
        ///     An arbitrary string that identifies the sub-module within a source. For example, the
        ///     transform in a Pipeline task.
        /// </param>
        /// <param name="description">Text of the message.</param>
        /// <param name="helpFile">The path to the Help file that contains detailed information.</param>
        /// <param name="helpContext">Identifier of the topic in the Help file.</param>
        /// <param name="idofInterfaceWithError">A textual representation of the GUID of the interface that caused the error.</param>
        public void OnWarning(DtsObject source, int warningCode, string subComponent, string description, string helpFile, int helpContext, string idofInterfaceWithError) { Console.WriteLine($"Warning {warningCode} - {subComponent} | {idofInterfaceWithError}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}"); }

        /// <summary>
        ///     Called any time the task is required to provide information.
        /// </summary>
        /// <param name="source">The source of the error, the object that caused the event.</param>
        /// <param name="informationCode">
        ///     An Integer that identifies the message. This identifier should be unique when combined
        ///     with the <paramref name="source" /> parameter, so the <paramref name="source" /> and
        ///     <paramref name="informationCode" /> combination should be unique. However, the <paramref name="informationCode" />
        ///     alone is not expected to be unique.
        /// </param>
        /// <param name="subComponent">
        ///     An arbitrary string that identifies the sub-module within a source. For example, the
        ///     transform in a Pipeline task.
        /// </param>
        /// <param name="description">Text of the message.</param>
        /// <param name="helpFile">The path to the help file containing detailed information.</param>
        /// <param name="helpContext">Identifier of the topic in the Help file.</param>
        /// <param name="idofInterfaceWithError">A textual representation of the GUID of the interface that caused the error.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnInformation(DtsObject source, int informationCode, string subComponent, string description, string helpFile, int helpContext, string idofInterfaceWithError, ref bool fireAgain) { Console.WriteLine($"Information {informationCode} - {subComponent} | {idofInterfaceWithError} | Fire Again? {fireAgain}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}"); }

        /// <summary>
        ///     Called by a task or container when an error occurs.
        /// </summary>
        /// <param name="source">The source of the error, the object that caused the event.</param>
        /// <param name="errorCode">
        ///     An Integer that identifies the error message. This identifier should be unique when combined
        ///     with the <paramref name="source" /> parameter, so the <paramref name="source" /> and <paramref name="errorCode" />
        ///     combination should be unique. However, the <paramref name="errorCode" /> alone is not expected to be unique.
        /// </param>
        /// <param name="subComponent">
        ///     An arbitrary string that identifies the sub-module within a source. For example, the
        ///     transform in a Pipeline task.
        /// </param>
        /// <param name="description">The text of the message.</param>
        /// <param name="helpFile">The path to the Help file that contains detailed information.</param>
        /// <param name="helpContext">Identifier of the topic in the Help file.</param>
        /// <param name="idofInterfaceWithError">A textual representation of the GUID of the interface that caused the error.</param>
        public bool OnError(DtsObject source, int errorCode, string subComponent, string description, string helpFile, int helpContext, string idofInterfaceWithError)
        {
            Console.WriteLine($"Error {errorCode} - {subComponent} | {idofInterfaceWithError}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}");
            return false;
        }

        /// <summary>
        ///     Called by the task host when it fails.
        /// </summary>
        /// <param name="taskHost">The <see cref="T:Microsoft.SqlServer.Dts.Runtime.TaskHost" /> object that failed.</param>
        public void OnTaskFailed(TaskHost taskHost) { Console.WriteLine($"The task named '{taskHost.Name}' ({taskHost.ID}) has failed at {DateTime.UtcNow.ToLongTimeString()} (UTC)!"); }

        /// <summary>
        ///     Called to update progress about task execution.
        /// </summary>
        /// <param name="taskHost">A null value.</param>
        /// <param name="progressDescription">A string that describes the progress event that is raised.</param>
        /// <param name="percentComplete">An integer used to indicate how much of the task has completed.</param>
        /// <param name="progressCountLow">An integer that contains the low 32-bits of the units completed.</param>
        /// <param name="progressCountHigh">An integer that contains the high 32-bits of the units completed.</param>
        /// <param name="subComponent">A string that contains more detail about the event source.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnProgress(TaskHost taskHost, string progressDescription, int percentComplete, int progressCountLow, int progressCountHigh, string subComponent, ref bool fireAgain) { Console.WriteLine($"Progress of {taskHost.Name} ({taskHost.ID})\r\n\t{percentComplete}% | {progressCountLow} - {progressCountHigh} | {subComponent} | Fire Again?: {fireAgain}\r\n\t{progressDescription}"); }

        /// <summary>
        ///     Called at any juncture in task processing where it is feasible to cancel execution. This event is raised by tasks
        ///     and containers to determine whether they should stop running.
        /// </summary>
        /// <returns>
        ///     A Boolean that indicates if the task should stop running.
        /// </returns>
        public bool OnQueryCancel()
        {
            Console.WriteLine("Query has been cancelled");
            return false;
        }

        /// <summary>
        ///     Called when a breakpoint is hit within a task.
        /// </summary>
        /// <param name="breakpointSite">
        ///     An object that implements the
        ///     <see cref="T:Microsoft.SqlServer.Dts.Runtime.IDTSBreakpointSite" /> interface.
        /// </param>
        /// <param name="breakpointTarget">The specific breakpoint in the package.</param>
        public void OnBreakpointHit(IDTSBreakpointSite breakpointSite, BreakpointTarget breakpointTarget) { }

        /// <summary>
        ///     Called by a task or container when its execution status changes.
        /// </summary>
        /// <param name="exec">The task raising the event.</param>
        /// <param name="newStatus">The current status of the executable.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnExecutionStatusChanged(Executable exec, DTSExecStatus newStatus, ref bool fireAgain) { }

        /// <summary>
        ///     Called by the run-time engine. It is not called by tasks.
        /// </summary>
        /// <param name="DtsContainer">The task.</param>
        /// <param name="variable">The variable that changed.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnVariableValueChanged(DtsContainer DtsContainer, Variable variable, ref bool fireAgain) { }

        /// <summary>
        ///     Called by tasks to raise custom task-defined events.
        /// </summary>
        /// <param name="taskHost">The task that is hosting the current task.</param>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventText">The text that describes the event.</param>
        /// <param name="arguments">An array of arguments to pass to the event.</param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void OnCustomEvent(TaskHost taskHost, string eventName, string eventText, ref object[] arguments, string subComponent, ref bool fireAgain) { }
        #endregion
    }
}
