#region Header

// Author: Anthony Hart (Anthony | Anthony Hart)
// Authored: 01/31/2016 10:45 PM
// 
// Solution: CensusDataParser
// Project: CensusDataParser
// File: SSISComponentEventHandler.cs
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

    public class SSISComponentEventHandler : IDTSComponentEvents
    {
        #region Implementation of IDTSComponentEvents
        /// <summary>
        ///     Raises an event anytime the task is in a state that does not justify an error, but does warrant alerting the
        ///     client.
        /// </summary>
        /// <param name="warningCode">An Integer that identifies the warning message.</param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="description">The text of the message.</param>
        /// <param name="helpFile">The path to the Help file that contains detailed information.</param>
        /// <param name="helpContext">The identifier of the topic in the Help file.</param>
        public void FireWarning(int warningCode, string subComponent, string description, string helpFile, int helpContext) { Console.WriteLine($"Fire Warning {warningCode} - {subComponent}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}"); }

        /// <summary>
        ///     Raises an event containing information.
        /// </summary>
        /// <param name="informationCode">An Integer that identifies the informational message. </param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="description">The text of the message.</param>
        /// <param name="helpFile">The path to the Help file that contains detailed information.</param>
        /// <param name="helpContext">The identifier of the topic in the Help file.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void FireInformation(int informationCode, string subComponent, string description, string helpFile, int helpContext, ref bool fireAgain) { Console.WriteLine($"Fire Information {informationCode} - {subComponent} | Fire Again?: {fireAgain}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}"); }

        /// <summary>
        ///     Raises an event when an error occurs.
        /// </summary>
        /// <returns>
        ///     A Boolean that indicates whether the event should continue firing or stop firing. A value of true indicates that
        ///     the event should continue firing.
        /// </returns>
        /// <param name="errorCode">An Integer that identifies the error message. </param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="description">The text of the message.</param>
        /// <param name="helpFile">The path to the Help file that contains detailed information.</param>
        /// <param name="helpContext">The identifier of the topic in the Help file.</param>
        public bool FireError(int errorCode, string subComponent, string description, string helpFile, int helpContext)
        {
            Console.WriteLine($"Fire Error {errorCode} - {subComponent}\r\n\t{description}\r\n\t\t{helpFile}\r\n\t\t{helpContext}");
            return false;
        }

        /// <summary>
        ///     Raises an event to determine whether an executable should stop running.
        /// </summary>
        /// <returns>
        ///     A Boolean that indicates if the task should stop running.
        /// </returns>
        public bool FireQueryCancel()
        {
            Console.WriteLine($"Firing of Query has been cancelled");
            return false;
        }

        /// <summary>
        ///     Raises an event when a breakpoint target is hit in the package.
        /// </summary>
        /// <param name="breakpointTarget">
        ///     The <see cref="T:Microsoft.SqlServer.Dts.Runtime.BreakpointTarget" /> in the package
        ///     that should raise this event.
        /// </param>
        public void FireBreakpointHit(BreakpointTarget breakpointTarget) { Console.WriteLine($"Fire Breakpoint Hit\r\n\tID: {breakpointTarget.ID}\r\n\tOwner: {breakpointTarget.Owner}\r\n\tHit Count: {breakpointTarget.HitCount}\r\n\tHit Target: {breakpointTarget.HitTarget}\r\n\tHit Test: {breakpointTarget.HitTest}\r\n\tEnabled: {breakpointTarget.Enabled}\r\n\tBreak On Expression Change: {breakpointTarget.BreakOnExpressionChange}\r\n\tExpression: {breakpointTarget.Expression}\r\n\tDescription: {breakpointTarget.Description}"); }

        /// <summary>
        ///     Raises an event when measurable progress is made by the executable.
        /// </summary>
        /// <param name="progressDescription">A String that describes the progress event that is raised.</param>
        /// <param name="percentComplete">An Integer used to indicate how much of the task has completed.</param>
        /// <param name="progressCountLow">An Integer that contains the low 32-bits of the units completed.</param>
        /// <param name="progressCountHigh">An Integer that contains the high 32-bits of the units completed.</param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void FireProgress(string progressDescription, int percentComplete, int progressCountLow, int progressCountHigh, string subComponent, ref bool fireAgain) { Console.WriteLine($"Fire Progress | {percentComplete}% | {progressCountLow} - {progressCountHigh} | {subComponent} | Fire Again?: {fireAgain}\r\n\t{progressDescription}"); }

        /// <summary>
        ///     Occurs when tasks raise custom task-defined events.
        /// </summary>
        /// <param name="eventName">The name of the event to raise.</param>
        /// <param name="eventText">The text describing the event.</param>
        /// <param name="arguments">An array of arguments to pass to the event.</param>
        /// <param name="subComponent">A String that contains more detail about the event source.</param>
        /// <param name="fireAgain">
        ///     A Boolean that indicates this should continue firing or stop firing. A value of true indicates
        ///     that it should continue firing.
        /// </param>
        public void FireCustomEvent(string eventName, string eventText, ref object[] arguments, string subComponent, ref bool fireAgain) { Console.WriteLine($"Fire Custom Event | {subComponent} | Fire Again?: {fireAgain}\r\n\t{eventName} | {eventText}\r\n\t{arguments.Length} Arguments passed"); }
        #endregion
    }
}
