// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a start task running on a compute node.
    /// </summary>
    public partial class StartTaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        public StartTaskInformation() { }

        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        /// <param name="state">The state of the start task on the compute
        /// node.</param>
        /// <param name="startTime">The time at which the start task started
        /// running.</param>
        /// <param name="retryCount">The number of times the task has been
        /// retried by the Batch service.</param>
        /// <param name="endTime">The time at which the start task stopped
        /// running.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the task command line.</param>
        /// <param name="schedulingError">Any error encountered scheduling the
        /// start task.</param>
        /// <param name="lastRetryTime">The most recent time at which a retry
        /// of the task started running.</param>
        public StartTaskInformation(StartTaskState state, System.DateTime startTime, int retryCount, System.DateTime? endTime = default(System.DateTime?), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), System.DateTime? lastRetryTime = default(System.DateTime?))
        {
            State = state;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
        }

        /// <summary>
        /// Gets or sets the state of the start task on the compute node.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'running', 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public StartTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task started running.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task stopped running.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the task
        /// command line.
        /// </summary>
        /// <remarks>
        /// This parameter is returned only if the task is in the completed
        /// state. The exit code for a process reflects the specific
        /// convention implemented by the application developer for that
        /// process. If you use the exit code value to make decisions in your
        /// code, be sure that you know the exit code convention used by the
        /// application process. Note that the exit code may also be
        /// generated by the compute node operating system, such as when a
        /// process is forcibly terminated.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets any error encountered scheduling the start task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been retried by the
        /// Batch service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the task
        /// started running.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRetryTime")]
        public System.DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}
